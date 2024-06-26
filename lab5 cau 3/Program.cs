using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_cau_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVienIT SvIT = new SinhVienIT();
            SvIT.nhap();
            SvIT.xuat();

            SinhVienBiz SvBiz = new SinhVienBiz();
            SvBiz.nhap();
            SvBiz.xuat();

            Console.ReadLine();

        }
    }

    public abstract class SinhVienPoly
    {
        public string HoTen {  get; set; }
        public string nganh {  get; set; }


        public abstract double getdiem();
        public string GetHocLuc()
        {
            double diem = this.getdiem();
            if (diem < 5)
            {
                return "Yếu";
            }
            else if (diem < 6.5)
            {
                return "Trung bình";
            }
            else if (diem < 7.5)
            {
                return "Khá";
            }
            else if (diem < 9)
            {
                return "Giỏi";
            }
            else
            {
                return "Xuất sắc";
            }
        }
        public void nhapSvIT()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Nhap thong tin Sinh Vien IT");
            Console.WriteLine("Nhap ten: ");
            this.HoTen = Console.ReadLine();

            Console.WriteLine("Nhap nganh: ");
            this.nganh = Console.ReadLine();
            Console.WriteLine("-----------------------------");

        }
        public void nhapSvBiz()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Nhap thong tin Sinh Vien Biz");
            Console.WriteLine("Nhap ten: ");
            this.HoTen = Console.ReadLine();

            Console.WriteLine("Nhap nganh: ");
            this.nganh = Console.ReadLine();
            

        }
        public void xuat()
        {
            Console.WriteLine("Ho ten:{0} ",this.HoTen);
            Console.WriteLine("Nganh: {0}", this.nganh);
            Console.WriteLine("Diem: {0}",this.getdiem());
            Console.WriteLine("Hoc luc: {0}", this.GetHocLuc());
        }
    }
    public class SinhVienIT : SinhVienPoly
    {
        public double diemJava { get; set; }
        public double diemHTML { get; set; }
        public double diemCSS { get; set; }

        public override double getdiem()
        {
            return (2 * diemJava + diemHTML + diemCSS) / 4;
        }

        public new void nhap()
        {
            base.nhapSvIT();
            Console.WriteLine("Nhap diem Java: ");
            this.diemJava = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem HTML: ");
            this.diemHTML = double.Parse(Console.ReadLine());   

            Console.WriteLine("Nhap diem CSS: ");
            this.diemCSS = double.Parse(Console.ReadLine());    
        }

    }
    class SinhVienBiz : SinhVienPoly
    {
        public double DiemMarKeting { get; set; }

        public double DiemSales {  get; set; }

        public override double getdiem()
        {
            return (2 * DiemMarKeting + DiemSales) / 3;
        }

        public new void nhap()
        {
            base.nhapSvBiz();
            Console.WriteLine("Nhap diem Marketing: ");
            this.DiemMarKeting = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Sales: ");
            this.DiemSales = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");
        }
    }
}
