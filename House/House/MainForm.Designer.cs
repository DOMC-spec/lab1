namespace House.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.labelFilters = new System.Windows.Forms.Label();
            this.labelComplexFilter = new System.Windows.Forms.Label();
            this.comboBoxComplex = new System.Windows.Forms.ComboBox();
            this.labelAddressFilter = new System.Windows.Forms.Label();
            this.textBoxAddressFilter = new System.Windows.Forms.TextBox();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.buttonResetFilters = new System.Windows.Forms.Button();
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewHouses = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelFilters.SuspendLayout();
            this.panelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(15);
            this.panelHeader.Size = new System.Drawing.Size(1200, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(15, 15);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.labelTitle.Location = new System.Drawing.Point(80, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(180, 23);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Управление домами";
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.White;
            this.panelFilters.Controls.Add(this.labelFilters);
            this.panelFilters.Controls.Add(this.labelComplexFilter);
            this.panelFilters.Controls.Add(this.comboBoxComplex);
            this.panelFilters.Controls.Add(this.labelAddressFilter);
            this.panelFilters.Controls.Add(this.textBoxAddressFilter);
            this.panelFilters.Controls.Add(this.buttonApplyFilters);
            this.panelFilters.Controls.Add(this.buttonResetFilters);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 80);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Padding = new System.Windows.Forms.Padding(15);
            this.panelFilters.Size = new System.Drawing.Size(1200, 120);
            this.panelFilters.TabIndex = 1;
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labelFilters.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.labelFilters.Location = new System.Drawing.Point(15, 15);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(82, 19);
            this.labelFilters.TabIndex = 0;
            this.labelFilters.Text = "Фильтры";
            // 
            // labelComplexFilter
            // 
            this.labelComplexFilter.AutoSize = true;
            this.labelComplexFilter.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelComplexFilter.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            this.labelComplexFilter.Location = new System.Drawing.Point(15, 49);
            this.labelComplexFilter.Name = "labelComplexFilter";
            this.labelComplexFilter.Size = new System.Drawing.Size(34, 19);
            this.labelComplexFilter.TabIndex = 1;
            this.labelComplexFilter.Text = "ЖК:";
            // 
            // comboBoxComplex
            // 
            this.comboBoxComplex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComplex.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.comboBoxComplex.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.comboBoxComplex.FormattingEnabled = true;
            this.comboBoxComplex.Location = new System.Drawing.Point(15, 73);
            this.comboBoxComplex.Name = "comboBoxComplex";
            this.comboBoxComplex.Size = new System.Drawing.Size(300, 26);
            this.comboBoxComplex.TabIndex = 2;
            // 
            // labelAddressFilter
            // 
            this.labelAddressFilter.AutoSize = true;
            this.labelAddressFilter.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelAddressFilter.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            this.labelAddressFilter.Location = new System.Drawing.Point(330, 49);
            this.labelAddressFilter.Name = "labelAddressFilter";
            this.labelAddressFilter.Size = new System.Drawing.Size(53, 19);
            this.labelAddressFilter.TabIndex = 3;
            this.labelAddressFilter.Text = "Адрес:";
            // 
            // textBoxAddressFilter
            // 
            this.textBoxAddressFilter.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.textBoxAddressFilter.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.textBoxAddressFilter.Location = new System.Drawing.Point(330, 73);
            this.textBoxAddressFilter.Name = "textBoxAddressFilter";
            this.textBoxAddressFilter.Size = new System.Drawing.Size(300, 26);
            this.textBoxAddressFilter.TabIndex = 4;
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.BackColor = System.Drawing.Color.FromArgb(4, 160, 255);
            this.buttonApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyFilters.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.buttonApplyFilters.ForeColor = System.Drawing.Color.White;
            this.buttonApplyFilters.Location = new System.Drawing.Point(645, 67);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(120, 36);
            this.buttonApplyFilters.TabIndex = 5;
            this.buttonApplyFilters.Text = "Применить";
            this.buttonApplyFilters.UseVisualStyleBackColor = false;
            this.buttonApplyFilters.Click += new System.EventHandler(this.ButtonApplyFilters_Click);
            // 
            // buttonResetFilters
            // 
            this.buttonResetFilters.BackColor = System.Drawing.Color.White;
            this.buttonResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetFilters.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.buttonResetFilters.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            this.buttonResetFilters.Location = new System.Drawing.Point(780, 67);
            this.buttonResetFilters.Name = "buttonResetFilters";
            this.buttonResetFilters.Size = new System.Drawing.Size(120, 36);
            this.buttonResetFilters.TabIndex = 6;
            this.buttonResetFilters.Text = "Сбросить";
            this.buttonResetFilters.UseVisualStyleBackColor = false;
            this.buttonResetFilters.Click += new System.EventHandler(this.ButtonResetFilters_Click);
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.White;
            this.panelActions.Controls.Add(this.buttonAdd);
            this.panelActions.Controls.Add(this.buttonEdit);
            this.panelActions.Controls.Add(this.buttonDelete);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 620);
            this.panelActions.Name = "panelActions";
            this.panelActions.Padding = new System.Windows.Forms.Padding(15);
            this.panelActions.Size = new System.Drawing.Size(1200, 80);
            this.panelActions.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(4, 160, 255);
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(15, 22);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 36);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.buttonEdit.Location = new System.Drawing.Point(180, 22);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 36);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.buttonDelete.Location = new System.Drawing.Point(345, 22);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 36);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // dataGridViewHouses
            // 
            this.dataGridViewHouses.AllowUserToAddRows = false;
            this.dataGridViewHouses.AllowUserToDeleteRows = false;
            this.dataGridViewHouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHouses.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHouses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHouses.Location = new System.Drawing.Point(0, 200);
            this.dataGridViewHouses.MultiSelect = false;
            this.dataGridViewHouses.Name = "dataGridViewHouses";
            this.dataGridViewHouses.ReadOnly = true;
            this.dataGridViewHouses.RowHeadersVisible = false;
            this.dataGridViewHouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHouses.Size = new System.Drawing.Size(1200, 420);
            this.dataGridViewHouses.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.dataGridViewHouses);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esoft - Управление домами";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHouses)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Label labelComplexFilter;
        private System.Windows.Forms.ComboBox comboBoxComplex;
        private System.Windows.Forms.Label labelAddressFilter;
        private System.Windows.Forms.TextBox textBoxAddressFilter;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.Button buttonResetFilters;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewHouses;
    }
}
