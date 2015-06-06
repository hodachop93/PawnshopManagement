namespace QuanLyTiemCamDo
{
    partial class FormDTChiTiet
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
            this.label1 = new System.Windows.Forms.Label();
            this.beTextBox = new System.Windows.Forms.TextBox();
            this.enTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.exButton = new System.Windows.Forms.Button();
            this.moButton = new System.Windows.Forms.Button();
            this.enButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày cầm";
            // 
            // beTextBox
            // 
            this.beTextBox.Location = new System.Drawing.Point(188, 12);
            this.beTextBox.Name = "beTextBox";
            this.beTextBox.ReadOnly = true;
            this.beTextBox.Size = new System.Drawing.Size(126, 23);
            this.beTextBox.TabIndex = 1;
            // 
            // enTextBox
            // 
            this.enTextBox.Location = new System.Drawing.Point(190, 41);
            this.enTextBox.Name = "enTextBox";
            this.enTextBox.ReadOnly = true;
            this.enTextBox.Size = new System.Drawing.Size(124, 23);
            this.enTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày hết hạn";
            // 
            // amTextBox
            // 
            this.amTextBox.Location = new System.Drawing.Point(190, 70);
            this.amTextBox.Name = "amTextBox";
            this.amTextBox.ReadOnly = true;
            this.amTextBox.Size = new System.Drawing.Size(124, 23);
            this.amTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng số tiền cầm";
            // 
            // inTextBox
            // 
            this.inTextBox.Location = new System.Drawing.Point(190, 99);
            this.inTextBox.Name = "inTextBox";
            this.inTextBox.ReadOnly = true;
            this.inTextBox.Size = new System.Drawing.Size(124, 23);
            this.inTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lãi suất";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(190, 128);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.ReadOnly = true;
            this.toTextBox.Size = new System.Drawing.Size(124, 23);
            this.toTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng lãi phải trả";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(244, 176);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(71, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // exButton
            // 
            this.exButton.Location = new System.Drawing.Point(12, 176);
            this.exButton.Name = "exButton";
            this.exButton.Size = new System.Drawing.Size(71, 23);
            this.exButton.TabIndex = 14;
            this.exButton.Text = "Gia hạn";
            this.exButton.UseVisualStyleBackColor = true;
            this.exButton.Click += new System.EventHandler(this.exButton_Click);
            // 
            // moButton
            // 
            this.moButton.Location = new System.Drawing.Point(89, 176);
            this.moButton.Name = "moButton";
            this.moButton.Size = new System.Drawing.Size(71, 23);
            this.moButton.TabIndex = 13;
            this.moButton.Text = "Vay thêm";
            this.moButton.UseVisualStyleBackColor = true;
            this.moButton.Click += new System.EventHandler(this.moButton_Click);
            // 
            // enButton
            // 
            this.enButton.Location = new System.Drawing.Point(167, 176);
            this.enButton.Name = "enButton";
            this.enButton.Size = new System.Drawing.Size(71, 23);
            this.enButton.TabIndex = 16;
            this.enButton.Text = "Trả nợ";
            this.enButton.UseVisualStyleBackColor = true;
            this.enButton.Click += new System.EventHandler(this.enButton_Click);
            // 
            // FormDTChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 211);
            this.Controls.Add(this.enButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.exButton);
            this.Controls.Add(this.moButton);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.beTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormDTChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT";
            this.Load += new System.EventHandler(this.FormDTChiTiet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox beTextBox;
        private System.Windows.Forms.TextBox enTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button exButton;
        private System.Windows.Forms.Button moButton;
        private System.Windows.Forms.Button enButton;
    }
}