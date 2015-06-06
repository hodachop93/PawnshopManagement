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
    public delegate void LoadDetail();
    public partial class FormDTChiTiet : Form
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
        private string id_contract;
        public string ID
        {
            set
            {

                this.id_contract = value;
            }
        }
        public FormDTChiTiet()
        {
            InitializeComponent();
        }

        private void FormDTChiTiet_Load(object sender, EventArgs e)
        {
            this.ShowDetail();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exButton_Click(object sender, EventArgs e)
        {
            FormExGiaHan exFrom = new FormExGiaHan();
            exFrom.ID = this.id_contract;
            exFrom.LOAD += new LoadDetail(ShowDetail);
            exFrom.Show();
        }

        private void moButton_Click(object sender, EventArgs e)
        {
            FormBMVayThem bmForm = new FormBMVayThem();
            bmForm.ID = this.id_contract;
            bmForm.LOAD += new LoadDetail(ShowDetail);
            bmForm.Show();
        }
        public void ShowDetail()
        {
            string command = String.Format(@"SELECT [NgayCam], [NgayHetHan], [TongSoTien], [LaiSuat] FROM HOPDONG WHERE [SoHD]='" + this.id_contract + "'");
            DataTable data = new ConnectionSQL().getDataTableSQL(command);
            this.beTextBox.Text = ((DateTime)data.Rows[0][0]).Day + "/" + ((DateTime)data.Rows[0][0]).Month + "/" + ((DateTime)data.Rows[0][0]).Year;
            this.enTextBox.Text = ((DateTime)data.Rows[0][1]).Day + "/" + ((DateTime)data.Rows[0][1]).Month + "/" + ((DateTime)data.Rows[0][1]).Year;
            this.amTextBox.Text = data.Rows[0][2].ToString().Split('.')[0];
            this.inTextBox.Text = data.Rows[0][3] + "%";
            DateTime dateB = ((DateTime)data.Rows[0][0]);
            DateTime dateE = ((DateTime)data.Rows[0][1]);

            int mons = (dateE.Month + 12 * (dateE.Year - dateB.Year) - dateB.Month) == 0 ? 1 : (dateE.Month + 12 * (dateE.Year - dateB.Year) - dateB.Month);
            this.toTextBox.Text = ((long)(mons * (float.Parse(data.Rows[0][3].ToString()) / 100) * long.Parse(this.amTextBox.Text.Split('.')[0]))).ToString();

        }

        private void enButton_Click(object sender, EventArgs e)
        {
            string command = string.Format(@"SELECT [SoCMND],[MaTS] FROM [HOPDONG] WHERE [SoHD]='{0}'", this.id_contract);
            DataTable data = new ConnectionSQL().getDataTableSQL(command);
            command = string.Format(@"DELETE FROM [GIAODICH] WHERE [SoHD]='{0}'",this.id_contract);
            new ConnectionSQL().executesql(command);
            command = string.Format(@"DELETE FROM [KHACHHANG] WHERE [SoCMND]='{0}'", data.Rows[0][0].ToString());
            new ConnectionSQL().executesql(command);
            command = string.Format(@"DELETE FROM [TAISAN] WHERE [MaTS]='{0}'", data.Rows[0][1].ToString());
            new ConnectionSQL().executesql(command);
            command = string.Format(@"DELETE FROM [HOPDONG] WHERE [SoHD]='{0}'", this.id_contract);
            new ConnectionSQL().executesql(command);
            MessageBox.Show("Đã xác nhận trả nợ", "Thông báo");
            this.view();
            this.Close();
        }
    }
}
