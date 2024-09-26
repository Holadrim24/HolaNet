namespace Adressboken
{
    partial class Addressbook
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
            btnRegister = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            lblName = new Label();
            label2 = new Label();
            lblPostalNo = new Label();
            lblCity = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            listBoxResults = new ListBox();
            txtPhoneNumber = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtPostalNo = new TextBox();
            txtCity = new TextBox();
            txtSearch = new TextBox();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(120, 461);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(117, 47);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Registrera";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(382, 372);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 48);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Uppdatera";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("MV Boli", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(270, 373);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 48);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Ta Bort";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(506, 373);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(106, 48);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Sök";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("MV Boli", 9F, FontStyle.Bold);
            lblName.Location = new Point(33, 99);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Namn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 9F, FontStyle.Bold);
            label2.Location = new Point(33, 152);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 5;
            label2.Text = "Gatuadress:";
            // 
            // lblPostalNo
            // 
            lblPostalNo.AutoSize = true;
            lblPostalNo.Font = new Font("MV Boli", 9F, FontStyle.Bold);
            lblPostalNo.Location = new Point(33, 205);
            lblPostalNo.Name = "lblPostalNo";
            lblPostalNo.Size = new Size(112, 20);
            lblPostalNo.TabIndex = 6;
            lblPostalNo.Text = "Postnummer:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("MV Boli", 9F, FontStyle.Bold);
            lblCity.Location = new Point(33, 258);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(76, 20);
            lblCity.TabIndex = 7;
            lblCity.Text = "Postort:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("MV Boli", 9F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(33, 320);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(127, 20);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Telefonnummer";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("MV Boli", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(33, 377);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(113, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-postadress:";
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(270, 122);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(543, 244);
            listBoxResults.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(33, 347);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(204, 27);
            txtPhoneNumber.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(33, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 27);
            txtName.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(33, 405);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(33, 175);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(204, 27);
            txtAddress.TabIndex = 14;
            // 
            // txtPostalNo
            // 
            txtPostalNo.Location = new Point(33, 228);
            txtPostalNo.Name = "txtPostalNo";
            txtPostalNo.Size = new Size(204, 27);
            txtPostalNo.TabIndex = 15;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(33, 281);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(204, 27);
            txtCity.TabIndex = 16;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(618, 373);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(195, 47);
            txtSearch.TabIndex = 17;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Cornsilk;
            textBox8.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(-2, -11);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(941, 101);
            textBox8.TabIndex = 18;
            textBox8.Text = "ADRESSBOKEN";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // Addressbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(937, 532);
            Controls.Add(textBox8);
            Controls.Add(txtSearch);
            Controls.Add(txtCity);
            Controls.Add(txtPostalNo);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(listBoxResults);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblCity);
            Controls.Add(lblPostalNo);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegister);
            Name = "Addressbook";
            Text = "Adressboken";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Label lblName;
        private Label label2;
        private Label lblPostalNo;
        private Label lblCity;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private ListBox listBoxResults;
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtPostalNo;
        private TextBox txtCity;
        private TextBox txtSearch;
        private TextBox textBox8;
    }
}
