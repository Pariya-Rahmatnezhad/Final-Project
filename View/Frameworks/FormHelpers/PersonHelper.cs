
using System.Text.RegularExpressions;

namespace View.Frameworks.Controllers
{
    public static class PersonHelper
    {
        public static bool IsEmpty(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text);
        }

        public static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }

        public static bool IsValidNId(string id)
        {
            return Regex.IsMatch(id, @"^[0-9]+$");
        }

        public static bool ValidatePersonInputs(TextBox txtFirstName, TextBox txtLastName, TextBox txtNId)
        {
            if (IsEmpty(txtFirstName))
            {
                MessageBox.Show("Please enter the first name!");
                txtFirstName.Focus();
                return false;
            }

            if (!IsValidName(txtFirstName.Text.Trim()))
            {
                MessageBox.Show("First name must only contain English letters!");
                txtFirstName.Focus();
                return false;
            }

            if (IsEmpty(txtLastName))
            {
                MessageBox.Show("Please enter the last name!");
                txtLastName.Focus();
                return false;
            }

            if (!IsValidName(txtLastName.Text.Trim()))
            {
                MessageBox.Show("Last name must only contain English letters!");
                txtLastName.Focus();
                return false;
            }

            if (IsEmpty(txtNId))
            {
                MessageBox.Show("Please enter the National Id!");
                txtNId.Focus();
                return false;
            }

            if (!IsValidNId(txtNId.Text.Trim()))
            {
                MessageBox.Show("National Id must contain only digits!");
                txtNId.Focus();
                return false;
            }

            return true;
        }

        public static bool HasChanges(string currentFirstName, string currentLastName,string currentNId, TextBox txtFirstName, TextBox txtLastName, TextBox txtNId)
        {
            return currentFirstName != txtFirstName.Text.Trim() || currentLastName != txtLastName.Text.Trim() || currentNId != txtNId.Text.Trim();
        }
    }
}
