using ApplicationService.Dtos.PersonDtos;
using ApplicationService.Services;
using View.Frameworks.Controllers;

namespace View
{
    public partial class PersonForm : Form
    {
        private readonly PersonApplicationService _personApplicationService;
        private readonly MainForm _mainForm;

        public PersonForm(MainForm mainForm)
        {
            InitializeComponent();
            _personApplicationService = new PersonApplicationService();
            _mainForm = mainForm;
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            FormButtonController.SetInitialState(btnPost, btnPut, btnDelete);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (!PersonController.ValidatePersonInputs(txtFirstName, txtLastName)) return;

            var postPersonDto = new PostPersonDto()
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
            };
            _personApplicationService.Post(postPersonDto);

            RefreshData();

            MessageBox.Show($"The Person {postPersonDto.FirstName},{postPersonDto.LastName} is registered successfully!");

            ResetForm();
        }

        private void btnPut_Click(object sender, EventArgs e)
        {

            if (!PersonController.ValidatePersonInputs(txtFirstName, txtLastName)) return;

            var row = dgvPerson.SelectedRows[0];
            var currentFirstName = row.Cells["FirstName"].Value.ToString().Trim();
            var currentLastName = row.Cells["LastName"].Value.ToString().Trim();

            if (!PersonController.HasChanges(currentFirstName, currentLastName, txtFirstName, txtLastName))
            {
                MessageBox.Show("Please change at least one field!");
                return;
            }

            var id = Convert.ToInt32(row.Cells["Id"].Value);

            var putPersonDto = new PutPersonDto()
            {
                Id = id,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
            };

            _personApplicationService.Put(putPersonDto);

            RefreshData();

            MessageBox.Show($"The Person {putPersonDto.FirstName},{putPersonDto.LastName} is updated successfully!");

            ResetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var row = dgvPerson.SelectedRows[0];

            var id = Convert.ToInt32(row.Cells["id"].Value);
            var firstName = row.Cells["FirstName"].Value.ToString();
            var lastName = row.Cells["LastName"].Value.ToString();

            var deletePersonDto = new DeletePersonDto() { Id = id };

            _personApplicationService.Delete(deletePersonDto);

            RefreshData();

            MessageBox.Show($"The Person {firstName},{lastName} is deleted successfully!");

            ResetForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void dgvPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPerson.Rows[e.RowIndex];
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();

                FormButtonController.EnableEditAndDelete(btnPost, btnPut, btnDelete);
            }
        }

        private void dgvPerson_MouseClick(object sender, MouseEventArgs e)
        {
            var hit = dgvPerson.HitTest(e.X, e.Y);

            if (hit.RowIndex == -1)
            {
                ResetForm();
            }
        }


        #region [- Form Helpers -]
        private void ResetForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Focus();

            FormButtonController.SetInitialState(btnPost, btnPut, btnDelete);
        }

        private void RefreshData()
        {
            dgvPerson.DataSource = _personApplicationService.GetAll();
        }
        #endregion
    }
}
