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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txttendangnhap.Text = txtmatkhau.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txttendangnhap.Text;
            string MatKhau = txtmatkhau.Text;
            if (testLogin(TenDangNhap, MatKhau))
            {
                DataTable dt = new ConnectionSQL().getDataTableSQL("SELECT *  FROM [NHANVIEN] WHERE [TenDangNhap]='" + TenDangNhap + "' and  [MatKhau]='" + MatKhau + "'");
                if (dt.Rows.Count <= 0) { MessageBox.Show("Tài khoản không tồn tại hoặc mật khẩu chưa chính xác!"); }
                else
                {
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(StartFormMain));
                    t.SetApartmentState(System.Threading.ApartmentState.STA);
                    t.Start();
                    this.Dispose();
                }
            }
        }


        private bool testLogin(string TenDangNhap, string MatKhau)
        {
            if (TenDangNhap.Length == 0)
            {
                MessageBox.Show("User name không được để trống");
                return false;
            }
            if (TenDangNhap.Length > 30)
            {
                MessageBox.Show("User name chỉ được phép tối đa 30 kí tự");
                return false;
            }
            // kiem tra ki tu dac biet
            string kutuduocdung = "1234567890_QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            foreach (char kytu in TenDangNhap)
            {
                bool kt = false;
                foreach (char k in kutuduocdung)
                {
                    if (kytu.Equals(k)) { kt = true; break; }
                }
                if (!kt)
                {
                    MessageBox.Show("User name không được nhập kí tự đặc biệt");
                    return false;
                }
            }
            if (MatKhau.Length == 0)
            {
                MessageBox.Show("Password không được để trống");
                return false;
            }

            if (MatKhau.Length > 30)
            {
                MessageBox.Show("Password chỉ được phép tối đa 30 kí tự");
                return false;
            }
            return true;
        }

        private void StartFormMain()
        {
            FormMain f = new FormMain();
            Application.Run(f);
        }
    }
}
