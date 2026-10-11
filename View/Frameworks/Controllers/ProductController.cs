
namespace View.Frameworks.Controllers
{
    public class ProductController
    {
        public static bool IsEmpty(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text);
        }

        public static bool IsZero(NumericUpDown numericUpDown)
        {
            return numericUpDown.Value == 0;
        }

        public static bool IsValidCode(TextBox textBox)
        {
            return int.TryParse(textBox.Text, out int code) && code > 0;
        }

        public static bool IsValidPrice(TextBox textBox)
        {
            return decimal.TryParse(textBox.Text, out decimal price) && price > 0;
        }

        public static bool ValidateProductInputs(TextBox txtProductCode, TextBox txtProductTitle, TextBox txtProductUnitPrice, NumericUpDown nudProductQuantity)
        {
            if (IsEmpty(txtProductCode))
            {
                MessageBox.Show("Please enter the product code!");
                txtProductCode.Focus();
                return false;
            }

            if(!IsValidCode(txtProductCode))
            {
                MessageBox.Show("Product code must be a positive integer!");
                txtProductCode.Focus();
                return false;
            }
             

            if (IsEmpty(txtProductTitle))
            {
                MessageBox.Show("Please enter the product title!");
                txtProductTitle.Focus();
                return false;
            }

            if (IsEmpty(txtProductUnitPrice))
            {
                MessageBox.Show("Please enter the product unit price!");
                txtProductUnitPrice.Focus();
                return false;
            }

            if(!IsValidPrice(txtProductUnitPrice))
            {
                MessageBox.Show("Product unit price must be greater than zero!");
                txtProductUnitPrice.Focus();
                return false;
            }

            if (IsZero(nudProductQuantity)) 
            {
                MessageBox.Show("Product quantity cannot be zero!");
                nudProductQuantity.Focus();
                return false;
            }

            return true;
        }

        public static bool HasChanges(int currentCode, string currentTitle, decimal currentUnitPrice, int currentQuantity, TextBox txtProductCode, TextBox txtProductTitle, TextBox txtProductUnitPrice, NumericUpDown nudProductQuantity)
        {
            return currentCode != int.Parse(txtProductCode.Text) ||
                   currentTitle != txtProductTitle.Text ||
                   currentUnitPrice != decimal.Parse(txtProductUnitPrice.Text) ||
                   currentQuantity != (int)nudProductQuantity.Value;
        }
    }
}
