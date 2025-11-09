using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace House.Components
{
    public class DecimalTextBox : TextBox
    {
        private decimal _value;
        private bool _isValid = true;

        public DecimalTextBox()
        {
            this.TextChanged += DecimalTextBox_TextChanged;
            this.Leave += DecimalTextBox_Leave;
        }

        public decimal Value
        {
            get { return _value; }
            set
            {
                _value = value;
                this.Text = value.ToString("F2", CultureInfo.InvariantCulture);
                _isValid = true;
            }
        }

        public bool IsValid
        {
            get { return _isValid; }
        }

        private void DecimalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                _value = 0;
                _isValid = true;
                this.BackColor = Color.White;
                return;
            }

            if (decimal.TryParse(this.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal result))
            {
                if (result >= 0)
                {
                    _value = result;
                    _isValid = true;
                    this.BackColor = Color.White;
                }
                else
                {
                    _isValid = false;
                    this.BackColor = Color.FromArgb(255, 200, 200);
                }
            }
            else
            {
                _isValid = false;
                this.BackColor = Color.FromArgb(255, 200, 200);
            }
        }

        private void DecimalTextBox_Leave(object sender, EventArgs e)
        {
            if (_isValid && !string.IsNullOrWhiteSpace(this.Text))
            {
                this.Text = _value.ToString("F2", CultureInfo.InvariantCulture);
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // Allow digits, decimal separator, backspace, and control keys
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Allow only one decimal separator
            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                (this.Text.Contains(".") || this.Text.Contains(",")))
            {
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }
    }
}
