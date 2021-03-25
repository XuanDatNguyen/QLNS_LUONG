using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient

namespace QUANLYLUONG
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        Ketnoi ketnoi = new Ketnoi();  //Khởi tạo class Kết Nối

        public void LOADBANG_NHANVIEN()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * FROM NHANVIEN");
            DataGrid_TTNV.DataSource = dta;
            Hienthi_BANGNV();
        }

        private void Hienthi_BANGNV()
        {
            txtMANV.DataBindings.Clear();
            txtMANV.DataBindings.Add("Text", DataGrid_TTNV.DataSource, "ma_NV");

            txtHOTEN.DataBindings.Clear();
            txtHOTEN.DataBindings.Add("Text", DataGrid_TTNV.DataSource, "ten_NV");

            txtHESOLUONG.DataBindings.Clear();
            txtHESOLUONG.DataBindings.Add("Text", DataGrid_TTNV.DataSource, "he_so_luong");

            txtHESOLUONG.DataBindings.Clear();
            txtHESOLUONG.DataBindings.Add("Text", DataGrid_TTNV.DataSource, "ma_CV");

            txtSODT.DataBindings.Clear();
            txtSODT.DataBindings.Add("Text", DataGrid_TTNV.DataSource, "ma_PB");
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LOADBANG_NHANVIEN();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
            ketnoi.Execute("Delete NHANVIEN Where ma_NV = '" + txtMANV.Text + "'");
            LOADBANG_NHANVIEN();
           
        }
    }
}
