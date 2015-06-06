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
    public partial class FormExGiaHan : Form
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
        public const string KEY = "EXGH";
        private string id_contract;
        public string ID
        {
            set
            {
                this.id_contract = value;
            }
        }
        public FormExGiaHan()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(this.exText.Text, out value))
            {
                MessageBox.Show("Vui lòng nhập lại số tháng cần gia hạn", "Lỗi");
                this.exText.Text = "";
                return;
            }
            this.ExDatePicker.Value = this.ExDatePicker.Value.AddMonths(value);
            new ConnectionSQL().executesql(string.Format(@"UPDATE [HOPDONG] SET [GiaHan]={0}, [SoThangGH]={1}, [NgayHetHan]='{2}' WHERE [SoHD]='{3}'", 1, value, this.ExDatePicker.Value, this.id_contract));
            new ConnectionSQL().executesql(string.Format(@"INSERT INTO [GIAODICH](MaGiaoDich, SoHD, NgayGiaoDich,LyDo) VALUES('{0}','{1}','{2}','{3}')", FormExGiaHan.KEY + this.id_contract, this.id_contract, DateTime.Now, this.reRichText.Text));
            this.confirmButton.Enabled = false;
            this.load();
            MessageBox.Show("Đã xác nhận gia hạn", "Thông báo");
        }

        private void FormExGiaHan_Load(object sender, EventArgs e)
        {
            DataTable data = new ConnectionSQL().getDataTableSQL(@"SELECT [NgayHetHan],[SoThangGH] FROM [HOPDONG] WHERE [GiaHan]=1 and [SoHD]='" + this.id_contract + "'");
            if (data.Rows.Count > 0)
            {
                this.ExDatePicker.Value = (DateTime)data.Rows[0][0];
                this.exText.Text = data.Rows[0][1].ToString();
                DataTable detail = new ConnectionSQL().getDataTableSQL(@"SELECT [LyDo] FROM [GIAODICH] WHERE [MaGiaoDich]='" + FormExGiaHan.KEY + this.id_contract + "'");
                this.confirmButton.Enabled = false;
                return;
            }
            data = new ConnectionSQL().getDataTableSQL(@"SELECT [NgayHetHan] FROM [HOPDONG] WHERE [SoHD]='" + this.id_contract + "'");
            this.ExDatePicker.Value = (DateTime)data.Rows[0][0];
        }
    }
}
