using House.Components;

namespace House.Forms
{
    partial class HouseForm
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.labelComplex = new System.Windows.Forms.Label();
            this.comboBoxComplex = new System.Windows.Forms.ComboBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelHouseNumber = new System.Windows.Forms.Label();
            this.textBoxHouseNumber = new System.Windows.Forms.TextBox();
            this.labelAdditionalCost = new System.Windows.Forms.Label();
            this.textBoxAdditionalCost = new House.Components.DecimalTextBox();
            this.labelConstructionCost = new System.Windows.Forms.Label();
            this.textBoxConstructionCost = new House.Components.DecimalTextBox();
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelActions.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(600, 80);
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
            this.labelTitle.Size = new System.Drawing.Size(100, 23);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Дом";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.labelComplex);
            this.panelContent.Controls.Add(this.comboBoxComplex);
            this.panelContent.Controls.Add(this.labelStreet);
            this.panelContent.Controls.Add(this.textBoxStreet);
            this.panelContent.Controls.Add(this.labelHouseNumber);
            this.panelContent.Controls.Add(this.textBoxHouseNumber);
            this.panelContent.Controls.Add(this.labelAdditionalCost);
            this.panelContent.Controls.Add(this.textBoxAdditionalCost);
            this.panelContent.Controls.Add(this.labelConstructionCost);
            this.panelContent.Controls.Add(this.textBoxConstructionCost);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 80);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(15);
            this.panelContent.Size = new System.Drawing.Size(600, 420);
            this.panelContent.TabIndex = 1;
            // 
            // labelComplex
            // 
            this.labelComplex.AutoSize = true;
            this.labelComplex.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelComplex.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            this.labelComplex.Location = new System.Drawing.Point(15, 15);
            this.labelComplex.Name = "labelComplex";
            this.labelComplex.Size = new System.Drawing.Size(34, 19);
            this.labelComplex.TabIndex = 0;
            this.labelComplex.Text = "ЖК:";
            // 
            // comboBoxComplex
            // 
            this.comboBoxComplex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComplex.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.comboBoxComplex.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.comboBoxComplex.FormattingEnabled = true;
            this.comboBoxComplex.Location = new System.Drawing.Point(15, 39);
            this.comboBoxComplex.Name = "comboBoxComplex";
            this.comboBoxComplex.Size = new System.Drawing.Size(570, 26);
            this.comboBoxComplex.TabIndex = 1;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelStreet.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            this.labelStreet.Location = new System.Drawing.Point(15, 80);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(56, 19);
            this.labelStreet.TabIndex = 2;
            this.labelStreet.Text = "Улица:";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.textBoxStreet.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.textBoxStreet.Location = new System.Drawing.Point(15, 104);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(570, 26);
            this.textBoxStreet.TabIndex = 3;
            // 
            // labelHouseNumber
            // 
            this.labelHouseNumber.AutoSize = true;
            this.labelHouseNumber.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelHouseNumber.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            this.labelHouseNumber.Location = new System.Drawing.Point(15, 145);
            this.labelHouseNumber.Name = "labelHouseNumber";
            this.labelHouseNumber.Size = new System.Drawing.Size(96, 19);
            this.labelHouseNumber.TabIndex = 4;
            this.labelHouseNumber.Text = "Номер дома:";
            // 
            // textBoxHouseNumber
            // 
            this.textBoxHouseNumber.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.textBoxHouseNumber.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.textBoxHouseNumber.Location = new System.Drawing.Point(15, 169);
            this.textBoxHouseNumber.Name = "textBoxHouseNumber";
            this.textBoxHouseNumber.Size = new System.Drawing.Size(570, 26);
            this.textBoxHouseNumber.TabIndex = 5;
            // 
            // labelAdditionalCost
            // 
            this.labelAdditionalCost.AutoSize = true;
            this.labelAdditionalCost.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelAdditionalCost.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            this.labelAdditionalCost.Location = new System.Drawing.Point(15, 210);
            this.labelAdditionalCost.Name = "labelAdditionalCost";
            this.labelAdditionalCost.Size = new System.Drawing.Size(298, 19);
            this.labelAdditionalCost.TabIndex = 6;
            this.labelAdditionalCost.Text = "Добавочная стоимость строительства (₽):";
            // 
            // textBoxAdditionalCost
            // 
            this.textBoxAdditionalCost.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.textBoxAdditionalCost.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.textBoxAdditionalCost.Location = new System.Drawing.Point(15, 234);
            this.textBoxAdditionalCost.Name = "textBoxAdditionalCost";
            this.textBoxAdditionalCost.Size = new System.Drawing.Size(570, 26);
            this.textBoxAdditionalCost.TabIndex = 7;
            // 
            // labelConstructionCost
            // 
            this.labelConstructionCost.AutoSize = true;
            this.labelConstructionCost.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelConstructionCost.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            this.labelConstructionCost.Location = new System.Drawing.Point(15, 275);
            this.labelConstructionCost.Name = "labelConstructionCost";
            this.labelConstructionCost.Size = new System.Drawing.Size(226, 19);
            this.labelConstructionCost.TabIndex = 8;
            this.labelConstructionCost.Text = "Затраты на строительство (₽):";
            // 
            // textBoxConstructionCost
            // 
            this.textBoxConstructionCost.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.textBoxConstructionCost.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.textBoxConstructionCost.Location = new System.Drawing.Point(15, 299);
            this.textBoxConstructionCost.Name = "textBoxConstructionCost";
            this.textBoxConstructionCost.Size = new System.Drawing.Size(570, 26);
            this.textBoxConstructionCost.TabIndex = 9;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.White;
            this.panelActions.Controls.Add(this.buttonSave);
            this.panelActions.Controls.Add(this.buttonCancel);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 500);
            this.panelActions.Name = "panelActions";
            this.panelActions.Padding = new System.Windows.Forms.Padding(15);
            this.panelActions.Size = new System.Drawing.Size(600, 80);
            this.panelActions.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(4, 160, 255);
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(15, 22);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 36);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.buttonCancel.Location = new System.Drawing.Point(180, 22);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 36);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // HouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 580);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Esoft - Дом";
            this.Load += new System.EventHandler(this.HouseForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelComplex;
        private System.Windows.Forms.ComboBox comboBoxComplex;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelHouseNumber;
        private System.Windows.Forms.TextBox textBoxHouseNumber;
        private System.Windows.Forms.Label labelAdditionalCost;
        private House.Components.DecimalTextBox textBoxAdditionalCost;
        private System.Windows.Forms.Label labelConstructionCost;
        private House.Components.DecimalTextBox textBoxConstructionCost;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
