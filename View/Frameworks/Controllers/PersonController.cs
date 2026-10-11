
namespace View.Frameworks.Controllers
{
    public static class PersonController
    {
        public static bool IsEmpty(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text);
        }

        public static bool ValidatePersonInputs(TextBox txtFirstName, TextBox txtLastName)
        {
            if (IsEmpty(txtFirstName))
            {
                MessageBox.Show("Please enter the first name!");
                txtFirstName.Focus();
                return false;
            }
            if (IsEmpty(txtLastName))
            {
                MessageBox.Show("Please enter the last name!");
                txtLastName.Focus();
                return false;
            }

            return true;
        }

        public static bool HasChanges(string currentFirstName, string currentLastName, TextBox txtFirstName, TextBox txtLastName)
        {
            return currentFirstName != txtFirstName.Text.Trim() || currentLastName != txtLastName.Text.Trim();
        }
    }
}
