namespace BackEnd_Final_Project.Forms
{
    partial class DashBoardForm
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
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.DgvSearchResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GrpSearch = new System.Windows.Forms.GroupBox();
            this.Name = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.PnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchResult)).BeginInit();
            this.GrpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSearch
            // 
            this.PnlSearch.Controls.Add(this.DgvSearchResult);
            this.PnlSearch.Controls.Add(this.GrpSearch);
            this.PnlSearch.Location = new System.Drawing.Point(12, 12);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(609, 354);
            this.PnlSearch.TabIndex = 0;
            // 
            // DgvSearchResult
            // 
            this.DgvSearchResult.AllowUserToAddRows = false;
            this.DgvSearchResult.AllowUserToDeleteRows = false;
            this.DgvSearchResult.AllowUserToOrderColumns = true;
            this.DgvSearchResult.AllowUserToResizeColumns = false;
            this.DgvSearchResult.AllowUserToResizeRows = false;
            this.DgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvSearchResult.Location = new System.Drawing.Point(9, 100);
            this.DgvSearchResult.Name = "DgvSearchResult";
            this.DgvSearchResult.Size = new System.Drawing.Size(570, 242);
            this.DgvSearchResult.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "İd";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefon";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ətraflı";
            this.Column5.Name = "Column5";
            // 
            // GrpSearch
            // 
            this.GrpSearch.Controls.Add(this.Name);
            this.GrpSearch.Controls.Add(this.BtnSearch);
            this.GrpSearch.Controls.Add(this.textBox1);
            this.GrpSearch.Controls.Add(this.textBox3);
            this.GrpSearch.Controls.Add(this.textBox2);
            this.GrpSearch.Controls.Add(this.Phone);
            this.GrpSearch.Controls.Add(this.Surname);
            this.GrpSearch.Location = new System.Drawing.Point(3, 3);
            this.GrpSearch.Name = "GrpSearch";
            this.GrpSearch.Size = new System.Drawing.Size(576, 91);
            this.GrpSearch.TabIndex = 0;
            this.GrpSearch.TabStop = false;
            this.GrpSearch.Text = "Müştəri Axtarışı";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(31, 27);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(20, 13);
            this.Name.TabIndex = 8;
            this.Name.Text = "Ad";
            // 
            // BtnSearch
            // 
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSearch.Location = new System.Drawing.Point(455, 27);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(99, 38);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.Text = "Axtar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(301, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(101, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(311, 27);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(43, 13);
            this.Phone.TabIndex = 2;
            this.Phone.Text = "Telefon";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(166, 27);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(37, 13);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Soyad";
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 366);
            this.Controls.Add(this.PnlSearch);
          
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchResult)).EndInit();
            this.GrpSearch.ResumeLayout(false);
            this.GrpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.DataGridView DgvSearchResult;
        private System.Windows.Forms.GroupBox GrpSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Surname;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Label Name;
    }
}