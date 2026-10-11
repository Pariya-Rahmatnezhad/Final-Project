namespace View
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProduct = new DataGridView();
            txtProductTitle = new TextBox();
            txtProductCode = new TextBox();
            lblProductTitle = new Label();
            lblProductCode = new Label();
            btnBack = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnPut = new Button();
            btnPost = new Button();
            txtProductUnitPrice = new TextBox();
            lblProductQuantity = new Label();
            lblProductUnitPrice = new Label();
            nudProductQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProductQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(36, 302);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(852, 202);
            dgvProduct.TabIndex = 19;
            dgvProduct.CellDoubleClick += dgvProduct_CellDoubleClick;
            dgvProduct.MouseClick += dgvProduct_MouseClick;
            // 
            // txtProductTitle
            // 
            txtProductTitle.Location = new Point(114, 150);
            txtProductTitle.Name = "txtProductTitle";
            txtProductTitle.Size = new Size(668, 27);
            txtProductTitle.TabIndex = 18;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(114, 100);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(668, 27);
            txtProductCode.TabIndex = 0;
            // 
            // lblProductTitle
            // 
            lblProductTitle.AutoSize = true;
            lblProductTitle.Location = new Point(67, 157);
            lblProductTitle.Name = "lblProductTitle";
            lblProductTitle.Size = new Size(41, 20);
            lblProductTitle.TabIndex = 17;
            lblProductTitle.Text = "Title:";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(61, 107);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(47, 20);
            lblProductCode.TabIndex = 16;
            lblProductCode.Text = "Code:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(808, 39);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(585, 39);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(146, 29);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(400, 39);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPut
            // 
            btnPut.Location = new Point(211, 39);
            btnPut.Name = "btnPut";
            btnPut.Size = new Size(157, 29);
            btnPut.TabIndex = 12;
            btnPut.Text = "Edit";
            btnPut.UseVisualStyleBackColor = true;
            btnPut.Click += btnPut_Click;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(26, 39);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(157, 29);
            btnPost.TabIndex = 11;
            btnPost.Text = "Save";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // txtProductUnitPrice
            // 
            txtProductUnitPrice.Location = new Point(114, 199);
            txtProductUnitPrice.Name = "txtProductUnitPrice";
            txtProductUnitPrice.Size = new Size(668, 27);
            txtProductUnitPrice.TabIndex = 20;
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(42, 249);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(68, 20);
            lblProductQuantity.TabIndex = 22;
            lblProductQuantity.Text = "Quantity:";
            // 
            // lblProductUnitPrice
            // 
            lblProductUnitPrice.AutoSize = true;
            lblProductUnitPrice.Location = new Point(35, 202);
            lblProductUnitPrice.Name = "lblProductUnitPrice";
            lblProductUnitPrice.Size = new Size(75, 20);
            lblProductUnitPrice.TabIndex = 21;
            lblProductUnitPrice.Text = "Unit Price:";
            // 
            // nudProductQuantity
            // 
            nudProductQuantity.Location = new Point(116, 247);
            nudProductQuantity.Name = "nudProductQuantity";
            nudProductQuantity.Size = new Size(179, 27);
            nudProductQuantity.TabIndex = 23;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 528);
            Controls.Add(nudProductQuantity);
            Controls.Add(txtProductUnitPrice);
            Controls.Add(lblProductQuantity);
            Controls.Add(lblProductUnitPrice);
            Controls.Add(dgvProduct);
            Controls.Add(txtProductTitle);
            Controls.Add(txtProductCode);
            Controls.Add(lblProductTitle);
            Controls.Add(lblProductCode);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnPut);
            Controls.Add(btnPost);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProductQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduct;
        private TextBox txtProductTitle;
        private TextBox txtProductCode;
        private Label lblProductTitle;
        private Label lblProductCode;
        private Button btnBack;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnPut;
        private Button btnPost;
        private TextBox txtProductUnitPrice;
        private Label lblProductQuantity;
        private Label lblProductUnitPrice;
        private NumericUpDown nudProductQuantity;
    }
}