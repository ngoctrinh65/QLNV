using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAL
{

    class DAL_QLNV
    {
        private static DAL_QLNV _Instance;
        public static DAL_QLNV Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_QLNV();
                return _Instance;
            }
            private set { }
        }

        private DAL_QLNV()
        {

        }
        public Account GetAccount(string TenTaiKhoan, string MatKhau)
        {
            Account data = null;
            string query = "USP_Login @TenTaiKhoan , @MatKhau";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TenTaiKhoan, MatKhau });
            if (result.Rows.Count > 0)
            {
                data = new Account(result.Rows[0]);
            }
            return data;
        }

   
       
        public List<NhanVien> GetAllStaff()
        {
            List<NhanVien> data = new List<NhanVien>();
            string query = "select * from NhanVien where HieuLuc = 1";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in dt.Rows)
            {
                NhanVien ca = new NhanVien(i);
                data.Add(ca);
            }
            return data;
        }
        public List<Account> GetAllAccount()
        {
            List<Account> data = new List<Account>();
            string query = "select * from DangNhap where HieuLuc = 1";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in dt.Rows)
            {
                Account ca = new Account(i);
                data.Add(ca);
            }
            return data;
        }
       
        public string GetMaximumStaffId()
        {
            string query = "select max(manhanvien) from NhanVien";
            string MaximumStaffId = "";
            try
            {
                MaximumStaffId = (string)DataProvider.Instance.ExecuteScalarQuery(query);
            }
            catch
            {
                MaximumStaffId = "NV000";
            }
            return MaximumStaffId;
        }
       
        public bool InsertStaff(NhanVien da)
        {
            string query = "exec USP_InsertStaff @TenNhanVien , @MaNhanVien , @SoDienThoai , @DiaChi , @CMND , @QueQuan , @CaLamViec , @HinhAnh";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { da.TenNhanVien, da.MaNhanVien, da.SoDienThoai, da.DiaChi, da.CMND, da.QueQuan, da.CaLamViec, da.HinhAnh });
            return result > 0;
        }
        
      
        public bool UpdateStaff(NhanVien da)
        {
            string query = "exec USP_UpdateStaff @TenNhanVien , @MaNhanVien , @SoDienThoai , @DiaChi , @CMND , @QueQuan , @CaLamViec , @HinhAnh";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { da.TenNhanVien, da.MaNhanVien, da.SoDienThoai, da.DiaChi, da.CMND, da.QueQuan, da.CaLamViec, da.HinhAnh });
            return result > 0;
        }
       
       
        
        public bool DeleteStaff(List<string> ListDelete)
        {
            string query = "USP_DeleteStaff @MaNhanVien";
            List<object[]> ListParameter = new List<object[]>();
            foreach (string i in ListDelete)
            {
                ListParameter.Add(new object[] { i });
            }
            int result = DataProvider.Instance.ExecuteNonQueryTransaction(query, ListParameter);
            return result > 0;
        }

    }
}
