using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTiemCamDo
{
    public partial class FormQuanlycamdo : Form
    {
        public FormQuanlycamdo()
        {
            InitializeComponent();
        }

        private void FormQuanlycamdo_Load(object sender, EventArgs e)
        {
            this.View();
        }

        private void thôngTinCửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bai lam cua Hop. Xu ly nut Tim
            int sosanhNgay = DateTime.Compare(dateTimePicker1.Value, dateTimePicker2.Value);
            if (sosanhNgay > 0)
            {
                MessageBox.Show("Ngày bắt đầu không thể sau ngày kết thúc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConnectionSQL myCon = new ConnectionSQL();
            string tenKH = texttenkhachhang.Text;
            string docam = textdocam.Text;
            string ngayBatDau = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string ngayKetThuc = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            if (tenKH == "" && docam == "")
            {
                string sql = String.Format(@"SELECT SoHD 'Số hợp đồng',
                                                    TenKhachHang 'Tên khách hàng',
                                                    TenTS 'Tên tài sản',
                                                    TongSoTien 'Tiền cầm (VNĐ)',
                                                    DienThoai 'Số điện thoại',
                                                    LaiSuat 'Lãi suất (%)',
                                                    NgayCam 'Ngày cầm',
                                                    NgayHetHan 'Ngày hết hạn',
                                                    TrangThai 'Trạng thái'
                                            FROM HOPDONG a, KHACHHANG b, TAISAN C
                                            WHERE a.MaTS = c.MaTS AND a.SoCMND = b.SoCMND 
                                                  AND (a.NgayCam BETWEEN '{0}' AND '{1}')", ngayBatDau, ngayKetThuc);
                DataTable dtSearch = myCon.getDataTableSQL(sql);
                dataGridView1.DataSource = dtSearch;
            }
            else if (tenKH != "" && docam == "")
            {
                string sql = String.Format(@"SELECT SoHD 'Số hợp đồng',
                                                    TenKhachHang 'Tên khách hàng',
                                                    TenTS 'Tên tài sản',
                                                    TongSoTien 'Tiền cầm (VNĐ)',
                                                    DienThoai 'Số điện thoại',
                                                    LaiSuat 'Lãi suất (%)',
                                                    NgayCam 'Ngày cầm',
                                                    NgayHetHan 'Ngày hết hạn',
                                                    TrangThai 'Trạng thái'
                                            FROM HOPDONG a, KHACHHANG b, TAISAN C
                                            WHERE a.MaTS = c.MaTS AND a.SoCMND = b.SoCMND 
                                                  AND b.TenKhachHang LIKE N'%{0}%'
                                                  AND (a.NgayCam BETWEEN '{1}' AND '{2}')", tenKH, ngayBatDau, ngayKetThuc);
                DataTable dtSearch = myCon.getDataTableSQL(sql);
                dataGridView1.DataSource = dtSearch;
            }
            else if (tenKH == "" && docam != "")
            {
                string sql = String.Format(@"SELECT SoHD 'Số hợp đồng',
                                                    TenKhachHang 'Tên khách hàng',
                                                    TenTS 'Tên tài sản',
                                                    TongSoTien 'Tiền cầm (VNĐ)',
                                                    DienThoai 'Số điện thoại',
                                                    LaiSuat 'Lãi suất (%)',
                                                    NgayCam 'Ngày cầm',
                                                    NgayHetHan 'Ngày hết hạn',
                                                    TrangThai 'Trạng thái'
                                            FROM HOPDONG a, KHACHHANG b, TAISAN C
                                            WHERE a.MaTS = c.MaTS AND a.SoCMND = b.SoCMND 
                                                  AND c.TenTS LIKE N'%{0}%'
                                                  AND (a.NgayCam BETWEEN '{1}' AND '{2}')", docam, ngayBatDau, ngayKetThuc);
                DataTable dtSearch = myCon.getDataTableSQL(sql);
                dataGridView1.DataSource = dtSearch;
            }
            else
            {
                string sql = String.Format(@"SELECT SoHD 'Số hợp đồng',
                                                    TenKhachHang 'Tên khách hàng',
                                                    TenTS 'Tên tài sản',
                                                    TongSoTien 'Tiền cầm (VNĐ)',
                                                    DienThoai 'Số điện thoại',
                                                    LaiSuat 'Lãi suất (%)',
                                                    NgayCam 'Ngày cầm',
                                                    NgayHetHan 'Ngày hết hạn',
                                                    TrangThai 'Trạng thái'
                                            FROM HOPDONG a, KHACHHANG b, TAISAN C
                                            WHERE a.MaTS = c.MaTS AND a.SoCMND = b.SoCMND
                                                    AND b.TenKhachHang LIKE N'%{0}%' AND c.TenTS LIKE N'%{1}%'", tenKH, docam);
                DataTable dtSearch = myCon.getDataTableSQL(sql);
                dataGridView1.DataSource = dtSearch;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void texttenkhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
                return;
            if (this.dataGridView1.SelectedRows[0].Cells[0].Value == null)
                return;
            FormPrint print = new FormPrint();
            print.ID = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            print.Show();
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            FormHopDong f = new FormHopDong();
            f.View += new LoadDetail(View);
            f.Show();
        }

        private void detailButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                if (this.dataGridView1.SelectedRows[0].Cells[0].Value == null)
                    return;
                FormDTChiTiet detailForm = new FormDTChiTiet();
                detailForm.ID = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                detailForm.View += new LoadDetail(View);
                detailForm.Show();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
                return;
            if (this.dataGridView1.SelectedRows[0].Cells[0].Value == null)
                return;
            FormHopDong EForm = new FormHopDong();
            EForm.SoHD = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            EForm.iUpdate = true;
            EForm.View += new LoadDetail(View);
            EForm.Show();
        }
        private void View()
        {
            string sql = String.Format(@"SELECT SoHD 'Số hợp đồng',
                                                TenKhachHang 'Tên khách hàng',
                                                a.MaTS 'Mã tài sản',
                                                TenTS 'Tên tài sản',
                                                TongSoTien 'Tiền cầm (VNĐ)',
                                                DienThoai 'Số điện thoại',
                                                LaiSuat 'Lãi suất (%)',
                                                NgayCam 'Ngày cầm',
                                                NgayHetHan 'Ngày hết hạn',
                                                TrangThai 'Trạng thái'
                                            FROM HOPDONG a, KHACHHANG b, TAISAN C
                                            WHERE a.MaTS = c.MaTS AND a.SoCMND = b.SoCMND");
            DataTable data = new ConnectionSQL().getDataTableSQL(sql);
            for (int i = 0; i < data.Rows.Count; i++)
                data.Rows[i]["Tiền cầm (VNĐ)"] = data.Rows[i]["Tiền cầm (VNĐ)"].ToString().Split('.')[0];
            dataGridView1.DataSource = data;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string SoHD = row.Cells[0].Value.ToString();
                string MaTS = row.Cells[2].Value.ToString();
                string sql = String.Format(@"DELETE FROM HOPDONG WHERE SoHD = '{0}'", SoHD);
                ConnectionSQL myCon = new ConnectionSQL();
                myCon.executesql(sql);
                sql = sql = String.Format(@"DELETE FROM TAISAN WHERE MaTS = '{0}'", MaTS);
                myCon.executesql(sql);
                dataGridView1.Rows.Remove(row);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hợp đồng để xóa");
            }
        }

        private void paneltimkiem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void texttientrongket_TextChanged(object sender, EventArgs e)
        {

        }

        private void textvonhientai_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttiencamdo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
