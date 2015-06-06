using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyTiemCamDo
{
    public partial class FormThanhLyHang : Form
    {
        public FormThanhLyHang()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTongTien.Text = "100000000";
            lbTienCamDo.Text = "50000000";
            lbVon.Text = "50000000";
            try
            {
                dateTimePicker1.Value = dateTimePicker2.Value;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ket_noi.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT SoHD,TenKhachHang,TenTS,TongSoTien,DienThoai,LaiSuat,NgayCam,NgayTra FROM HOPDONG,TAISAN,KHACHHANG where HOPDONG.MATS = TAISAN.MATS and HOPDONG.SoCMND = KHACHHANG.SoCMND";
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                DataTable td = new DataTable();
                td.Load(rd);
                for (int i = 0; i < td.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(td.Rows[i][0].ToString());
                    item.SubItems.Add(td.Rows[i][1].ToString());
                    item.SubItems.Add(td.Rows[i][2].ToString());
                    item.SubItems.Add(td.Rows[i][3].ToString());
                    item.SubItems.Add(td.Rows[i][4].ToString());
                    item.SubItems.Add(td.Rows[i][5].ToString());
                    item.SubItems.Add(td.Rows[i][6].ToString());
                    item.SubItems.Add(td.Rows[i][7].ToString());
                  //  item.SubItems.Add(td.Rows[i][8].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();
            }
            catch (Exception)
            {
                txtten.Text = "Ket noi that bai ";
            }
        }

        private void btnthanh_ly_Click(object sender, EventArgs e)
        {
            try
            {
                string SoHD;
                string DienThoai;
                string TenTS;

                int row = this.listView1.SelectedItems[0].Index;
                SoHD = this.listView1.Items[row].SubItems[0].Text;
                TenTS = this.listView1.Items[row].SubItems[2].Text;
                DienThoai = this.listView1.Items[row].SubItems[4].Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = ket_noi.str;
                //con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Quanlycamdo;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                //cmd.CommandText = "DELETE FROM HOPDONG WHERE SoHD ='" + SoHD + "'";
                cmd.CommandText = "DELETE FROM TAISAN WHERE TenTS ='" + TenTS + "'";


                DialogResult result;
                result = MessageBox.Show("Bạn Muốn thanh lý ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    //cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thanh lý Thành Công");
                    this.Close();
                    FormThanhLyHang frm = new FormThanhLyHang();
                    frm.Show();
                }
            }

            catch (Exception)
            {

                MessageBox.Show("vui lòng chọn hợp đồng muốn thanh lý");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {

                MessageBox.Show("Ngày bắt đầu không thể trước ngày kết thúc");
            }
            else if (txtten.Text == "" && txtDocam.Text == "" && dateTimePicker1.Value == dateTimePicker2.Value)
            {
                listView1.Items.Clear();
                dateTimePicker1.Value = dateTimePicker2.Value;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ket_noi.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT SoHD,TenKhachHang,TenTS,TongSoTien,DienThoai,LaiSuat,NgayCam,NgayTra FROM HOPDONG,TAISAN,KHACHHANG where HOPDONG.MATS = TAISAN.MATS and HOPDONG.SoCMND = KHACHHANG.SoCMND";
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                DataTable td = new DataTable();
                td.Load(rd);
                for (int i = 0; i < td.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(td.Rows[i][0].ToString());
                    item.SubItems.Add(td.Rows[i][1].ToString());
                    item.SubItems.Add(td.Rows[i][2].ToString());
                    item.SubItems.Add(td.Rows[i][3].ToString());
                    item.SubItems.Add(td.Rows[i][4].ToString());
                    item.SubItems.Add(td.Rows[i][5].ToString());
                    item.SubItems.Add(td.Rows[i][6].ToString());
                    item.SubItems.Add(td.Rows[i][7].ToString());
                   // item.SubItems.Add(td.Rows[i][8].ToString());

                    listView1.Items.Add(item);
                }
                con.Close();
                MessageBox.Show("vui lòng nhập thông tin tìm kiếm ");
            }
            else if (txtten.Text != "" && txtDocam.Text == "" && dateTimePicker1.Value == dateTimePicker2.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ket_noi.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                //cmd.CommandText = "SELECT * FROM Thanhlyhang where [Ten khach hang] = '" + txtten.Text + "'";
                cmd.CommandText = "SELECT SoHD,TenKhachHang,TenTS,TongSoTien,DienThoai,LaiSuat,NgayCam,NgayTra FROM HOPDONG,TAISAN,KHACHHANG where HOPDONG.MATS = TAISAN.MATS and HOPDONG.SoCMND = KHACHHANG.SoCMND and KHACHHANG.TenKhachHang like '%" + txtten.Text + "%'";
                SqlDataReader rd1;
                rd1 = cmd.ExecuteReader();
                DataTable td = new DataTable();
                td.Load(rd1);
                listView1.Items.Clear();
                for (int i = 0; i < td.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(td.Rows[i][0].ToString());
                    item.SubItems.Add(td.Rows[i][1].ToString());
                    item.SubItems.Add(td.Rows[i][2].ToString());
                    item.SubItems.Add(td.Rows[i][3].ToString());
                    item.SubItems.Add(td.Rows[i][4].ToString());
                    item.SubItems.Add(td.Rows[i][5].ToString());
                    item.SubItems.Add(td.Rows[i][6].ToString());
                    item.SubItems.Add(td.Rows[i][7].ToString());
                    //item.SubItems.Add(td.Rows[i][8].ToString());
                    listView1.Items.Add(item);

                }
                con.Close();
            }
            else if (txtten.Text == "" && txtDocam.Text != "" && dateTimePicker1.Value == dateTimePicker2.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ket_noi.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT SoHD,TenKhachHang,TenTS,TongSoTien,DienThoai,LaiSuat,NgayCam,NgayTra FROM HOPDONG,TAISAN,KHACHHANG where HOPDONG.MATS = TAISAN.MATS and HOPDONG.SoCMND = KHACHHANG.SoCMND and TAISAN.TenTS LIKE '%" + txtDocam.Text + "%'";
                SqlDataReader rd1;
                rd1 = cmd.ExecuteReader();
                DataTable td = new DataTable();
                td.Load(rd1);
                listView1.Items.Clear();
                for (int i = 0; i < td.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(td.Rows[i][0].ToString());
                    item.SubItems.Add(td.Rows[i][1].ToString());
                    item.SubItems.Add(td.Rows[i][2].ToString());
                    item.SubItems.Add(td.Rows[i][3].ToString());
                    item.SubItems.Add(td.Rows[i][4].ToString());
                    item.SubItems.Add(td.Rows[i][5].ToString());
                    item.SubItems.Add(td.Rows[i][6].ToString());
                    item.SubItems.Add(td.Rows[i][7].ToString());
                   // item.SubItems.Add(td.Rows[i][8].ToString());
                    listView1.Items.Add(item);
                }
                con.Close();
            }
            else if (txtten.Text == "" && txtDocam.Text == "" && dateTimePicker1.Value != dateTimePicker2.Value)
            {
                string tungay = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string denngay = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ket_noi.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                // cmd.CommandText =  "SELECT STT,SoHD,TenKhachHang,TenTS,TongSoTien,DienThoai,LaiSuat,NgayCam,NgayTra FROM HOPDONG,TAISAN,KHACHHANG where HOPDONG.MATS = TAISAN.MATS and HOPDONG.SoCMND = KHACHHANG.SoCMND and HOPDONG.NgayCam = '" + tungay + "'";
                cmd.CommandText = "SELECT SoHD,TenKhachHang,TenTS,TongSoTien,DienThoai,LaiSuat,NgayCam,NgayTra FROM HOPDONG,TAISAN,KHACHHANG where HOPDONG.MATS = TAISAN.MATS and HOPDONG.SoCMND = KHACHHANG.SoCMND and ( HOPDONG.Ngaycam BETWEEN '" + Convert.ToDateTime(tungay) + "' AND '" + Convert.ToDateTime(denngay) + "')";
                SqlDataReader rd1;
                rd1 = cmd.ExecuteReader();
                DataTable td = new DataTable();
                td.Load(rd1);
                listView1.Items.Clear();
                for (int i = 0; i < td.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(td.Rows[i][0].ToString());
                    item.SubItems.Add(td.Rows[i][1].ToString());
                    item.SubItems.Add(td.Rows[i][2].ToString());
                    item.SubItems.Add(td.Rows[i][3].ToString());
                    item.SubItems.Add(td.Rows[i][4].ToString());
                    item.SubItems.Add(td.Rows[i][5].ToString());
                    item.SubItems.Add(td.Rows[i][6].ToString());
                    item.SubItems.Add(td.Rows[i][7].ToString());
                   // item.SubItems.Add(td.Rows[i][8].ToString());
                    listView1.Items.Add(item);
                }
                con.Close();
            }
            else if (txtten.Text != "" && txtDocam.Text != "" && dateTimePicker1.Value == dateTimePicker2.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ket_noi.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT SoHD,TenKhachHang,TenTS,TongSoTien,DienThoai,LaiSuat,NgayCam,NgayTra FROM HOPDONG,TAISAN,KHACHHANG where HOPDONG.MATS = TAISAN.MATS and HOPDONG.SoCMND = KHACHHANG.SoCMND and TAISAN.TenTS LIKE '%" + txtDocam.Text + "%'and KHACHHANG.TenKhachHang LIKE '%" + txtten.Text + "%'";
                SqlDataReader rd1;
                rd1 = cmd.ExecuteReader();
                DataTable td = new DataTable();
                td.Load(rd1);
                listView1.Items.Clear();
                for (int i = 0; i < td.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(td.Rows[i][0].ToString());
                    item.SubItems.Add(td.Rows[i][1].ToString());
                    item.SubItems.Add(td.Rows[i][2].ToString());
                    item.SubItems.Add(td.Rows[i][3].ToString());
                    item.SubItems.Add(td.Rows[i][4].ToString());
                    item.SubItems.Add(td.Rows[i][5].ToString());
                    item.SubItems.Add(td.Rows[i][6].ToString());
                    item.SubItems.Add(td.Rows[i][7].ToString());
                  //  item.SubItems.Add(td.Rows[i][8].ToString());
                    listView1.Items.Add(item);
                }
                con.Close();
            }

            else if (txtten.Text != "" && txtDocam.Text != "" && dateTimePicker1.Value != dateTimePicker2.Value)
            {
                string tungay = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string denngay = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ket_noi.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                // cmd.CommandText =  "SELECT STT,SoHD,TenKhachHang,TenTS,TongSoTien,DienThoai,LaiSuat,NgayCam,NgayTra FROM HOPDONG,TAISAN,KHACHHANG where HOPDONG.MATS = TAISAN.MATS and HOPDONG.SoCMND = KHACHHANG.SoCMND and HOPDONG.NgayCam = '" + tungay + "'";
                cmd.CommandText = "SELECT SoHD,TenKhachHang,TenTS,TongSoTien,DienThoai,LaiSuat,NgayCam,NgayTra FROM HOPDONG,TAISAN,KHACHHANG where HOPDONG.MATS = TAISAN.MATS and HOPDONG.SoCMND = KHACHHANG.SoCMND and ( HOPDONG.Ngaycam BETWEEN '" + Convert.ToDateTime(tungay) + "' AND '" + Convert.ToDateTime(denngay) + "') and KHACHHANG.TenKhachHang LIKE '%" + txtten.Text + "%' and TAISAN.TenTS LIKE '%" + txtDocam.Text + "%'";
                SqlDataReader rd1;
                rd1 = cmd.ExecuteReader();
                DataTable td = new DataTable();
                td.Load(rd1);
                listView1.Items.Clear();
                for (int i = 0; i < td.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(td.Rows[i][0].ToString());
                    item.SubItems.Add(td.Rows[i][1].ToString());
                    item.SubItems.Add(td.Rows[i][2].ToString());
                    item.SubItems.Add(td.Rows[i][3].ToString());
                    item.SubItems.Add(td.Rows[i][4].ToString());
                    item.SubItems.Add(td.Rows[i][5].ToString());
                    item.SubItems.Add(td.Rows[i][6].ToString());
                    item.SubItems.Add(td.Rows[i][7].ToString());
                   // item.SubItems.Add(td.Rows[i][8].ToString());
                    listView1.Items.Add(item);
                }
                con.Close();
            }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        /* private void listView1_Click(object sender, EventArgs e)
          {
              string STT;
              string SoHD;
              int row = this.listView1.SelectedItems[0].Index;
              STT = this.listView1.Items[row].SubItems[0].Text;
              SoHD = this.listView1.Items[row].SubItems[1].Text;

          }*/
    }
}
