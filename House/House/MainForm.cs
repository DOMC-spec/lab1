using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using House.BusinessLogic;
using House.Models;

namespace House.Forms
{
    public partial class MainForm : Form
    {
        private readonly HouseService _houseService;
        private int? _selectedComplexId;
        private string _addressFilter;

        public MainForm()
        {
            InitializeComponent();
            _houseService = new HouseService();

            // Load logo
            LoadLogo();

            // Configure DataGridView
            ConfigureDataGridView();
        }

        private void LoadLogo()
        {
            try
            {
                string[] possiblePaths = new[]
                {
                    Path.Combine(Application.StartupPath, "logo.png"),
                    Path.Combine(Application.StartupPath, "Resources", "logo.png"),
                    Path.Combine(Directory.GetParent(Application.StartupPath).Parent.Parent.FullName, "logo.png"),
                    Path.Combine(Directory.GetParent(Application.StartupPath).Parent.Parent.FullName, "Resources", "logo.png")
                };

                foreach (var logoPath in possiblePaths)
                {
                    if (File.Exists(logoPath))
                    {
                        pictureBoxLogo.Image = Image.FromFile(logoPath);
                        return;
                    }
                }

                // If logo not found, show warning in debug mode only
#if DEBUG
                MessageBox.Show("Логотип не найден. Проверьте наличие файла logo.png в корне проекта.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
#endif
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки логотипа: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridViewHouses.Font = new Font("Comic Sans MS", 10F);
            dataGridViewHouses.DefaultCellStyle.ForeColor = Color.FromArgb(55, 71, 79);
            dataGridViewHouses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(4, 160, 255);
            dataGridViewHouses.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewHouses.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            dataGridViewHouses.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(55, 71, 79);
            dataGridViewHouses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewHouses.EnableHeadersVisualStyles = false;
            dataGridViewHouses.RowTemplate.Height = 36;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadComplexes();
            LoadHouses();
        }

        private void LoadComplexes()
        {
            try
            {
                var complexes = _houseService.GetAllResidentialComplexes();

                comboBoxComplex.Items.Clear();
                comboBoxComplex.Items.Add(new ComboBoxItem { Text = "Все ЖК", Value = null });

                foreach (var complex in complexes)
                {
                    comboBoxComplex.Items.Add(new ComboBoxItem
                    {
                        Text = complex.Name,
                        Value = complex.Id
                    });
                }

                comboBoxComplex.DisplayMember = "Text";
                comboBoxComplex.ValueMember = "Value";
                comboBoxComplex.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списка ЖК: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHouses()
        {
            try
            {
                var houses = _houseService.GetHouses(_selectedComplexId, _addressFilter);

                var displayData = houses.Select(h => new
                {
                    Id = h.Id,
                    ЖК = h.ComplexName,
                    Улица = h.Street,
                    НомерДома = h.HouseNumber,
                    СтатусЖК = GetStatusText(h.ComplexStatus),
                    ПроданныеКвартиры = h.SoldApartmentsCount,
                    ПродающиесяКвартиры = h.SellingApartmentsCount
                }).ToList();

                dataGridViewHouses.DataSource = displayData;

                // Hide Id column
                if (dataGridViewHouses.Columns["Id"] != null)
                {
                    dataGridViewHouses.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списка домов: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetStatusText(string status)
        {
            switch (status)
            {
                case "plan":
                    return "План";
                case "construction":
                    return "Строительство";
                case "realization":
                    return "Реализация";
                default:
                    return status;
            }
        }

        private void ButtonApplyFilters_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBoxComplex.SelectedItem as ComboBoxItem;
            _selectedComplexId = selectedItem?.Value;
            _addressFilter = string.IsNullOrWhiteSpace(textBoxAddressFilter.Text)
                ? null
                : textBoxAddressFilter.Text.Trim();

            LoadHouses();
        }

        private void ButtonResetFilters_Click(object sender, EventArgs e)
        {
            comboBoxComplex.SelectedIndex = 0;
            textBoxAddressFilter.Clear();
            _selectedComplexId = null;
            _addressFilter = null;

            LoadHouses();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var houseForm = new HouseForm();
            if (houseForm.ShowDialog() == DialogResult.OK)
            {
                LoadHouses();
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewHouses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите дом для редактирования.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int houseId = Convert.ToInt32(dataGridViewHouses.SelectedRows[0].Cells["Id"].Value);
            var house = _houseService.GetHouseById(houseId);

            if (house == null)
            {
                MessageBox.Show("Дом не найден.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var houseForm = new HouseForm(house);
            if (houseForm.ShowDialog() == DialogResult.OK)
            {
                LoadHouses();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewHouses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите дом для удаления.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                "Вы уверены, что хотите удалить выбранный дом?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int houseId = Convert.ToInt32(dataGridViewHouses.SelectedRows[0].Cells["Id"].Value);
                    _houseService.DeleteHouse(houseId);

                    MessageBox.Show("Дом успешно удален.",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadHouses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления дома: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int? Value { get; set; }
        }
    }
}
