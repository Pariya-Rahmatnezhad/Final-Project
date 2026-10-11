namespace View
{
    partial class PersonForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPost = new Button();
            btnPut = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnBack = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            dgvPerson = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            // 
            // btnPost
            // 
            btnPost.Location = new Point(23, 35);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(157, 29);
            btnPost.TabIndex = 0;
            btnPost.Text = "Save";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // btnPut
            // 
            btnPut.Location = new Point(208, 35);
            btnPut.Name = "btnPut";
            btnPut.Size = new Size(157, 29);
            btnPut.TabIndex = 1;
            btnPut.Text = "Edit";
            btnPut.UseVisualStyleBackColor = true;
            btnPut.Click += btnPut_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(397, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(582, 35);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(146, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(805, 35);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(22, 99);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(23, 146);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 20);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(111, 96);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(668, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(111, 146);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(668, 27);
            txtLastName.TabIndex = 8;
            // 
            // dgvPerson
            // 
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Location = new Point(47, 217);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.RowHeadersWidth = 51;
            dgvPerson.Size = new Size(852, 269);
            dgvPerson.TabIndex = 9;
            dgvPerson.CellDoubleClick += dgvPerson_CellDoubleClick;
            dgvPerson.MouseClick += dgvPerson_MouseClick;
            // 
            // PersonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 528);
            Controls.Add(dgvPerson);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnPut);
            Controls.Add(btnPost);
            Name = "PersonForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PersonForm";
            Load += PersonForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPost;
        private Button btnPut;
        private Button btnDelete;
        private Button btnRefresh;
        private Button button5;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DataGridView dgvPerson;
        private Button btnBack;
    }
}
