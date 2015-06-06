using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace QuanLyTiemCamDo
{
    class ConnectionSQL
    {
        //public string strcon = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QuanLyCamDo.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        //public string strcon = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyCamDo;Integrated Security=True";
        
        private SqlConnection con;
        private string strcon;
        public ConnectionSQL()
        {
            string path = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + @"\QuanLyCamDo.mdf;Integrated Security=True;";
            con = new SqlConnection();
            con.ConnectionString = strcon;
        }
        public void Opencon()
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }
        }
        public void Closecon()
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
        }
        public DataTable getDataTableSQL(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                Opencon();
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                ad.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi thuc hien getdatatablesql");
            }
            finally
            {
                Closecon();
            }

            return dt;
        }
        
        public int executesql(string sql)
        {
            int kq = 0;
            try
            {
                Opencon();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                kq = 1;
                MessageBox.Show("Loi executesql " + kq);
            }
            finally
            {
                Closecon();
            }
            return kq;
        }
        /*
        public static void ExprorttoExcel(DataGridView dgv)
        {
            SaveFileDialog savefd = new SaveFileDialog();
            savefd.Filter = "FileExcel| *.xlsx";
            if (savefd.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application excelexport = new Microsoft.Office.Interop.Excel.Application();
                excelexport.Application.Workbooks.Add(Type.Missing);
                excelexport.Columns.ColumnWidth = 20;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    excelexport.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        excelexport.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                excelexport.ActiveWorkbook.SaveCopyAs(savefd.FileName);
                excelexport.ActiveWorkbook.Saved = true;
                excelexport.Quit();
                MessageBox.Show("du lieu da duoc xuat ra excel");
            }
        }
         */
    }
    class ket_noi
    {
        static string path = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;

        public static string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + @"\QuanLyCamDo.mdf;Integrated Security=True;";
    }
}
