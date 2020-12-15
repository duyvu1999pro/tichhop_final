using Admin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Product : Form
    {
        public string baseAddress = Function.GetUri();    
        public static DataTable data = new DataTable();
        string id_temp = "";
        public static int mode;
        public Product()
        {
            InitializeComponent();
           // loadComboBox();
            loadGridview();
            gridView.AutoGenerateColumns = false;
        }
        #region Load
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
            gridView.DataSource = model;
            //Function.pushComboBox(table, kind, "MaDM", "TenDM");          
        }
        private void loadGridview()
        {
            IEnumerable<SANPHAM> model = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44373/api/");
                var responseTask = client.GetAsync("product/getlistthuoc");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IEnumerable<SANPHAM>>();
                    readTask.Wait();

                    model = readTask.Result;
                }
                else //web api sent error response 
                {
                    model = Enumerable.Empty<SANPHAM>();
                }
            }
            data = new DataTable();
            data = Function.ToDataTable<SANPHAM>(model);
            //data = Function.GetDataTableWithValue("product/getProductCategoryExceptID", kind.SelectedValue.ToString());
            if (Function.HasRow(data))
            {

             gridView.DataSource = data;

                //gridView.DataSource = Function.GetDataTableWithValue("product/getView", kind.SelectedValue.ToString());
            }
            else
            {
                for (int i = gridView.Rows.Count - 1; i >= 0; i--)
                {
                    gridView.Rows.RemoveAt(i);

                }
            }




        }
        #endregion
        #region hiệu ứng
                
        //private void clear()
        //{
        //    tenthuoc.Clear();
        //    thanhphan.Clear();
        //    lieuluong.Clear();
        //    congdung.Clear();
        //    dangthuoc.Clear();
        //    dongia.Clear();
        //    donvi.Clear();
        //    urlanh.Clear();
        //    mota.Clear();
           
        //}
        //private void AddForm()
        //{

        //    clear();
        //    but_add.Visible = true;
        //    but_back.Visible = false;
        //    pan_edit.Visible = false;
        //}
        //private void EditForm()
        //{

        //    clear();
        //    but_add.Visible = false;
        //    but_back.Visible = true;
        //    pan_edit.Visible = true;
        //}

        #endregion
        #region CRUD
        public static int iTemp;
        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex != -1)//not header           
            {
                mode = 1;
                CTProduct f = new CTProduct();                           
                id_temp = this.gridView.CurrentRow.Cells[0].Value.ToString();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if (data.Rows[i]["MaSP"].ToString() == id_temp)
                    {
                        iTemp = i;
                    }
                }
                f.ShowDialog();
                loadGridview();

            }

        }
        private void them(object sender, EventArgs e)
        {
            mode = 0;
            CTProduct f = new CTProduct();
            f.ShowDialog();        
            loadGridview();
        }          
        #endregion
        #region search
        private void search_but_Click(object sender, EventArgs e)
        {

        }
      
        #endregion
        #region kind
        //private void open_kind(object sender, EventArgs e)
        //{
        //    if (kind_add.Text == "+")
        //    {
        //        kind_add.Text = "-";
        //        text_add.Visible = true;
        //    }
        //    else
        //    {

        //        kind_add.Text = "+";
        //        text_add.Visible = false;
        //    }
        //}
        //private void kind_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    loadGridview();
        //    AddForm();        
        //    if (!Function.HasRow(data))                              
        //    {
        //        kind_del.Visible = true;
        //    }
        //    else
        //    {
        //        kind_del.Visible = false;
        //    }

            

        //}

        //private void del_kind(object sender, EventArgs e)
        //{          
        //    Function.Delete("danhmuc/deldanhmuc", kind.SelectedValue.ToString());            
        //    loadComboBox();

        //}
        //private void add_kind(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter && text_add.Text != "")
        //    {              
        //        DANHMUC dm = new DANHMUC();
        //        dm.TenDM = text_add.Text;
        //        Function.Add("danhmuc/adddanhmuc", dm);
        //        text_add.Clear();
        //        text_add.Visible = false;
        //        kind_add.Text = "+";               
        //        loadComboBox();
               
        //    }
        //}
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
