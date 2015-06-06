using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace QuanLyTiemCamDo
{
    public partial class FormPrint : Form
    {
        private string id_contract;
        public string ID
        {
            set
            {
                this.id_contract = value;
            }
        }
        public FormPrint()
        {
            InitializeComponent();
        }

        private void FormIn_Load(object sender, EventArgs e)
        {
            string command = string.Format(@"SELECT [LaiSuat], [NgayCam], [NgayHetHan], [TongSoTien], [SoCMND], [MaTS] FROM [HOPDONG] " +
                                            "WHERE [SoHD]='{0}'", this.id_contract);
            DataTable dataCT = new ConnectionSQL().getDataTableSQL(command);
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("SoHD", this.id_contract));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("LaiSuat", dataCT.Rows[0][0].ToString()));
            DateTime NgayCam = (DateTime)dataCT.Rows[0][1];
            DateTime NgayHetHan = (DateTime)dataCT.Rows[0][2];
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("NgayCam", NgayCam.Day + "/" + NgayCam.Month + "/" + NgayCam.Year));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("NgayHetHan", NgayHetHan.Day + "/" + NgayHetHan.Month + "/" + NgayHetHan.Year));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("TongSoTien", dataCT.Rows[0][3].ToString()));

            DataTable dataCS = new ConnectionSQL().getDataTableSQL(@"SELECT * FROM [KHACHHANG] WHERE [SoCMND]='" + dataCT.Rows[0][4] + "'");
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("TenKhachHang", dataCS.Rows[0][0].ToString()));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("SoCMND", dataCS.Rows[0][1].ToString()));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("DiaChi", dataCS.Rows[0][2].ToString()));
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("DienThoai", dataCS.Rows[0][3].ToString()));

            DataTable dataAS = new ConnectionSQL().getDataTableSQL(@"SELECT [TenTS] FROM [TAISAN] WHERE [MaTS]='" + dataCT.Rows[0][5] + "'");
            this.reportViewer.LocalReport.SetParameters(new ReportParameter("TenTS", dataAS.Rows[0][0].ToString()));
            this.reportViewer.RefreshReport();
        }

    }
}
