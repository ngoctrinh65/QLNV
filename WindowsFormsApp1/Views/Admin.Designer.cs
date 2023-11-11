
namespace WindowsFormsApp1
{
    partial class Admin
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.btSortStaff = new System.Windows.Forms.Button();
            this.cbSortStaff = new System.Windows.Forms.ComboBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.tbFindStaff = new System.Windows.Forms.TextBox();
            this.btFindStaff = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel19 = new System.Windows.Forms.Panel();
            this.pbNhanVien = new System.Windows.Forms.PictureBox();
            this.panel41 = new System.Windows.Forms.Panel();
            this.tbCaLamViec = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel40 = new System.Windows.Forms.Panel();
            this.tbQueQuan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.tbDC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.tbTenNhanVien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.tbMaNhanVien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel37 = new System.Windows.Forms.Panel();
            this.btDelStaff = new System.Windows.Forms.Button();
            this.btFixStaff = new System.Windows.Forms.Button();
            this.btAddStaff = new System.Windows.Forms.Button();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNhanVien)).BeginInit();
            this.panel41.SuspendLayout();
            this.panel40.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel37.SuspendLayout();
            this.tcAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel16);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1318, 704);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Nhân Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel27);
            this.panel16.Controls.Add(this.panel21);
            this.panel16.Controls.Add(this.dgvNhanVien);
            this.panel16.Controls.Add(this.panel19);
            this.panel16.Controls.Add(this.panel37);
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1318, 704);
            this.panel16.TabIndex = 1;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.btSortStaff);
            this.panel27.Controls.Add(this.cbSortStaff);
            this.panel27.Location = new System.Drawing.Point(1029, 368);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(263, 41);
            this.panel27.TabIndex = 14;
            // 
            // btSortStaff
            // 
            this.btSortStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btSortStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSortStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSortStaff.Location = new System.Drawing.Point(171, 3);
            this.btSortStaff.Name = "btSortStaff";
            this.btSortStaff.Size = new System.Drawing.Size(89, 31);
            this.btSortStaff.TabIndex = 2;
            this.btSortStaff.Text = "Sắp xếp";
            this.btSortStaff.UseVisualStyleBackColor = false;
            this.btSortStaff.Click += new System.EventHandler(this.btSortStaff_Click);
            // 
            // cbSortStaff
            // 
            this.cbSortStaff.FormattingEnabled = true;
            this.cbSortStaff.Location = new System.Drawing.Point(6, 10);
            this.cbSortStaff.Name = "cbSortStaff";
            this.cbSortStaff.Size = new System.Drawing.Size(159, 24);
            this.cbSortStaff.TabIndex = 1;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.tbFindStaff);
            this.panel21.Controls.Add(this.btFindStaff);
            this.panel21.Location = new System.Drawing.Point(1029, 415);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(263, 41);
            this.panel21.TabIndex = 13;
            // 
            // tbFindStaff
            // 
            this.tbFindStaff.Location = new System.Drawing.Point(6, 11);
            this.tbFindStaff.Name = "tbFindStaff";
            this.tbFindStaff.Size = new System.Drawing.Size(159, 22);
            this.tbFindStaff.TabIndex = 3;
            // 
            // btFindStaff
            // 
            this.btFindStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btFindStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFindStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFindStaff.Location = new System.Drawing.Point(171, 0);
            this.btFindStaff.Name = "btFindStaff";
            this.btFindStaff.Size = new System.Drawing.Size(89, 34);
            this.btFindStaff.TabIndex = 2;
            this.btFindStaff.Text = "Tìm kiếm";
            this.btFindStaff.UseVisualStyleBackColor = false;
            this.btFindStaff.Click += new System.EventHandler(this.btFindStaff_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(6, 462);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1303, 236);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.pbNhanVien);
            this.panel19.Controls.Add(this.panel41);
            this.panel19.Controls.Add(this.panel40);
            this.panel19.Controls.Add(this.panel22);
            this.panel19.Controls.Add(this.panel23);
            this.panel19.Controls.Add(this.panel24);
            this.panel19.Controls.Add(this.panel25);
            this.panel19.Controls.Add(this.panel26);
            this.panel19.Location = new System.Drawing.Point(6, 19);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(995, 437);
            this.panel19.TabIndex = 3;
            // 
            // pbNhanVien
            // 
            this.pbNhanVien.Location = new System.Drawing.Point(518, 6);
            this.pbNhanVien.Name = "pbNhanVien";
            this.pbNhanVien.Size = new System.Drawing.Size(347, 427);
            this.pbNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNhanVien.TabIndex = 8;
            this.pbNhanVien.TabStop = false;
            this.pbNhanVien.Click += new System.EventHandler(this.pbNhanVien_Click);
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.tbCaLamViec);
            this.panel41.Controls.Add(this.label15);
            this.panel41.Location = new System.Drawing.Point(3, 371);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(483, 56);
            this.panel41.TabIndex = 7;
            // 
            // tbCaLamViec
            // 
            this.tbCaLamViec.Location = new System.Drawing.Point(166, 14);
            this.tbCaLamViec.Name = "tbCaLamViec";
            this.tbCaLamViec.Size = new System.Drawing.Size(254, 22);
            this.tbCaLamViec.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(3, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ca làm việc:";
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.tbQueQuan);
            this.panel40.Controls.Add(this.label14);
            this.panel40.Location = new System.Drawing.Point(3, 312);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(483, 56);
            this.panel40.TabIndex = 6;
            // 
            // tbQueQuan
            // 
            this.tbQueQuan.Location = new System.Drawing.Point(166, 14);
            this.tbQueQuan.Name = "tbQueQuan";
            this.tbQueQuan.Size = new System.Drawing.Size(254, 22);
            this.tbQueQuan.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(3, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Quê quán:";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.tbDC);
            this.panel22.Controls.Add(this.label2);
            this.panel22.Location = new System.Drawing.Point(3, 189);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(483, 56);
            this.panel22.TabIndex = 5;
            // 
            // tbDC
            // 
            this.tbDC.Location = new System.Drawing.Point(166, 17);
            this.tbDC.Name = "tbDC";
            this.tbDC.Size = new System.Drawing.Size(254, 22);
            this.tbDC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ:";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.tbCMND);
            this.panel23.Controls.Add(this.label5);
            this.panel23.Location = new System.Drawing.Point(3, 250);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(483, 56);
            this.panel23.TabIndex = 4;
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(166, 17);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(254, 22);
            this.tbCMND.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "CMND:";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.tbSDT);
            this.panel24.Controls.Add(this.label6);
            this.panel24.Location = new System.Drawing.Point(3, 127);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(483, 56);
            this.panel24.TabIndex = 3;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(166, 17);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(254, 22);
            this.tbSDT.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(3, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại:";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.tbTenNhanVien);
            this.panel25.Controls.Add(this.label12);
            this.panel25.Location = new System.Drawing.Point(3, 65);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(483, 56);
            this.panel25.TabIndex = 2;
            // 
            // tbTenNhanVien
            // 
            this.tbTenNhanVien.Location = new System.Drawing.Point(166, 14);
            this.tbTenNhanVien.Name = "tbTenNhanVien";
            this.tbTenNhanVien.Size = new System.Drawing.Size(254, 22);
            this.tbTenNhanVien.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(3, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên nhân viên:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.tbMaNhanVien);
            this.panel26.Controls.Add(this.label13);
            this.panel26.Location = new System.Drawing.Point(3, 3);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(483, 56);
            this.panel26.TabIndex = 1;
            // 
            // tbMaNhanVien
            // 
            this.tbMaNhanVien.Enabled = false;
            this.tbMaNhanVien.Location = new System.Drawing.Point(158, 14);
            this.tbMaNhanVien.Name = "tbMaNhanVien";
            this.tbMaNhanVien.ReadOnly = true;
            this.tbMaNhanVien.Size = new System.Drawing.Size(254, 22);
            this.tbMaNhanVien.TabIndex = 1;
            this.tbMaNhanVien.TextChanged += new System.EventHandler(this.tbMaNhanVien_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(3, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã nhân viên:";
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.btDelStaff);
            this.panel37.Controls.Add(this.btFixStaff);
            this.panel37.Controls.Add(this.btAddStaff);
            this.panel37.Location = new System.Drawing.Point(1029, 36);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(263, 192);
            this.panel37.TabIndex = 0;
            // 
            // btDelStaff
            // 
            this.btDelStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btDelStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDelStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDelStaff.Location = new System.Drawing.Point(23, 134);
            this.btDelStaff.Name = "btDelStaff";
            this.btDelStaff.Size = new System.Drawing.Size(230, 58);
            this.btDelStaff.TabIndex = 2;
            this.btDelStaff.Text = "Xóa";
            this.btDelStaff.UseVisualStyleBackColor = false;
            this.btDelStaff.Click += new System.EventHandler(this.btDelStaff_Click);
            // 
            // btFixStaff
            // 
            this.btFixStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btFixStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFixStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFixStaff.Location = new System.Drawing.Point(23, 65);
            this.btFixStaff.Name = "btFixStaff";
            this.btFixStaff.Size = new System.Drawing.Size(230, 63);
            this.btFixStaff.TabIndex = 1;
            this.btFixStaff.Text = "Sửa";
            this.btFixStaff.UseVisualStyleBackColor = false;
            this.btFixStaff.Click += new System.EventHandler(this.btFixStaff_Click);
            // 
            // btAddStaff
            // 
            this.btAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAddStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAddStaff.Location = new System.Drawing.Point(23, 0);
            this.btAddStaff.Name = "btAddStaff";
            this.btAddStaff.Size = new System.Drawing.Size(230, 59);
            this.btAddStaff.TabIndex = 0;
            this.btAddStaff.Text = "Thêm";
            this.btAddStaff.UseVisualStyleBackColor = false;
            this.btAddStaff.Click += new System.EventHandler(this.btAddStaff_Click);
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tabPage1);
            this.tcAdmin.Location = new System.Drawing.Point(13, 13);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1326, 733);
            this.tcAdmin.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1351, 758);
            this.Controls.Add(this.tcAdmin);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tabPage1.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNhanVien)).EndInit();
            this.panel41.ResumeLayout(false);
            this.panel41.PerformLayout();
            this.panel40.ResumeLayout(false);
            this.panel40.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel37.ResumeLayout(false);
            this.tcAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Button btSortStaff;
        private System.Windows.Forms.ComboBox cbSortStaff;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox tbFindStaff;
        private System.Windows.Forms.Button btFindStaff;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.PictureBox pbNhanVien;
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.TextBox tbCaLamViec;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.TextBox tbQueQuan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox tbDC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox tbTenNhanVien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox tbMaNhanVien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.Button btDelStaff;
        private System.Windows.Forms.Button btFixStaff;
        private System.Windows.Forms.Button btAddStaff;
        private System.Windows.Forms.TabControl tcAdmin;
    }
}