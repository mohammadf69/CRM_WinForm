namespace CRM.WinForms.Forms.Customers
{
    partial class CustomerEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEditForm));
            groupBox1 = new GroupBox();
            txtAddress = new RichTextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbCompany = new ComboBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtMobile = new TextBox();
            txtNationalCode = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbCompany);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtMobile);
            groupBox1.Controls.Add(txtNationalCode);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Location = new Point(-4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ایجاد  مشتری";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(16, 149);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(179, 120);
            txtAddress.TabIndex = 4;
            txtAddress.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(456, 290);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(95, 22);
            label9.TabIndex = 3;
            label9.Text = "نام شرکت:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(201, 151);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(57, 22);
            label8.TabIndex = 3;
            label8.Text = "آدرس:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(201, 99);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(61, 22);
            label7.TabIndex = 3;
            label7.Text = "ایمیل :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(201, 47);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(88, 22);
            label6.TabIndex = 3;
            label6.Text = "تلفن ثابت:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(438, 159);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(74, 22);
            label5.TabIndex = 2;
            label5.Text = "کد ملی:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(438, 94);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(112, 22);
            label4.TabIndex = 2;
            label4.Text = "نام خانوادگی:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(438, 225);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(61, 22);
            label3.TabIndex = 2;
            label3.Text = "موبایل:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(438, 160);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(43, 22);
            label2.TabIndex = 2;
            label2.Text = "نام :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 51);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(43, 22);
            label1.TabIndex = 2;
            label1.Text = "نام :";
            // 
            // cmbCompany
            // 
            cmbCompany.FormattingEnabled = true;
            cmbCompany.Location = new Point(243, 284);
            cmbCompany.Name = "cmbCompany";
            cmbCompany.Size = new Size(189, 28);
            cmbCompany.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(38, 94);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(157, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(38, 46);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(157, 27);
            txtPhone.TabIndex = 0;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(307, 224);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(125, 27);
            txtMobile.TabIndex = 0;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(307, 159);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(125, 27);
            txtNationalCode.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(307, 94);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(307, 46);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(34, 441);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "انصراف";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(452, 441);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(77, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "ذخیره";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // CustomerEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 482);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(groupBox1);
            Name = "CustomerEditForm";
            Text = "ایجاد مشتری";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbCompany;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtMobile;
        private TextBox txtNationalCode;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnCancel;
        private Button btnSave;
        private RichTextBox txtAddress;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}