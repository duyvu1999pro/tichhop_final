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
using Admin.Model;
namespace Admin
{
    public partial class TaiKhoanQuanTri : Form
    {
      
        public static DataTable data = new DataTable();
        string id_temp = "";
        public TaiKhoanQuanTri()
        {
            InitializeComponent();
            loadGridview();
            loadComboBox();
        }
        #region  load
        private void loadComboBox()
        {
            IEnumerable<ROLE> model = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44373/api/");
                var responseTask = client.GetAsync("role/getlistrole");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IEnumerable<ROLE>>();
                    readTask.Wait();

                    model = readTask.Result;
                }
                else
                {
                    model = Enumerable.Empty<ROLE>();
                }
            }

            DataTable table = new DataTable();
            //table = Function.GetDataTable("danhmuc/getData");
            table = Function.CreateDataTable(model);
            // gridView.DataSource = model;
            Function.pushComboBox(table, comboBox1, "IDRole", "RoleName");
        }
        private void loadGridview()
        {
            IEnumerable<TAIKHOANQUANTRI> model = Function.GetIEnumerable<TAIKHOANQUANTRI>("quantri/getlistTKQT");
            data = new DataTable();
            data = Function.ToDataTable<TAIKHOANQUANTRI>(model);
            data.Columns.Add("Quyền", typeof(String));
            foreach(DataRow it in data.Rows)
            {
                if (Convert.ToInt32(it["Role"]) == 1)
                    it["Quyền"] = "Admin";
                else
                    it["Quyền"] = "Member";
            }    
            if (Function.HasRow(data))
            {
                gridView.DataSource = data;
                //gridView.DataSource = Function.GetDataTable("quantri/getView");
            }
            
        }
        #endregion
        #region changeForm
        private void clear()
        {
            ten.Clear();
            sdt.Clear();
            matkhau.Clear();

        }
        private void AddForm()
        {

            clear();
            but_add.Visible = true;
            but_back.Visible = false;
            pan_edit.Visible = false;
        }
        private void EditForm()
        {
            clear();
            but_add.Visible = false;
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
                id_temp= gridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                ten.Text = gridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                sdt.Text = gridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                matkhau.Text= gridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBox1.SelectedValue = gridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                //for (int i = 4; i < 10; i++)
                //    MessageBox.Show(gridView.Rows[e.RowIndex].Cells[i].Value.ToString());
                //ten.Text = this.gridView.CurrentRow.Cells[1].Value.ToString();
                //id_temp = this.gridView.CurrentRow.Cells[0].Value.ToString();

                //for (int i = 0; i < data.Rows.Count; i++)
                //{
                //    if (data.Rows[i]["MaQT"].ToString() == id_temp)
                //    {
                //       sdt.Text = data.Rows[i]["SDT"].ToString();
                //        matkhau.Text= data.Rows[i]["MatKhau"].ToString();
                //        break;
                //    }
                //}

            }
        }
        private void them(object sender, EventArgs e)
        {
            if (condition())
            {
                TAIKHOANQUANTRI tk = new TAIKHOANQUANTRI();
                tk.HoTen = ten.Text;
                tk.MatKhau = matkhau.Text;              
                tk.SDT = sdt.Text;
                tk.Role = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                Function.Add("quantri/addTKQT", tk);
                clear();
                loadGridview();
            }

        }
        private void sua(object sender, EventArgs e)
        {
            if (condition())
            {
                TAIKHOANQUANTRI tk = new TAIKHOANQUANTRI();
                tk.MaQT= Convert.ToInt32(id_temp);
                tk.HoTen = ten.Text;
                tk.MatKhau = matkhau.Text;
                tk.SDT = sdt.Text;
                tk.Role = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                Function.Edit("quantri/updateTKQT", tk);
                AddForm();
                loadGridview();
            }
        }
        private void xoa(object sender, EventArgs e)
        {

            Function.Delete("quantri/delTKQT", id_temp);
            AddForm();
            loadGridview();
        }


        private void but_back_Click(object sender, EventArgs e)
        {
            AddForm();
        }
        #endregion
        #region Điều kiện
        private bool condition()
        {
            //
            return true;
        }
        #endregion
    }
}
