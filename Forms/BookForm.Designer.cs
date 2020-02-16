namespace BackEnd_Final_Project.Forms
{
    partial class BookForm
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.LblSalePprice = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.DgvBook = new System.Windows.Forms.DataGridView();
            this.BbtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.CmboxAuthor = new System.Windows.Forms.ComboBox();
            this.LblRentPrice = new System.Windows.Forms.Label();
            this.nTextSale = new System.Windows.Forms.NumericUpDown();
            this.nTextRent = new System.Windows.Forms.NumericUpDown();
            this.RdBtnActive = new System.Windows.Forms.RadioButton();
            this.RdBtnDisabled = new System.Windows.Forms.RadioButton();
            this.LblCount = new System.Windows.Forms.Label();
            this.nTextCount = new System.Windows.Forms.NumericUpDown();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTextSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTextRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTextCount)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(27, 95);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Location = new System.Drawing.Point(24, 136);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(38, 13);
            this.LblAuthor.TabIndex = 1;
            this.LblAuthor.Text = "Author";
            // 
            // LblSalePprice
            // 
            this.LblSalePprice.AutoSize = true;
            this.LblSalePprice.Location = new System.Drawing.Point(24, 178);
            this.LblSalePprice.Name = "LblSalePprice";
            this.LblSalePprice.Size = new System.Drawing.Size(52, 13);
            this.LblSalePprice.TabIndex = 2;
            this.LblSalePprice.Text = "SalePrice";
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.Cyan;
            this.TxtName.Location = new System.Drawing.Point(132, 88);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(121, 20);
            this.TxtName.TabIndex = 3;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(29, 309);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(37, 13);
            this.LblStatus.TabIndex = 4;
            this.LblStatus.Text = "Status";
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.LightGreen;
            this.BtnCreate.Location = new System.Drawing.Point(12, 364);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(107, 44);
            this.BtnCreate.TabIndex = 7;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.LightGreen;
            this.BtnReset.Location = new System.Drawing.Point(152, 364);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(101, 44);
            this.BtnReset.TabIndex = 8;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // DgvBook
            // 
            this.DgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvBook.Location = new System.Drawing.Point(313, 116);
            this.DgvBook.Name = "DgvBook";
            this.DgvBook.Size = new System.Drawing.Size(547, 281);
            this.DgvBook.TabIndex = 9;
            // 
            // BbtnUpdate
            // 
            this.BbtnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.BbtnUpdate.Location = new System.Drawing.Point(569, 55);
            this.BbtnUpdate.Name = "BbtnUpdate";
            this.BbtnUpdate.Size = new System.Drawing.Size(106, 40);
            this.BbtnUpdate.TabIndex = 10;
            this.BbtnUpdate.Text = "Update";
            this.BbtnUpdate.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(698, 55);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(112, 40);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // CmboxAuthor
            // 
            this.CmboxAuthor.FormattingEnabled = true;
            this.CmboxAuthor.Location = new System.Drawing.Point(132, 128);
            this.CmboxAuthor.Name = "CmboxAuthor";
            this.CmboxAuthor.Size = new System.Drawing.Size(121, 21);
            this.CmboxAuthor.TabIndex = 12;
            // 
            // LblRentPrice
            // 
            this.LblRentPrice.AutoSize = true;
            this.LblRentPrice.Location = new System.Drawing.Point(24, 226);
            this.LblRentPrice.Name = "LblRentPrice";
            this.LblRentPrice.Size = new System.Drawing.Size(54, 13);
            this.LblRentPrice.TabIndex = 15;
            this.LblRentPrice.Text = "RentPrice";
            // 
            // nTextSale
            // 
            this.nTextSale.Location = new System.Drawing.Point(130, 171);
            this.nTextSale.Name = "nTextSale";
            this.nTextSale.Size = new System.Drawing.Size(120, 20);
            this.nTextSale.TabIndex = 17;
            // 
            // nTextRent
            // 
            this.nTextRent.Location = new System.Drawing.Point(130, 219);
            this.nTextRent.Name = "nTextRent";
            this.nTextRent.Size = new System.Drawing.Size(120, 20);
            this.nTextRent.TabIndex = 18;
            // 
            // RdBtnActive
            // 
            this.RdBtnActive.AutoSize = true;
            this.RdBtnActive.Location = new System.Drawing.Point(95, 307);
            this.RdBtnActive.Name = "RdBtnActive";
            this.RdBtnActive.Size = new System.Drawing.Size(55, 17);
            this.RdBtnActive.TabIndex = 19;
            this.RdBtnActive.TabStop = true;
            this.RdBtnActive.Text = "Active";
            this.RdBtnActive.UseVisualStyleBackColor = true;
            // 
            // RdBtnDisabled
            // 
            this.RdBtnDisabled.AutoSize = true;
            this.RdBtnDisabled.Location = new System.Drawing.Point(184, 309);
            this.RdBtnDisabled.Name = "RdBtnDisabled";
            this.RdBtnDisabled.Size = new System.Drawing.Size(66, 17);
            this.RdBtnDisabled.TabIndex = 20;
            this.RdBtnDisabled.TabStop = true;
            this.RdBtnDisabled.Text = "Disabled";
            this.RdBtnDisabled.UseVisualStyleBackColor = true;
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(29, 267);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(35, 13);
            this.LblCount.TabIndex = 21;
            this.LblCount.Text = "Count";
            // 
            // nTextCount
            // 
            this.nTextCount.Location = new System.Drawing.Point(132, 260);
            this.nTextCount.Name = "nTextCount";
            this.nTextCount.Size = new System.Drawing.Size(118, 20);
            this.nTextCount.TabIndex = 22;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Author";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SalePrice";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "RentPrice";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Count";
            this.Column6.Name = "Column6";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(872, 430);
            this.Controls.Add(this.nTextCount);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.RdBtnDisabled);
            this.Controls.Add(this.RdBtnActive);
            this.Controls.Add(this.nTextRent);
            this.Controls.Add(this.nTextSale);
            this.Controls.Add(this.LblRentPrice);
            this.Controls.Add(this.CmboxAuthor);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BbtnUpdate);
            this.Controls.Add(this.DgvBook);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblSalePprice);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.LblName);
            this.Name = "BookForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTextSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTextRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTextCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Label LblSalePprice;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.DataGridView DgvBook;
        private System.Windows.Forms.Button BbtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ComboBox CmboxAuthor;
        private System.Windows.Forms.Label LblRentPrice;
        private System.Windows.Forms.NumericUpDown nTextSale;
        private System.Windows.Forms.NumericUpDown nTextRent;
        private System.Windows.Forms.RadioButton RdBtnActive;
        private System.Windows.Forms.RadioButton RdBtnDisabled;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.NumericUpDown nTextCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}