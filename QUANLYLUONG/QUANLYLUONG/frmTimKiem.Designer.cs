
namespace QUANLYLUONG
{
    partial class frmTimKiem
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
            this.cboMa = new System.Windows.Forms.ComboBox();
            this.optNhapTen = new System.Windows.Forms.RadioButton();
            this.optNhapMa1 = new System.Windows.Forms.RadioButton();
            this.optNhapMa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.Grid_KETQUA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_KETQUA)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMa
            // 
            this.cboMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMa.FormattingEnabled = true;
            this.cboMa.Location = new System.Drawing.Point(272, 246);
            this.cboMa.Name = "cboMa";
            this.cboMa.Size = new System.Drawing.Size(366, 28);
            this.cboMa.TabIndex = 102;
            // 
            // optNhapTen
            // 
            this.optNhapTen.AutoSize = true;
            this.optNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNhapTen.Location = new System.Drawing.Point(94, 193);
            this.optNhapTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optNhapTen.Name = "optNhapTen";
            this.optNhapTen.Size = new System.Drawing.Size(119, 28);
            this.optNhapTen.TabIndex = 99;
            this.optNhapTen.Text = "Nhập tên:";
            this.optNhapTen.UseVisualStyleBackColor = true;
            // 
            // optNhapMa1
            // 
            this.optNhapMa1.AutoSize = true;
            this.optNhapMa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNhapMa1.Location = new System.Drawing.Point(98, 244);
            this.optNhapMa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optNhapMa1.Name = "optNhapMa1";
            this.optNhapMa1.Size = new System.Drawing.Size(118, 28);
            this.optNhapMa1.TabIndex = 100;
            this.optNhapMa1.Text = "Nhập mã:";
            this.optNhapMa1.UseVisualStyleBackColor = true;
            // 
            // optNhapMa
            // 
            this.optNhapMa.AutoSize = true;
            this.optNhapMa.Checked = true;
            this.optNhapMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNhapMa.Location = new System.Drawing.Point(96, 143);
            this.optNhapMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optNhapMa.Name = "optNhapMa";
            this.optNhapMa.Size = new System.Drawing.Size(118, 28);
            this.optNhapMa.TabIndex = 101;
            this.optNhapMa.TabStop = true;
            this.optNhapMa.Text = "Nhập mã:";
            this.optNhapMa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 39);
            this.label1.TabIndex = 98;
            this.label1.Text = "TÌM KIẾM THÔNG TIN CHỨC VỤ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(701, 209);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 53);
            this.btnThoat.TabIndex = 97;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(701, 148);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 53);
            this.btnTimKiem.TabIndex = 96;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(272, 196);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(366, 28);
            this.txtTen.TabIndex = 94;
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(272, 146);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(366, 28);
            this.txtMa.TabIndex = 95;
            // 
            // Grid_KETQUA
            // 
            this.Grid_KETQUA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_KETQUA.Location = new System.Drawing.Point(55, 320);
            this.Grid_KETQUA.Margin = new System.Windows.Forms.Padding(4);
            this.Grid_KETQUA.Name = "Grid_KETQUA";
            this.Grid_KETQUA.RowHeadersWidth = 51;
            this.Grid_KETQUA.Size = new System.Drawing.Size(791, 200);
            this.Grid_KETQUA.TabIndex = 93;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 547);
            this.Controls.Add(this.cboMa);
            this.Controls.Add(this.optNhapTen);
            this.Controls.Add(this.optNhapMa1);
            this.Controls.Add(this.optNhapMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.Grid_KETQUA);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_KETQUA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMa;
        private System.Windows.Forms.RadioButton optNhapTen;
        private System.Windows.Forms.RadioButton optNhapMa1;
        private System.Windows.Forms.RadioButton optNhapMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.DataGridView Grid_KETQUA;
    }
}