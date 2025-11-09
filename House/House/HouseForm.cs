using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using House.BusinessLogic;
using House.Models;

namespace House.Forms
{
    public partial class HouseForm : Form
    {
        private readonly HouseService _houseService;
        private readonly HouseModel _house;
        private readonly bool _isEditMode;

        public HouseForm(HouseModel house = null)
        {
            InitializeComponent();
            _houseService = new HouseService();
            _house = house;
            _isEditMode = house != null;

            LoadLogo();
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

        private void HouseForm_Load(object sender, EventArgs e)
        {
            LoadComplexes();

            if (_isEditMode)
            {
                labelTitle.Text = "Редактирование дома";
                LoadHouseData();
            }
            else
            {
                labelTitle.Text = "Добавление дома";
            }
        }

        private void LoadComplexes()
        {
            try
            {
                var complexes = _houseService.GetAllResidentialComplexes();

                comboBoxComplex.Items.Clear();
                comboBoxComplex.DisplayMember = "Name";
                comboBoxComplex.ValueMember = "Id";

                foreach (var complex in complexes)
                {
                    comboBoxComplex.Items.Add(complex);
                }

                if (comboBoxComplex.Items.Count > 0)
                {
                    comboBoxComplex.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списка ЖК: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHouseData()
        {
            if (_house == null) return;

            // Select complex
            for (int i = 0; i < comboBoxComplex.Items.Count; i++)
            {
                var complex = comboBoxComplex.Items[i] as ResidentialComplex;
                if (complex != null && complex.Id == _house.ResidentialComplexId)
                {
                    comboBoxComplex.SelectedIndex = i;
                    break;
                }
            }

            textBoxStreet.Text = _house.Street;
            textBoxHouseNumber.Text = _house.HouseNumber;
            textBoxAdditionalCost.Value = _house.HouseCostCoefficient;
            textBoxConstructionCost.Value = _house.ConstructionCost;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                var selectedComplex = comboBoxComplex.SelectedItem as ResidentialComplex;

                if (_isEditMode)
                {
                    _house.ResidentialComplexId = selectedComplex.Id;
                    _house.Street = textBoxStreet.Text.Trim();
                    _house.HouseNumber = textBoxHouseNumber.Text.Trim();
                    _house.HouseCostCoefficient = textBoxAdditionalCost.Value;
                    _house.ConstructionCost = textBoxConstructionCost.Value;

                    _houseService.UpdateHouse(_house);

                    MessageBox.Show("Дом успешно обновлен.",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var newHouse = new HouseModel
                    {
                        ResidentialComplexId = selectedComplex.Id,
                        Street = textBoxStreet.Text.Trim(),
                        HouseNumber = textBoxHouseNumber.Text.Trim(),
                        HouseCostCoefficient = textBoxAdditionalCost.Value,
                        ConstructionCost = textBoxConstructionCost.Value
                    };

                    _houseService.CreateHouse(newHouse);

                    MessageBox.Show("Дом успешно создан.",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения дома: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (comboBoxComplex.SelectedItem == null)
            {
                MessageBox.Show("Выберите жилищный комплекс.",
                    "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxComplex.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxStreet.Text))
            {
                MessageBox.Show("Введите название улицы.",
                    "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxStreet.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxHouseNumber.Text))
            {
                MessageBox.Show("Введите номер дома.",
                    "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHouseNumber.Focus();
                return false;
            }

            if (!textBoxAdditionalCost.IsValid)
            {
                MessageBox.Show("Введите корректное значение добавочной стоимости.",
                    "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAdditionalCost.Focus();
                return false;
            }

            if (!textBoxConstructionCost.IsValid)
            {
                MessageBox.Show("Введите корректное значение затрат на строительство.",
                    "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxConstructionCost.Focus();
                return false;
            }

            return true;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
