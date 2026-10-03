using ApplicationService.Dtos;
using ApplicationService.Services;

namespace View
{
    public partial class Form1 : Form
    {
        private readonly PersonApplicationService _personApplicationService;
        public Form1()
        {
            InitializeComponent();
            _personApplicationService = new PersonApplicationService();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPerson.DataSource = _personApplicationService.GetAll();
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Focus();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var postPersonDto = new PostPersonDto()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
            };
            _personApplicationService.Post(postPersonDto);
            MessageBox.Show($"The Person {postPersonDto.FirstName},{postPersonDto.LastName} is registered successfully!");
        }
    }
}
