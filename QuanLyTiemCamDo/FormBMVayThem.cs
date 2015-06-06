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

    public partial class FormBMVayThem : Form
    {
        private LoadDetail load;
        public event LoadDetail LOAD
        {
            add
            {
                this.load += value;
            }
            remove
            {
                this.load -= value;
            }
        }
        public const string KEY = "BMVT";
        private string id_contract;
        public string ID
        {
            set
            {
                this.id_contract = value;
            }
        }
        public FormBMVayThem()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            long value;
            if (!long.TryParse(this.amountTextBox.Text, out value))
            {
                MessageBox.Show("Vui lòng nhập lại số tiền cần vay thêm", "Lỗi");
                this.amountTextBox.Text = "";
                return;
            }
            new ConnectionSQL().executesql(string.Format(@"UPDATE [HOPDONG] SET [VayThem]={0}, [SoTienVayThem]={1} WHERE [SoHD]='{2}'", 1, value, this.id_contract));
            new ConnectionSQL().executesql(string.Format(@"UPDATE [HOPDONG] SET [TongSoTien]=[TongSoTien] + [SoTienVayThem] WHERE [SoHD]='{0}'", this.id_contract));
            new ConnectionSQL().executesql(string.Format(@"INSERT INTO [GIAODICH](MaGiaoDich, SoHD, NgayGiaoDich) VALUES('{0}','{1}','{2}')", FormBMVayThem.KEY + this.id_contract, this.id_contract, this.datePicker.Value));
            MessageBox.Show("Đã xác nhận vay thêm", "Thông báo");
            this.confirmButton.Enabled = false;
            this.load();
        }

        private void FormBMVayThem_Load(object sender, EventArgs e)
        {
            DataTable data = new ConnectionSQL().getDataTableSQL(@"SELECT [SoTienVayThem] FROM [HOPDONG] WHERE [VayThem]=1 and [SoHD]='" + this.id_contract + "'");
            if (data.Rows.Count != 0)
            {
                DataTable dataBMVayThem = new ConnectionSQL().getDataTableSQL(@"SELECT [NgayGiaoDich] FROM [GIAODICH] WHERE [MaGiaoDich] ='" + FormBMVayThem.KEY + this.id_contract + "'");
                this.datePicker.Value = (DateTime)dataBMVayThem.Rows[0][0];
                this.amountTextBox.Text = data.Rows[0][0].ToString().Split('.')[0];
                this.confirmButton.Enabled = false;
                return;
            }
            this.datePicker.Value = DateTime.Now;
        }
    }
}
