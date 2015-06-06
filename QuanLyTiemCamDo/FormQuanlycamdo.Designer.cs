using System;
namespace QuanLyTiemCamDo
{
    partial class FormQuanlycamdo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelthongtinchung = new System.Windows.Forms.Panel();
            this.texttiencamdo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textvonhientai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texttientrongket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCửaHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paneltimkiem = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.textdocam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.texttenkhachhang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelchuabutton = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.detailButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panelthongtinchung.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.paneltimkiem.SuspendLayout();
            this.panelchuabutton.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelthongtinchung
            // 
            this.panelthongtinchung.Controls.Add(this.texttiencamdo);
            this.panelthongtinchung.Controls.Add(this.label5);
            this.panelthongtinchung.Controls.Add(this.textvonhientai);
            this.panelthongtinchung.Controls.Add(this.label4);
            this.panelthongtinchung.Controls.Add(this.texttientrongket);
            this.panelthongtinchung.Controls.Add(this.label3);
            this.panelthongtinchung.Controls.Add(this.label2);
            this.panelthongtinchung.Controls.Add(this.label1);
            this.panelthongtinchung.Location = new System.Drawing.Point(1, 33);
            this.panelthongtinchung.Name = "panelthongtinchung";
            this.panelthongtinchung.Size = new System.Drawing.Size(270, 112);
            this.panelthongtinchung.TabIndex = 0;
            // 
            // texttiencamdo
            // 
            this.texttiencamdo.Location = new System.Drawing.Point(125, 84);
            this.texttiencamdo.Name = "texttiencamdo";
            this.texttiencamdo.ReadOnly = true;
            this.texttiencamdo.Size = new System.Drawing.Size(142, 20);
            this.texttiencamdo.TabIndex = 7;
            this.texttiencamdo.Text = "50000000";
            this.texttiencamdo.TextChanged += new System.EventHandler(this.texttiencamdo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tiền cầm đồ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textvonhientai
            // 
            this.textvonhientai.Location = new System.Drawing.Point(125, 57);
            this.textvonhientai.Name = "textvonhientai";
            this.textvonhientai.ReadOnly = true;
            this.textvonhientai.Size = new System.Drawing.Size(142, 20);
            this.textvonhientai.TabIndex = 5;
            this.textvonhientai.Text = "50000000";
            this.textvonhientai.TextChanged += new System.EventHandler(this.textvonhientai_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vốn hiện tại";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // texttientrongket
            // 
            this.texttientrongket.Location = new System.Drawing.Point(125, 30);
            this.texttientrongket.Name = "texttientrongket";
            this.texttientrongket.ReadOnly = true;
            this.texttientrongket.Size = new System.Drawing.Size(142, 20);
            this.texttientrongket.TabIndex = 3;
            this.texttientrongket.Text = "100000000";
            this.texttientrongket.TextChanged += new System.EventHandler(this.texttientrongket_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin chung";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 27);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.thôngTinCửaHàngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // thôngTinCửaHàngToolStripMenuItem
            // 
            this.thôngTinCửaHàngToolStripMenuItem.Name = "thôngTinCửaHàngToolStripMenuItem";
            this.thôngTinCửaHàngToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinCửaHàngToolStripMenuItem.Text = "Thông tin cửa hàng";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // paneltimkiem
            // 
            this.paneltimkiem.Controls.Add(this.label10);
            this.paneltimkiem.Controls.Add(this.dateTimePicker2);
            this.paneltimkiem.Controls.Add(this.dateTimePicker1);
            this.paneltimkiem.Controls.Add(this.label9);
            this.paneltimkiem.Controls.Add(this.bttim);
            this.paneltimkiem.Controls.Add(this.textdocam);
            this.paneltimkiem.Controls.Add(this.label8);
            this.paneltimkiem.Controls.Add(this.texttenkhachhang);
            this.paneltimkiem.Controls.Add(this.label7);
            this.paneltimkiem.Controls.Add(this.label6);
            this.paneltimkiem.Location = new System.Drawing.Point(277, 33);
            this.paneltimkiem.Name = "paneltimkiem";
            this.paneltimkiem.Size = new System.Drawing.Size(472, 112);
            this.paneltimkiem.TabIndex = 2;
            this.paneltimkiem.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltimkiem_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "  đến";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(279, 84);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Value = new System.DateTime(2015, 4, 19, 9, 23, 41, 305);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2015, 4, 19, 9, 23, 41, 305);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Hợp đồng bắt đầu từ";
            // 
            // bttim
            // 
            this.bttim.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttim.Location = new System.Drawing.Point(381, 33);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(75, 44);
            this.bttim.TabIndex = 9;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = false;
            this.bttim.Click += new System.EventHandler(this.button1_Click);
            // 
            // textdocam
            // 
            this.textdocam.Location = new System.Drawing.Point(142, 57);
            this.textdocam.Name = "textdocam";
            this.textdocam.Size = new System.Drawing.Size(216, 20);
            this.textdocam.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Đồ cầm";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // texttenkhachhang
            // 
            this.texttenkhachhang.Location = new System.Drawing.Point(142, 29);
            this.texttenkhachhang.Name = "texttenkhachhang";
            this.texttenkhachhang.Size = new System.Drawing.Size(216, 20);
            this.texttenkhachhang.TabIndex = 2;
            this.texttenkhachhang.TextChanged += new System.EventHandler(this.texttenkhachhang_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm kiếm";
            // 
            // panelchuabutton
            // 
            this.panelchuabutton.Controls.Add(this.editButton);
            this.panelchuabutton.Controls.Add(this.detailButton);
            this.panelchuabutton.Controls.Add(this.menuButton);
            this.panelchuabutton.Controls.Add(this.btxoa);
            this.panelchuabutton.Controls.Add(this.printButton);
            this.panelchuabutton.Controls.Add(this.btthem);
            this.panelchuabutton.Location = new System.Drawing.Point(755, 34);
            this.panelchuabutton.Name = "panelchuabutton";
            this.panelchuabutton.Size = new System.Drawing.Size(252, 111);
            this.panelchuabutton.TabIndex = 3;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.editButton.Location = new System.Drawing.Point(167, 60);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 39);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Sửa";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // detailButton
            // 
            this.detailButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.detailButton.Location = new System.Drawing.Point(167, 14);
            this.detailButton.Name = "detailButton";
            this.detailButton.Size = new System.Drawing.Size(75, 39);
            this.detailButton.TabIndex = 4;
            this.detailButton.Text = "Chi tiết";
            this.detailButton.UseVisualStyleBackColor = false;
            this.detailButton.Click += new System.EventHandler(this.detailButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuButton.Location = new System.Drawing.Point(85, 59);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 40);
            this.menuButton.TabIndex = 3;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btxoa.Location = new System.Drawing.Point(85, 14);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 39);
            this.btxoa.TabIndex = 2;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.printButton.Location = new System.Drawing.Point(4, 59);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 40);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "In";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btthem.Location = new System.Drawing.Point(4, 14);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 39);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.vScrollBar1);
            this.panel5.Location = new System.Drawing.Point(1, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1006, 341);
            this.panel5.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, -6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(980, 338);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(983, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(23, 341);
            this.vScrollBar1.TabIndex = 0;
            // 
            // FormQuanlycamdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 496);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelchuabutton);
            this.Controls.Add(this.paneltimkiem);
            this.Controls.Add(this.panelthongtinchung);
            this.Controls.Add(this.panel2);
            this.Name = "FormQuanlycamdo";
            this.Text = "FormQuanlycamdo";
            this.Load += new System.EventHandler(this.FormQuanlycamdo_Load);
            this.panelthongtinchung.ResumeLayout(false);
            this.panelthongtinchung.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.paneltimkiem.ResumeLayout(false);
            this.paneltimkiem.PerformLayout();
            this.panelchuabutton.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelthongtinchung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texttiencamdo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textvonhientai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texttientrongket;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCửaHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Panel paneltimkiem;
        private System.Windows.Forms.TextBox textdocam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox texttenkhachhang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Panel panelchuabutton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button detailButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;


    }
}