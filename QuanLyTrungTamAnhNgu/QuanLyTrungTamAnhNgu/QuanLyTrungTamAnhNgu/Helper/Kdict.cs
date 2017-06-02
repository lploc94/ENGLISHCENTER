using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamAnhNgu.Helper
{
    public class Kdict
    {
        static Dictionary<string, string> nameHolder = new Dictionary<string, string>();

        

        static Kdict instance = null;

        // Phải khởi tạo 1 thằng như này lúc khởi động chương trình
        public Kdict()
        {
            instance = this;

            InitDict();
        }

        void InitDict()
        {
            // nợ học phí
            nameHolder["MAHV"] = "Mã học viên";
            nameHolder["MALOP"] = "Mã lớp";
            nameHolder["SOTIENDADONG"] = "Đã đóng";
            nameHolder["SOTIENCONNO"] = "Còn nợ";
            nameHolder["NGAYDONG"] = "Ngày đóng";

            nameHolder["HOTEN"] = "Họ và tên";
            nameHolder["DIEMGK"] = "Điểm giữa kỳ";
            nameHolder["DIEMCK"] = "Điểm cuối kỳ";
            nameHolder["TONGDIEM"] = "Tổng điểm";

            nameHolder["MAGV"] = "Mã GV";
            nameHolder["TENGV"] = "Họ và tên";
            nameHolder["HESO"] = "Hệ số";
            nameHolder["NGAYNHAN"] = "Ngày nhận";
            nameHolder["LUONGCB"] = "Lương cơ bản";
            nameHolder["LUONG"] = "Lương thực lãnh";
        }

        public static string Get(string a)
        {
            if(nameHolder.ContainsKey(a))
            {
                return nameHolder[a];
            }

            // nếu ko chứa key a thì trả về a luôn :v
            return a;
        }

        public static void Set(string a, string b)
        {
            nameHolder[a] = b;
        }


    }
}
