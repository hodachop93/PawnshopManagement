using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemCamDo
{
    public partial class FormHopDong : Form
    {
        private LoadDetail view;
        public event LoadDetail View
        {
            add
            {
                this.view += value;
            }
            remove
            {
                this.view -= value;
            }
        }
        private bool update;
        public bool iUpdate
        {
            set
            {
                this.update = true;
            }
        }
        private string id_tmp;
        private string asid_tmp;
        private string idc_tmp;
        public string SoHD
        {
            set
            {
                this.id_tmp = value;
            }
        }
        private string soHD;
        private string tenKH;
        private string mats;
        private string docam;
        private string diachi;
        private string socmnd;
        private string dienthoai;
        private long tiencam;
        private float laisuat;
        private string ngaycam;
        private string ngayhethan;
        private string ghichu;
        public FormHopDong()
        {
            InitializeComponent();
            this.update = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long tmp;
            soHD = idTextBox.Text;
            if (soHD == "")
            {
                MessageBox.Show("Số hợp đồng bắt buộc phải nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tenKH = naTextBox.Text;
            if (tenKH == "")
            {
                MessageBox.Show("Tên khách hàng bắt buộc phải nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.tenKH.Length > 30)
            {
                MessageBox.Show("Tên khách hàng chỉ được nhập tối đa 30 ký tự");
                return;
            }
            mats = asidTextBox.Text;
            if (mats == "")
            {
                MessageBox.Show("Mã tài sản bắt buộc phải nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            docam = asTextBox.Text;
            if (docam == "")
            {
                MessageBox.Show("Đồ cầm cố bắt buộc phải nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            diachi = adTextBox.Text;
            socmnd = idcTextBox.Text;
            if (socmnd == "")
            {
                MessageBox.Show("Số CMT/Hộ chiếu bắt buộc phải nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!long.TryParse(this.socmnd, out tmp))
            {
                MessageBox.Show("Số CMT/Hộ chiếu chỉ bao gồm chữ số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dienthoai = phTextBox.Text;
            ngaycam = beDatePicker.Value.ToString("yyyy-MM-dd");
            ngayhethan = deDatePicker.Value.ToString("yyyy-MM-dd");
            if (DateTime.Compare(beDatePicker.Value, deDatePicker.Value) > 0)
            {
                MessageBox.Show("Ngày cầm và ngày hết hạn không hợp lý. Vui lòng nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ghichu = noTextBox.Text;

            //Check validate trường Tổng số tiền cầm
            try
            {
                if (this.toTextBox.Text.Length <= 0)
                {
                    MessageBox.Show("Tổng số tiền cầm bắt buộc phải nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tiencam = long.Parse(toTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Tổng số tiền cầm chỉ bao gồm chữ số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Check validate trường lãi suất
            try
            {
                if (this.inTextBox.Text.Length <= 0)
                {
                    MessageBox.Show("Lãi suất bắt buộc phải nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                laisuat = float.Parse(inTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lãi suất chỉ bao gồm chữ số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ConnectionSQL myCon = new ConnectionSQL();
            //
            if (this.update)
            {
                if (this.idTextBox.Text.Split(' ')[0] != this.id_tmp.Split(' ')[0])
                {
                    DataTable data = myCon.getDataTableSQL(String.Format("SELECT [SoHD] FROM [HOPDONG] WHERE [SoHD] = '{0}'", this.idTextBox.Text.Split(' ')[0]));
                    if (data.Rows.Count != 0)
                    {
                        MessageBox.Show("Mã hợp đồng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (this.asidTextBox.Text.Split(' ')[0] != this.asid_tmp.Split(' ')[0])
                {
                    DataTable data = myCon.getDataTableSQL(String.Format("SELECT [MaTS] FROM [TAISAN] WHERE [MaTS] = '{0}'", this.asidTextBox.Text.Split(' ')[0]));
                    if (data.Rows.Count != 0)
                    {
                        MessageBox.Show("Mã tài sản đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (this.idcTextBox.Text.Split(' ')[0] != this.idc_tmp.Split(' ')[0])
                {
                    DataTable data = myCon.getDataTableSQL(String.Format("SELECT [SoCMND] FROM [KHACHHANG] WHERE [SoCMND] = '{0}'", this.idcTextBox.Text.Split(' ')[0]));
                    if (data.Rows.Count != 0)
                    {
                        MessageBox.Show("Số CMND đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string command = string.Format(@"UPDATE [HOPDONG] SET 
                                                  [SoHD]='{0}', 
                                                  [TongSoTien]={1}, 
                                                  [GhiChu]=N'{2}',
                                                  [NgayCam]='{3}',
                                                  [NgayHetHan]='{4}',
                                                  [LaiSuat]={5},
                                                  [SoCMND]='{6}',
                                                  [MaTS]='{7}' WHERE [SoHD]='{8}'", this.idTextBox.Text, this.toTextBox.Text, this.noTextBox.Text, this.beDatePicker.Value, this.deDatePicker.Value, this.inTextBox.Text, this.idcTextBox.Text, this.asidTextBox.Text, this.id_tmp);
                myCon.executesql(command);
                command = string.Format(@"UPDATE [KHACHHANG] SET [TenKhachHang]=N'{0}', [SoCMND]='{1}', [DiaChi]=N'{2}', [DienThoai]='{3}' WHERE [SoCMND]='{4}'", this.naTextBox.Text, this.idcTextBox.Text, this.adTextBox.Text, this.phTextBox.Text, this.idc_tmp);
                myCon.executesql(command);
                command = string.Format(@"UPDATE [TAISAN] SET [MaTS]='{0}', [TenTS]=N'{1}' WHERE [MaTS]='{2}'", this.asidTextBox.Text, this.asTextBox.Text, this.asid_tmp);
                myCon.executesql(command);
                command = string.Format(@"UPDATE [GIAODICH] SET [MaGiaoDich]='{0}', [SoHD]='{1}' WHERE [MaGiaoDich]='{2}'", FormExGiaHan.KEY + this.idTextBox.Text.Split(' ')[0], this.idTextBox.Text.Split(' ')[0], FormExGiaHan.KEY + this.id_tmp);
                myCon.executesql(command);
                command = string.Format(@"UPDATE [GIAODICH] SET [MaGiaoDich]='{0}', [SoHD]='{1}' WHERE [MaGiaoDich]='{2}'", FormBMVayThem.KEY + this.idTextBox.Text.Split(' ')[0], this.idTextBox.Text.Split(' ')[0], FormBMVayThem.KEY + this.id_tmp);
                myCon.executesql(command);
                this.view();
                this.Close();
                return;
            }
            //
            //Insert du lieu vao table HOPDONG
            DataTable dtTable = myCon.getDataTableSQL(String.Format("SELECT SoHD FROM HOPDONG WHERE SoHD = '{0}'", soHD));
            if (dtTable.Rows.Count == 0)
            {
                string sql1 = String.Format(@"INSERT INTO HOPDONG(SoHD, TongSoTien, LaiSuat, NgayCam, NgayHetHan, GhiChu, MaTS, SoCMND)
                                         VALUES('{0}', {1}, {2}, '{3}', '{4}', N'{5}', '{6}', '{7}')",
                                         soHD, tiencam, laisuat, ngaycam, ngayhethan, ghichu, mats, socmnd);
                myCon.executesql(sql1);
            }
            else
            {
                MessageBox.Show("Mã hợp đồng đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dtTable.Reset();
            //Insert du lieu vao table TAISAN
            dtTable = myCon.getDataTableSQL(String.Format("SELECT MaTS FROM TAISAN WHERE MaTS = '{0}'", mats));
            if (dtTable.Rows.Count == 0)
            {
                string sql2 = String.Format("INSERT INTO TAISAN VALUES('{0}', N'{1}')", mats, docam);
                myCon.executesql(sql2);
            }
            else
            {
                MessageBox.Show("Mã tài sản đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dtTable.Reset();
            //Insert du lieu vao bang  KHACHHANG
            dtTable = myCon.getDataTableSQL(String.Format("SELECT SoCMND FROM KHACHHANG WHERE SoCMND = '{0}'", socmnd));
            if (dtTable.Rows.Count == 0)
            {
                //Them vao khach hang moi
                string sql3 = String.Format("INSERT INTO KHACHHANG VALUES(N'{0}', '{1}', N'{2}', '{3}')", tenKH, socmnd, diachi, dienthoai);
                myCon.executesql(sql3);
            }
            dtTable.Reset();
            this.view();
            this.Dispose();
        }

        private void FormHopDong_Load(object sender, EventArgs e)
        {
            if (this.update)
            {
                string command = string.Format(@"SELECT [TongSoTien], [LaiSuat], [NgayCam], [NgayHetHan], [GhiChu], [SoCMND], [MaTS] FROM [HOPDONG] WHERE [SoHD]='{0}'", this.id_tmp);
                DataTable data = new ConnectionSQL().getDataTableSQL(command);
                this.idTextBox.Text = this.id_tmp;
                this.toTextBox.Text = data.Rows[0][0].ToString().Split('.')[0];
                this.inTextBox.Text = data.Rows[0][1].ToString();
                this.beDatePicker.Value = (DateTime)data.Rows[0][2];
                this.deDatePicker.Value = (DateTime)data.Rows[0][3];
                this.noTextBox.Text = data.Rows[0][4].ToString();
                this.idcTextBox.Text = data.Rows[0][5].ToString();
                this.asidTextBox.Text = data.Rows[0][6].ToString();

                command = string.Format(@"SELECT [TenKhachHang], [DiaChi], [DienThoai] FROM [KHACHHANG] WHERE [SoCMND]='{0}'", this.idcTextBox.Text);
                this.idc_tmp = this.idcTextBox.Text;
                data = new ConnectionSQL().getDataTableSQL(command);
                this.naTextBox.Text = data.Rows[0][0].ToString();
                this.adTextBox.Text = data.Rows[0][1].ToString();
                this.phTextBox.Text = data.Rows[0][2].ToString();

                command = string.Format(@"SELECT [TenTS] FROM [TAISAN] WHERE [MaTS]='" + this.asidTextBox.Text + "'");
                this.asid_tmp = this.asidTextBox.Text;
                data = new ConnectionSQL().getDataTableSQL(command);
                this.asTextBox.Text = data.Rows[0][0].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
