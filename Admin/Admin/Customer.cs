using Admin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Customer : Form
    {
        public string baseAddress = Function.GetUri();       
        DataTable data = new DataTable();
        string id_temp = "";
        public Customer()
        {
            InitializeComponent();
            loadGridview();    
        }
        #region Load
       
        private void loadGridview()
        {
            IEnumerable<KHACHHANG> model = null;
            using(HttpClient client =new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44373/api/");
                var responseTask = client.GetAsync("khachhang/getlistkhachhang");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<KHACHHANG>>();
                    readTask.Wait();

                    model = readTask.Result;
                }
                else //web api sent error response 
                {
                    model = Enumerable.Empty<KHACHHANG>();
                }
            }
            model.ToList();
            data = new DataTable();          
            data = Function.ToDataTable<KHACHHANG>(model);
            if (Function.HasRow(data))
            {              
                gridView.DataSource = Function.GetDataTable("khachhang/getView");              
            }
        }
        #endregion
        #region changeForm
        private void clear()
        {
            ten.Clear();
            sdt.Clear();
          
            email.Clear();
            diachi.Clear();           
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
                ten.Text = this.gridView.CurrentRow.Cells[1].Value.ToString();
                id_temp = this.gridView.CurrentRow.Cells[0].Value.ToString();

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if (data.Rows[i]["MaKH"].ToString() == id_temp)
                    {

                        sdt.Text = data.Rows[i]["SDT"].ToString();                       
                        email.Text = data.Rows[i]["Email"].ToString();
                        diachi.Text = data.Rows[i]["Diachi"].ToString();
                     
                        break;
                    }
                }

            }
        }
        private void them(object sender, EventArgs e)
        {           
            if(condition())
            {    
            KHACHHANG kh = new KHACHHANG();
            kh.SDT = sdt.Text;
            kh.HoTen = ten.Text;
            kh.Email = email.Text;            
            kh.Diachi = diachi.Text;
                Function.Add("khachhang/addkhachhang", kh);                
            clear();
            loadGridview();
             }

        }
        private void sua(object sender, EventArgs e)
        {
             if (condition())
             {            
                KHACHHANG kh = new KHACHHANG();
                kh.MaKH = Convert.ToInt32(id_temp);
                kh.SDT = sdt.Text;
                kh.HoTen = ten.Text;
                kh.Email = email.Text;               
                kh.Diachi = diachi.Text;
                Function.Edit("khachhang/updateKhachHang", kh);               
                AddForm();
                loadGridview();
              }
        }
        private void xoa(object sender, EventArgs e)
        {           
            Function.Delete("khachhang/delKhachHang", id_temp);         
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
        #region Điều kiện
        private bool condition()
        {
            //
            return true;
        }
        #endregion

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
