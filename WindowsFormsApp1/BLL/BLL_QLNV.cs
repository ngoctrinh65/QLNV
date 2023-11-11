using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BLL
{
    class BLL_QLNV
    {
        private static BLL_QLNV _Instance;
        public static BLL_QLNV Instance
        {
            get

            {
                if (_Instance == null) _Instance = new BLL_QLNV();
                return _Instance;
            }
            private set
            {

            }
        }

        private BLL_QLNV()
        {

        }

        public Account GetAccount(string UserName, string PassWord)
        {
            Account data;
            data = DAL_QLNV.Instance.GetAccount(UserName, PassWord);
            return data;
        }

      
        private int AscendingByStaff(NhanVien d1, NhanVien d2)
        {
            return d1.TenNhanVien.CompareTo(d2.TenNhanVien);
        }
        private int DescendingByStaff(NhanVien d1, NhanVien d2)
        {
            return d2.TenNhanVien.CompareTo(d1.TenNhanVien);
        }

        public NhanVien GetStaffByStaffId(string MaNhanVien)
        {
            foreach (NhanVien i in DAL_QLNV.Instance.GetAllStaff())
            {
                if (i.MaNhanVien.Equals(MaNhanVien))
                {
                    return i;
                }
            }
            return null;
        }
        public Account GetAccountByAccountName(string TenTaiKhoan)
        {
            foreach (Account i in DAL_QLNV.Instance.GetAllAccount())
            {
                if (i.TenTaiKhoan.Equals(TenTaiKhoan))
                {
                    return i;
                }
            }
            return null;
        }
        
        public List<Account> GetAccountByAccountType(int AccountType)
        {
            List<Account> data = new List<Account>();
            if (AccountType == 2)
            {
                data = DAL_QLNV.Instance.GetAllAccount();
            }
            else
            {
                foreach (Account i in DAL_QLNV.Instance.GetAllAccount())
                {
                    if (i.LoaiTaiKhoan == AccountType)
                    {
                        data.Add(i);
                    }
                }
            }

            return data;
        }
      
        public List<NhanVien> GetListStaff(string ValueSort, string KeyWord)
        {
            List<NhanVien> data = new List<NhanVien>();
            List<NhanVien> data1 = new List<NhanVien>();
            data = GetAllStaff();
            if (ValueSort.Equals("1")) data.Sort(AscendingByStaff);
            if (ValueSort.Equals("2")) data.Sort(DescendingByStaff);

            foreach (NhanVien i in data)
            {
                if (i.TenNhanVien.Contains(KeyWord)) data1.Add(i);
            }
            return data1;
        }
      
       
     
        public List<NhanVien> GetAllStaff()
        {
            return DAL_QLNV.Instance.GetAllStaff();
        }
        
        
        public string GetNewStaffId()
        {
            int id = Convert.ToInt32(DAL_QLNV.Instance.GetMaximumStaffId().Substring(2, 3));
            id++;
            string res = "NV" + string.Format("{0:000}", id);
            return res;
        }
       
        public bool InsertStaff(NhanVien da)
        {
            if (da.TenNhanVien.Equals(""))
            {
                throw new InvalidOperationException("Chưa nhập tên nhân viên!!!");
            }
            if (da.SoDienThoai.Length <= 9)
            {
                throw new InvalidOperationException("Số điện thoại không hợp lệ!!!");
            }
            if (da.DiaChi.Equals(""))
            {
                throw new InvalidOperationException("Chưa nhập địa chỉ nhân viên!!!");
            }
            if (da.CMND.Length < 9)
            {
                throw new InvalidOperationException("Số CMND không hợp lệ!!!");
            }
            if (da.QueQuan.Equals(""))
            {
                throw new InvalidOperationException("Chưa nhập quê quán nhân viên!!!");
            }
            if (da.CaLamViec.Equals(""))
            {
                throw new InvalidOperationException("Chưa nhập ca làm việc!!!");
            }
            return DAL_QLNV.Instance.InsertStaff(da);
        }

        public bool UpdateStaff(NhanVien da)
        {
            if (da.TenNhanVien.Equals(""))
            {
                throw new InvalidOperationException("Chưa nhập tên nhân viên!!!");
            }
            if (da.SoDienThoai.Length <= 9)
            {
                throw new InvalidOperationException("Số điện thoại không hợp lệ!!!");
            }
            if (da.DiaChi.Equals(""))
            {
                throw new InvalidOperationException("Chưa nhập địa chỉ nhân viên!!!");
            }
            if (da.CMND.Length < 9)
            {
                throw new InvalidOperationException("Số CMND không hợp lệ!!!");
            }
            if (da.DiaChi.Equals(""))
            {
                throw new InvalidOperationException("Chưa nhập quê quán nhân viên!!!");
            }
            if (da.DiaChi.Equals(""))
            {
                throw new InvalidOperationException("Chưa nhập ca làm việc!!!");
            }
            return DAL_QLNV.Instance.UpdateStaff(da);
        }

       
        public bool DeleteStaff(List<string> ListDelete)
        {
            return DAL_QLNV.Instance.DeleteStaff(ListDelete);
        }
       
    }
}
