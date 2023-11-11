using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
      
        BindingSource DgvStaffBinding;
        BindingSource DgvAccountBinding;
        private Account ac;

        public Admin()
        {
            InitializeComponent();

            DgvStaffBinding = new BindingSource();
            dgvNhanVien.DataSource = DgvStaffBinding;
            DgvAccountBinding = new BindingSource();
            load();
        }

        public Admin(Account ac)
        {
            this.ac = ac;
        }

        #region methods
        private void load()
        {
           
            LoadListStaff();
           
            
        }

        private void LoadListStaff()
        {
            DgvStaffBinding.DataSource = BLL_QLNV.Instance.GetAllStaff();
            dgvNhanVien.Columns[7].Visible = false;
            SetCBBItemStaff();
            AddStaffBinding();
        }
      
      
       
        private void AddStaffBinding()
        {
            tbMaNhanVien.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "MaNhanVien", true, DataSourceUpdateMode.Never));
            tbTenNhanVien.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "TenNhanVien", true, DataSourceUpdateMode.Never));
            tbSDT.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "SoDienThoai", true, DataSourceUpdateMode.Never));
            tbDC.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            tbCMND.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            tbQueQuan.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "QueQuan", true, DataSourceUpdateMode.Never));
            tbCaLamViec.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "CaLamViec", true, DataSourceUpdateMode.Never));
        }
       
        
        private void SetCBBItemStaff()
        {
            cbSortStaff.Items.Add(new CBBItem { Text = "Tăng theo tên nhân viên", Value = "1" });
            cbSortStaff.Items.Add(new CBBItem { Text = "Giảm theo tên nhân viên", Value = "2" });

            cbSortStaff.SelectedItem = cbSortStaff.Items[0];
        }
      
       

        private void ShowStaff()
        {
            string ValueSort = ((CBBItem)cbSortStaff.SelectedItem).Value;
            string KeyWord = tbFindStaff.Text;
            DgvStaffBinding.DataSource = BLL_QLNV.Instance.GetListStaff(ValueSort, KeyWord);
            dgvNhanVien.Columns[7].Visible = false;
        }
        
       
        private void UpdateStaff()
        {
            byte[] HinhAnh;
            ImageConverter converter = new ImageConverter();
            HinhAnh = (byte[])converter.ConvertTo(pbNhanVien.Image, typeof(byte[]));
            NhanVien da = new NhanVien(tbTenNhanVien.Text, tbMaNhanVien.Text, tbSDT.Text, tbDC.Text, tbCMND.Text, tbQueQuan.Text, tbCaLamViec.Text, HinhAnh);
            bool result;
            try
            {
                result = BLL_QLNV.Instance.UpdateStaff(da);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (result)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }
        
        private void DeleteStaff()
        {
            List<string> ListDelete = new List<string>();
            foreach (DataGridViewRow i in dgvNhanVien.SelectedRows)
            {
                ListDelete.Add(i.Cells["MaNhanVien"].Value.ToString());
            }
            if (BLL_QLNV.Instance.DeleteStaff(ListDelete))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    
                     
        #endregion

        #region events
       
        
        private void tbMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            string MaNhanVien = tbMaNhanVien.Text;
            NhanVien food = BLL_QLNV.Instance.GetStaffByStaffId(MaNhanVien);
            if (food != null)
            {
                if (food.HinhAnh != null)
                {
                    MemoryStream ms = new MemoryStream(food.HinhAnh);
                    pbNhanVien.Image = Image.FromStream(ms);
                }
                else
                {
                    pbNhanVien.Image = null;
                }
            }
        }
      
       
        
        private void pbNhanVien_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = "C://Desktop";
            openFileDialog2.Title = "Select image to be upload.";
            openFileDialog2.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog2.FilterIndex = 1;
            try
            {
                if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog2.CheckFileExists)
                    {
                        pbNhanVien.Image = new Bitmap(openFileDialog2.FileName);
                        pbNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff f2 = new AddStaff();
            f2.ShowDialog();
            
            ShowStaff();
        }
        private void btFixStaff_Click(object sender, EventArgs e)
        {
            UpdateStaff();
            ShowStaff();
        }
        private void btDelStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa " + dgvNhanVien.SelectedRows.Count.ToString() + " nhân viên?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DeleteStaff();
                ShowStaff();
            }
        }
        private void btSortStaff_Click(object sender, EventArgs e)
        {
            ShowStaff();
        }
        private void btFindStaff_Click(object sender, EventArgs e)
        {
            ShowStaff();
        }

      
    }
}
#endregion