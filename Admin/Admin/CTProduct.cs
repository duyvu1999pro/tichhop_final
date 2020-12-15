using Admin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class CTProduct : Form
    {
        public CTProduct()
        {
            InitializeComponent();
            loadComboBox();
        }

        private void loadComboBox()
        {
            IEnumerable<DANHMUC> model = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44373/api/");
                var responseTask = client.GetAsync("danhmuc/getlistdanhmuc");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IEnumerable<DANHMUC>>();
                    readTask.Wait();

                    model = readTask.Result;
                }
                else
                {
                    model = Enumerable.Empty<DANHMUC>();
                }
            }

            DataTable table = new DataTable();
            //table = Function.GetDataTable("danhmuc/getData");
            table = Function.CreateDataTable(model);
           // gridView.DataSource = model;
            Function.pushComboBox(table, comboBox1, "MaDM", "TenDM");
        }
        Product p = new Product();
        private void CTProduct_Load(object sender, EventArgs e)
        {
            if (Product.mode == 1)
            {
                but_add.Visible = false;
                pan_edit.Visible = true;

                tenthuoc.Text = Product.data.Rows[Product.iTemp]["TenSP"].ToString();
                thanhphan.Text = Product.data.Rows[Product.iTemp]["ThanhPhan"].ToString();
                congdung.Text = Product.data.Rows[Product.iTemp]["CongDung"].ToString();
                lieuluong.Text = Product.data.Rows[Product.iTemp]["LieuLuong"].ToString();
                donvi.Text = Product.data.Rows[Product.iTemp]["DonVi"].ToString();
                dangthuoc.Text = Product.data.Rows[Product.iTemp]["DangThuoc"].ToString();
                urlanh.Text = Product.data.Rows[Product.iTemp]["HinhAnh"].ToString();
                mota.Text = Product.data.Rows[Product.iTemp]["MoTa"].ToString();
                dongia.Text = Product.data.Rows[Product.iTemp]["GiaBan"].ToString();
                string temp = Product.data.Rows[Product.iTemp]["MaDM"].ToString();
                comboBox1.SelectedValue = temp;
            }
            else
            {
                but_add.Visible = true;
                pan_edit.Visible = false;
                comboBox1.SelectedValue = 1;
            }
        }
        #region CRUD
        private void but_add_Click(object sender, EventArgs e)
        {
            if (condition())
            {

                SANPHAM sp = new SANPHAM();
                sp.MaDM = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                sp.TenSP = tenthuoc.Text;
                sp.ThanhPhan = thanhphan.Text;
                sp.CongDung = congdung.Text;
                sp.LieuLuong = lieuluong.Text;
                sp.DonVi = donvi.Text;
                sp.DangThuoc = dangthuoc.Text;
                sp.HinhAnh = urlanh.Text;
                sp.MoTa = mota.Text;
                sp.GiaBan = Convert.ToInt32(dongia.Text);
                Function.Add("product/addthuoc", sp);
                MessageBox.Show("thêm thành công");
                this.Close();
            }
        }

        private bool condition()
        {
            return true;
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            if (condition())
            {

                SANPHAM sp = new SANPHAM();
                sp.MaSP = Product.data.Rows[Product.iTemp]["MaSP"].ToString();
                sp.MaDM = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                sp.TenSP = tenthuoc.Text;
                sp.ThanhPhan = thanhphan.Text;
                sp.CongDung = congdung.Text;
                sp.LieuLuong = lieuluong.Text;
                sp.DonVi = donvi.Text;
                sp.DangThuoc = dangthuoc.Text;
                sp.HinhAnh = urlanh.Text;
                sp.MoTa = mota.Text;
                sp.GiaBan = Convert.ToInt32(dongia.Text);
                Function.Edit("product/updatethuoc", sp);
                MessageBox.Show("Update thành công");
                this.Close();
            }
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            Function.Delete("product/delthuoc", Product.data.Rows[Product.iTemp]["MaSP"].ToString());
            MessageBox.Show("Xóa thành công");
            this.Close();
        }
        #endregion
    }
}
