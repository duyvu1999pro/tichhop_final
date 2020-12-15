using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
        #region  load
        private void loadGridview()
        {
            IEnumerable<TAIKHOANQUANTRI> model = Function.GetIEnumerable<TAIKHOANQUANTRI>("quantri/getlistTKQT");
            data = new DataTable();
            data = Function.ToDataTable<TAIKHOANQUANTRI>(model);
            if (Function.HasRow(data))
            {
                gridView.DataSource = model;
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
                ten.Text = this.gridView.CurrentRow.Cells[1].Value.ToString();
                id_temp = this.gridView.CurrentRow.Cells[0].Value.ToString();

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if (data.Rows[i]["MaQT"].ToString() == id_temp)
                    {
                       sdt.Text = data.Rows[i]["SDT"].ToString();
                        matkhau.Text= data.Rows[i]["MatKhau"].ToString();

                        break;
                    }
                }

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
