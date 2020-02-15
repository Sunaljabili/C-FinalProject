namespace BackEnd_Final_Project.Forms
{
    partial class CustomerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.FullNameTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.ActiveRdBtn = new System.Windows.Forms.RadioButton();
            this.DisabledRdBtn = new System.Windows.Forms.RadioButton();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.DgvCustomer = new System.Windows.Forms.DataGridView();
            this.SearchTxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.imageList5 = new System.Windows.Forms.ImageList(this.components);
            this.imageList6 = new System.Windows.Forms.ImageList(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.AutoSize = true;
            this.FullNameLbl.Location = new System.Drawing.Point(45, 95);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(51, 13);
            this.FullNameLbl.TabIndex = 0;
            this.FullNameLbl.Text = "FullName";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(45, 140);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(38, 13);
            this.PhoneLbl.TabIndex = 1;
            this.PhoneLbl.Text = "Phone";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(45, 184);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(32, 13);
            this.EmailLbl.TabIndex = 2;
            this.EmailLbl.Text = "Email";
            // 
            // FullNameTxt
            // 
            this.FullNameTxt.Location = new System.Drawing.Point(113, 92);
            this.FullNameTxt.Name = "FullNameTxt";
            this.FullNameTxt.Size = new System.Drawing.Size(116, 20);
            this.FullNameTxt.TabIndex = 5;
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(113, 137);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(116, 20);
            this.PhoneTxt.TabIndex = 6;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(113, 181);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(116, 20);
            this.EmailTxt.TabIndex = 7;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(46, 241);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(37, 13);
            this.StatusLbl.TabIndex = 10;
            this.StatusLbl.Text = "Status";
            // 
            // ActiveRdBtn
            // 
            this.ActiveRdBtn.AutoSize = true;
            this.ActiveRdBtn.Location = new System.Drawing.Point(103, 241);
            this.ActiveRdBtn.Name = "ActiveRdBtn";
            this.ActiveRdBtn.Size = new System.Drawing.Size(55, 17);
            this.ActiveRdBtn.TabIndex = 11;
            this.ActiveRdBtn.TabStop = true;
            this.ActiveRdBtn.Text = "Active";
            this.ActiveRdBtn.UseVisualStyleBackColor = true;
            // 
            // DisabledRdBtn
            // 
            this.DisabledRdBtn.AutoSize = true;
            this.DisabledRdBtn.Location = new System.Drawing.Point(164, 241);
            this.DisabledRdBtn.Name = "DisabledRdBtn";
            this.DisabledRdBtn.Size = new System.Drawing.Size(72, 17);
            this.DisabledRdBtn.TabIndex = 12;
            this.DisabledRdBtn.TabStop = true;
            this.DisabledRdBtn.Text = "Diasabled";
            this.DisabledRdBtn.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(48, 275);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 32);
            this.BtnCreate.TabIndex = 13;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(150, 275);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(79, 32);
            this.ResetBtn.TabIndex = 14;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(289, 44);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(82, 33);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(390, 44);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 33);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // DgvCustomer
            // 
            this.DgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvCustomer.Location = new System.Drawing.Point(270, 95);
            this.DgvCustomer.Name = "DgvCustomer";
            this.DgvCustomer.Size = new System.Drawing.Size(445, 236);
            this.DgvCustomer.TabIndex = 17;
            // 
            // SearchTxt
            // 
            this.SearchTxt.AutoSize = true;
            this.SearchTxt.Location = new System.Drawing.Point(510, 58);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(41, 13);
            this.SearchTxt.TabIndex = 18;
            this.SearchTxt.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.DarkGray;
            // 
            // imageList4
            // 
            this.imageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList4.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList5
            // 
            this.imageList5.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList5.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList5.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList6
            // 
            this.imageList6.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList6.ImageStream")));
            this.imageList6.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList6.Images.SetKeyName(0, "Customer.jpg");
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FullName";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 335);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.DgvCustomer);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.DisabledRdBtn);
            this.Controls.Add(this.ActiveRdBtn);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.FullNameTxt);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.FullNameLbl);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullNameLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox FullNameTxt;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.RadioButton ActiveRdBtn;
        private System.Windows.Forms.RadioButton DisabledRdBtn;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView DgvCustomer;
        private System.Windows.Forms.Label SearchTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.ImageList imageList5;
        private System.Windows.Forms.ImageList imageList6;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}