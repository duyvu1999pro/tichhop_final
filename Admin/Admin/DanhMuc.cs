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
    public partial class DanhMuc : Form
    {
      
        public static DataTable data = new DataTable();
        string id_temp = "";
        public DanhMuc()
        {
            InitializeComponent();
            loadGridview();
        }
        #region  load
        private void loadGridview()
        {
            IEnumerable<DANHMUC> model = Function.GetIEnumerable<DANHMUC>("danhmuc/getlistdanhmuc");
            data = new DataTable();
            data = Function.ToDataTable<DANHMUC>(model);         
            if (Function.HasRow(data))
            {
                gridView.DataSource = Function.GetDataTable("danhmuc/getView");               
            }
         
        }
        #endregion
        #region changeForm
        private void clear()
        {
            ten.Clear();
            ghichu.Clear();           
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
                    if (data.Rows[i]["MaDM"].ToString() == id_temp)
                    {

                        
                        ghichu.Text = data.Rows[i]["GhiChu"].ToString();

                        break;
                    }
                }

            }
        }
        private void them(object sender, EventArgs e)
        {
            if (condition())
            {
                DANHMUC dm = new DANHMUC();
                dm.TenDM = ten.Text;
                dm.GhiChu = ghichu.Text;
             Function.Add("danhmuc/adddanhmuc", dm);                                 
                clear();
                loadGridview();
            }

        }
        private void sua(object sender, EventArgs e)
        {
            if (condition())
            {
                DANHMUC dm = new DANHMUC();
               dm.MaDM = Convert.ToInt32(id_temp);
                dm.TenDM = ten.Text;
                dm.GhiChu = ghichu.Text;
                Function.Edit("danhmuc/updatedanhmuc", dm);
                AddForm();
                loadGridview();
            }
        }
        private void xoa(object sender, EventArgs e)
        {
          
            Function.Delete("danhmuc/deldanhmuc", id_temp);
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
