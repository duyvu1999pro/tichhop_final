using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    class Function
    {
        public static string GetUri()
        { return "https://localhost:44373/api/"; }
        #region Datatable
        public static DataTable GetDataTable(string request)
        {
            DataTable temp = new DataTable();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetUri());
                var resp = client.GetAsync(request);
                resp.Wait();
                var rs = resp.Result;
                if (rs.IsSuccessStatusCode)
                {
                    var readTask = rs.Content.ReadAsAsync<DataTable>();
                    readTask.Wait();
                    return readTask.Result;
                }
                return temp;
            }
        }
        public static DataTable GetDataTableWithValue(string request, string value)
        {
            DataTable temp = new DataTable();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetUri());

                var resp = client.GetAsync(request + "/" + value);
                resp.Wait();
                var rs = resp.Result;
                if (rs.IsSuccessStatusCode)
                {
                    var readTask = rs.Content.ReadAsAsync<DataTable>();
                    readTask.Wait();
                    return readTask.Result;
                }
                return temp;
            }
        }
        public static DataTable ToDataTable<T>(IEnumerable data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
        public static DataTable CreateDataTable(IEnumerable source)
        {
            var table = new DataTable();
            int index = 0;
            var properties = new List<PropertyInfo>();
            foreach (var obj in source)
            {
                if (index == 0)
                {
                    foreach (var property in obj.GetType().GetProperties())
                    {
                        if (Nullable.GetUnderlyingType(property.PropertyType) != null)
                        {
                            continue;
                        }
                        properties.Add(property);
                        table.Columns.Add(new DataColumn(property.Name, property.PropertyType));
                    }
                }
                object[] values = new object[properties.Count];
                for (int i = 0; i < properties.Count; i++)
                {
                    values[i] = properties[i].GetValue(obj);
                }
                table.Rows.Add(values);
                index++;
            }
            return table;
        }
        public static IEnumerable<T> GetIEnumerable<T>(string request)
        {
            IEnumerable<T> model = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetUri());
                var responseTask = client.GetAsync(request);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IEnumerable<T>>();
                    readTask.Wait();
                    model = readTask.Result;
                }
                else //web api sent error response 
                {
                    model = Enumerable.Empty<T>();
                }
            }
            return model;
        }
        #endregion
        #region hiệu ứng
        public static void ClearGridView(DataGridView x)
        {
            for (int i = x.Rows.Count - 1; i >= 0; i--)
            {
                x.Rows.RemoveAt(i);
            }
        }
        public static void pushComboBox(DataTable table,ComboBox cbo, string inn, string outt)
        {      
            cbo.ValueMember = inn; //Trường giá trị
            cbo.DisplayMember = outt; //Trường hiển thị
            cbo.DataSource = table;
        }
        #endregion
        #region CRUD
        public static void Add(string request,Object obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetUri());
                var resp = client.PostAsJsonAsync(request, obj);
                resp.Wait();
                var rs = resp.Result;

            }
        }
        public static bool HasRow( DataTable temp)
        {
            if (temp.Rows.Count>0)
            {
                return true;    
            }
            else
            {

                return false;
            }
        }    
        public static void Edit(string request, Object obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetUri());
                var putTask = client.PutAsJsonAsync(request, obj).Result;
            }
        }
        public static void Delete(string request, string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetUri());
                var deleteTask = client.DeleteAsync(request+"/" + id).Result;
            }
        }
        #endregion
      

    }
}
