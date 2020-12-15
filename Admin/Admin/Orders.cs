using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Admin.Model;
namespace Admin
{
    public partial class Orders : Form
    {
        public string baseAddress = Function.GetUri();
        DataTable data = new DataTable();
        string id_temp = "";
        public Orders()
        {
            InitializeComponent();
            load();
            loadComboBox();
            
        }
        #region Load
        private void loadComboBox()
        {
            IEnumerable<TRANGTHAIDONHANG> model = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44373/api/");
                var responseTask = client.GetAsync("TTDH/getlistTTDH");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IEnumerable<TRANGTHAIDONHANG>>();
                    readTask.Wait();

                    model = readTask.Result;
                }
                else
                {
                    model = Enumerable.Empty<TRANGTHAIDONHANG>();
                }
            }

            DataTable table = new DataTable();
            //table = Function.GetDataTable("danhmuc/getData");
            table = Function.CreateDataTable(model);
            // gridView.DataSource = model;
            Function.pushComboBox(table, trangthai, "MaTT", "TenTT");
        }
        private void load()
        {                 
            gridView.Columns[2].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            loadGridview();
        }
        private void loadComboBox(string request,ComboBox x,string inn,string outt)
        {
            DataTable table = new DataTable();
            table = Function.GetDataTable(request);
            Function.pushComboBox(table, x, inn, outt);           
        }
        private void loadGridview()
        {
            IEnumerable<VIEWDONHANG> model = Function.GetIEnumerable<VIEWDONHANG>("donhang/getlistviewdonhang");
            data = new DataTable();
            data = Function.ToDataTable<VIEWDONHANG>(model);
            if (Function.HasRow(data))
            {
              gridView.DataSource = Function.GetDataTable("donhang/getView");
            //    gridView.DataSource = data;
            }
          
        }
        #endregion
        #region hiệu ứng
        private void clear()
        {
           
            khachhang.Text = "";
            tongtien.Clear();
            ngaylap.Value = new System.DateTime(2020, 12, 12, 0, 0, 0, 0);
            ghichu.Clear();
            email.Clear();
            diachi.Clear();
            sdt.Clear();
          // trangthai.Text = "";         
            while (gridView2.Rows.Count > 0)
            {
                gridView2.Rows.RemoveAt(0);
            }
        }
        private void AddForm()
        {

            clear();
          
            but_back.Visible = false;
            pan_edit.Visible = false;
        }
        private void EditForm()
        {

            clear();
           
            but_back.Visible = true;
            pan_edit.Visible = true;
        }
        #endregion
        #region CRUD 
        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)//not header           
            {
                EditForm();
               
                      id_temp = gridView.CurrentRow.Cells[0].Value.ToString();
                tongtien.Text = gridView.CurrentRow.Cells[3].Value.ToString();
                khachhang.Text = gridView.CurrentRow.Cells[1].Value.ToString();
                ngaylap.Value = Convert.ToDateTime(gridView.CurrentRow.Cells[2].Value.ToString());

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if (data.Rows[i]["MaDH"].ToString() == id_temp)
                    {

                       diachi.Text = data.Rows[i]["DiaChi"].ToString();                       
                        ghichu.Text= data.Rows[i]["GhiChu"].ToString();                       
                        email.Text= data.Rows[i]["Email"].ToString();
                        sdt.Text= data.Rows[i]["SDT"].ToString();                      
                        trangthai.SelectedValue = data.Rows[i]["MaTT"];    
                        
                        break;
                    }
                }
                gridView2.DataSource = Function.GetDataTableWithValue("chitietdonhang/getView",id_temp);
               // System.Windows.MessageBox.Show(trangthai.SelectedValue.ToString());


            }
        }
       
        private void sua(object sender, EventArgs e)
        {
            if (condition())
            {
                DONHANG c = new DONHANG();
                c.MaDH = Convert.ToInt32(id_temp);
                c.HoTen = khachhang.Text;
                c.Email = email.Text;
                //c.GhiChu = ghichu.Text;
                c.Diachi = diachi.Text;
                //c.SDT = sdt.Text;
                c.TongTien =Convert.ToInt32(tongtien.Text);               
                c.TrangThai = Convert.ToInt32(trangthai.SelectedValue.ToString());
                Function.Edit("donhang/updatedonhang", c);

                AddForm();
                loadGridview();
            }
        }
        private void xoa(object sender, EventArgs e)
        {
            Function.Delete("donhang/deldonhang", id_temp);
            AddForm();
            loadGridview();
        }
        private void but_back_Click(object sender, EventArgs e)
        {
            AddForm();
        }
        #endregion
        #region search
        private void search_but_Click(object sender, EventArgs e)
        {
            if (search_box.Visible == true)
            {
                search_box.Visible = false;
            }
            else
            {
                search_box.Visible = true;
            }
        }
        private void search_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_box.Visible = false;
            }
        }
        #endregion
        #region gridview2
        private void gridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!but_back.Visible)
            {
                if (e.RowIndex != -1)//not header           
                {

                    gridView2.Rows.RemoveAt(gridView2.CurrentCell.RowIndex);

                }
            }
            else
            {
                    
            }
            //if (!isFormRegister)
            //{
            //    c4 = gridView2.CurrentRow.Cells[0].Value.ToString();
            //    c1 = gridView2.CurrentRow.Cells[1].Value.ToString();
            //    c2 = gridView2.CurrentRow.Cells[2].Value.ToString();
            //    c3 = gridView2.CurrentRow.Cells[3].Value.ToString();

            //    ChiTietPhieuNhap sua_item = new ChiTietPhieuNhap(label_id.Text, c4, c1, c2, c3);
            //    sua_item.ShowDialog();
            //    funcShare.loadGridView("chi_tiet_phieu_nhap", "mat_hang_id,so_luong,don_gia,don_vi",
            //      gridView2, funcShare.where("phieu_nhap_id", label_id.Text));
            //}

        }
        private void but_add_2_Click(object sender, EventArgs e)
        {
            if (condition1())
            {

            }
        }
        #endregion
        #region Điều kiện
        private bool condition()
        {
            //
            return true;
        }
        private bool condition1()
        {
            //
            return true;
        }













        #endregion

       
    }
}
