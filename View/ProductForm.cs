using ApplicationService.Dtos.ProductDtos;
using ApplicationService.Services;
using Model.ServiceModels;
using View.Frameworks.Controllers;

namespace View
{
    public partial class ProductForm : Form
    {
        private readonly ProductApplicationService _productApplicationService;
        private readonly MainForm _mainForm;

        public ProductForm(MainForm mainForm)
        {
            InitializeComponent();
            _productApplicationService = new ProductApplicationService();
            _mainForm = mainForm;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            FormButtonController.SetInitialState(btnPost, btnPut, btnDelete);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (!ProductController.ValidateProductInputs(txtProductCode, txtProductTitle, txtProductUnitPrice, nudProductQuantity)) return;

            PostProductDto postProductDto = new PostProductDto()
            {
                Code = int.Parse(txtProductCode.Text),
                Title = txtProductTitle.Text,
                UnitPrice = decimal.Parse(txtProductUnitPrice.Text),
                Quantity = (int)nudProductQuantity.Value,
            };
            _productApplicationService.Post(postProductDto);

            RefreshData();

            MessageBox.Show(
                $"The product is registered successfully!\n" +
                $"Code: {postProductDto.Code}\n" +
                $"Title: {postProductDto.Title}\n" +
                $"UnitPrice: {postProductDto.UnitPrice:0.##}\n" +
                $"Quantity: {postProductDto.Quantity}"
                );

            ResetForm();
        }


        private void btnPut_Click(object sender, EventArgs e)
        {
            if (!ProductController.ValidateProductInputs(txtProductCode, txtProductTitle, txtProductUnitPrice, nudProductQuantity)) return;

            var row = dgvProduct.SelectedRows[0];

            var currentCode = Convert.ToInt32(row.Cells["Code"].Value);
            var currentTitle = row.Cells["Title"].Value.ToString();
            var currentUnitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
            var currentQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);

            if (!ProductController.HasChanges(currentCode, currentTitle, currentUnitPrice, currentQuantity, txtProductCode, txtProductTitle, txtProductUnitPrice, nudProductQuantity))
                {
                    MessageBox.Show("Please change at least one field!");
                    return;
                }

            var id = Convert.ToInt32(row.Cells["Id"].Value);

            var putProductDto = new PutProductDto()
            {
                Id = id,
                Code = int.Parse(txtProductCode.Text),
                Title = txtProductTitle.Text,
                UnitPrice = decimal.Parse(txtProductUnitPrice.Text),
                Quantity = (int)nudProductQuantity.Value,
            };

            _productApplicationService.Put(putProductDto);

            RefreshData();

            MessageBox.Show(
                $"The product is updated successfully!\n" +
                $"Code: {putProductDto.Code}\n" +
                $"Title: {putProductDto.Title}\n" +
                $"UnitPrice: {putProductDto.UnitPrice:0.##}\n" +
                $"Quantity: {putProductDto.Quantity}"
                );

            ResetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var row = dgvProduct.SelectedRows[0];

            var id = Convert.ToInt32(row.Cells["Id"].Value);
            var code = row.Cells["Code"].Value;
            var title = row.Cells["Title"].Value;
            var unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value).ToString("0.##");
            var quantity = row.Cells["Quantity"].Value;

            var deletedProductDto = new DeleteProductDto() { Id = id };

            _productApplicationService.Delete(deletedProductDto);

            RefreshData();

            MessageBox.Show(
                $"The product is deleted successfully!\n" +
                $"Code: {code}\n" +
                $"Title: {title}\n" +
                $"UnitPrice: {unitPrice}\n" +
                $"Quantity: {quantity}"
                );

            ResetForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProduct.Rows[e.RowIndex];

                txtProductCode.Text = row.Cells["Code"].Value.ToString();
                txtProductTitle.Text = row.Cells["Title"].Value.ToString();
                txtProductUnitPrice.Text = Convert.ToDecimal(row.Cells["UnitPrice"].Value).ToString("0.##");
                nudProductQuantity.Value = Convert.ToDecimal(row.Cells["Quantity"].Value);
            }

            FormButtonController.EnableEditAndDelete(btnPost, btnPut, btnDelete);
        }

        private void dgvProduct_MouseClick(object sender, MouseEventArgs e)
        {
            var hit = dgvProduct.HitTest(e.X, e.Y);

            if (hit.RowIndex == -1)
            {
                ResetForm();
            }
        }

        #region [- Form Helpers -]
        private void ResetForm()
        {
            txtProductCode.Clear();
            txtProductTitle.Clear();
            txtProductUnitPrice.Clear();
            nudProductQuantity.Value = 0;

            txtProductCode.Focus();

            FormButtonController.SetInitialState(btnPost, btnPut, btnDelete);
        }

        private void RefreshData()
        {
            dgvProduct.DataSource = _productApplicationService.GetAll();
            dgvProduct.Columns["UnitPrice"].DefaultCellStyle.Format = "0.##";
        }
    }
        #endregion
}