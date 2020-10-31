//bai1_TH3

using System;

namespace Bai1_TH3
{
    class Phanso
    {
        private int ts, ms;
        public Phanso()
        {
            ts = 0; ms = 1;
        }

        public Phanso(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }

        public void Nhap()
        {
            Console.Write("Nhap tu so: "); ts = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: "); ms = int.Parse(Console.ReadLine());
        }

        public void Hien()
        {
            if (ms == 1) Console.WriteLine("{0}", ts);
            else
                Console.WriteLine("{0}/{1}", ts, ms);
        }

        public int Ucln(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }

        public Phanso ToiGian()
        {
            int uc = Ucln(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }

        public static Phanso operator +(Phanso t1, Phanso t2)
        {
            Phanso tong = new Phanso();
            tong.ts = t1.ts * t2.ms + t2.ts * t1.ms;
            tong.ms = t2.ms * t1.ms;
            tong.ToiGian();
            return tong;
        }

        public Phanso Cong(Phanso b)
        {
            Phanso tong = new Phanso();
            tong.ts = this.ts * b.ms + b.ts * this.ms;
            tong.ms = this.ms + b.ms;
            tong.ToiGian();
            return tong;
        }

        public static Phanso operator -(Phanso t1, Phanso t2)
        {
            Phanso tru = new Phanso();
            tru.ts = t1.ts * t2.ms - t2.ts * t1.ms;
            tru.ms = t2.ms * t1.ms;
            tru.ToiGian();
            return tru;
        }

        public Phanso Tru(Phanso b)
        {
            Phanso tru = new Phanso();
            tru.ts = this.ts * b.ms - b.ts * this.ms;
            tru.ms = this.ms + b.ms;
            tru.ToiGian();
            return tru;
        }
    }

    class App
    {
        static void Main1_3()
        {
            Phanso t1 = new Phanso();
            Phanso t2 = new Phanso();
            Console.WriteLine("Tong 2 phan so");
            Phanso tTong = t1.Cong(t2); tTong.Hien();
            Console.WriteLine("Hieu 2 phan so");
            Phanso tHieu = t1.Tru(t2); tHieu.Hien();


        }
    }


    //bai3_TH3
       
    using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3_TH3
    {
        class Time
        {
            private int gio, phut, giay;

            public Time()
            {
                gio = 0;
                phut = 0;
                giay = 0;
            }

            public Time(int gio, int phut, int giay)
            {
                this.gio = gio;
                this.phut = phut;
                this.giay = giay;
            }

            public int Gio
            {
                get
                {
                    return gio;
                }
                set
                {
                    gio = value;
                }
            }

            public int Phut
            {
                get
                {
                    return phut;
                }
                set
                {
                    phut = value;
                }
            }

            public int Giay
            {
                get
                {
                    return giay;
                }
                set
                {
                    giay = value;
                }
            }

            public void Hien()
            {
                Console.WriteLine("{0}:{1}:{2}", gio, phut, giay);
            }

            public int normalize(int gio, int phut, int giay)
            {
                phut = giay / 60;
                giay = giay % 60;
                gio = phut / 60;
                phut = phut % 60;
                gio = gio % 24;

                return gio; return phut; return giay;
            }

            public Time advance(int gio, int phut, int giay)
            {
                Time t = new Time();
                t.gio = this.gio + gio;
                t.phut = this.phut + phut;
                t.giay = this.giay + giay;

                t.phut = giay / 60;
                t.giay = giay % 60;
                t.gio = phut / 60;
                t.phut = phut % 60;
                t.gio = gio % 24;
                return t;
            }
        }
    }


    //bai4_TH3

    using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4_TH3
    {
        class HocSinh
        {
            private string hoten;
            private double diemtoan, diemli, diemhoa;

            public HocSinh()
            {
                hoten = "";
                diemtoan = diemli = diemhoa = 0;
            }

            public HocSinh(string hoten, double diemtoan, double diemli, double diemhoa)
            {
                this.hoten = hoten;
                this.diemtoan = diemtoan;
                this.diemli = diemli;
                this.diemhoa = diemhoa;
            }

            public void Nhap()
            {
                Console.Write("Nhap ho ten: ");
                hoten = Console.ReadLine();
                Console.Write("Nhap diem toan: ");
                diemtoan = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem li: ");
                diemli = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem hoa: ");
                diemhoa = double.Parse(Console.ReadLine());
            }

            public virtual void Hien()
            {
                Console.WriteLine("Ho ten: " + hoten);
                Console.WriteLine("Diem toan: " + diemtoan);
                Console.WriteLine("Diem li: " + diemli);
                Console.WriteLine("Diem hoa: " + diemhoa);
            }

        }

        class QL
        {
            private HocSinh[] dshs;
            private int shs;
            public void Nhap()
            {
                Console.Write("Nhap so hoc sinh: ");
                shs = int.Parse(Console.ReadLine());
                dshs = new HocSinh[shs];
                for (int i = 0; i < shs; i++)
                {
                    dshs[i] = new HocSinh();
                    dshs[i].Nhap();
                }
            }

            public void Hien()
            {
                for (int i = 0; i < shs; i++)
                    dshs[i].Hien();
            }

        }

        class Ap
        {
            static void Main4_3(string[] args)
            {
                QL t = new QL();
                t.Nhap();
                t.Hien();
                Console.ReadLine();
            }
        }
    }


    //bai1_TH4

    using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1_TH4
    {
        class MaTran
        {
            private static int n;
            private int[,] a;

            public MaTran()
            {
                n = 2;
                a = new int[n, n];
            }

            public static int N
            {
                get
                {
                    return n;
                }
                set
                {
                    if (value >= 2) n = value;
                }
            }

            public void Nhap()
            {
                Console.WriteLine("Nhap thong tin cho cac phan tu cua ma tran");
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("a[{0},{1}] = ", i, j);
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
            }

            public void Hien()
            {
                Console.WriteLine("Cac phan tu cua ma tran la");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write("{0}\t", a[i, j]);
                    Console.WriteLine();
                }
            }

            public MaTran Tong(MaTran t2)
            {
                MaTran t = new MaTran();

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        t.a[i, j] = this.a[i, j] + t2.a[i, j];
                return t;

            }

            class QLMT
            {
                private MaTran[] ds;
                private int somt;

                public void Nhap()
                {
                    Console.Write("Nhap cap ma tran: ");
                    MaTran.N = int.Parse(Console.ReadLine());
                    Console.Write("Nhap so ma tran: ");
                    somt = int.Parse(Console.ReadLine());
                    ds = new MaTran[somt];
                    for (int i = 0; i < somt; i++)
                    {
                        Console.WriteLine("Nhap ma tran thu " + i);
                        ds[i] = new MaTran();
                        ds[i].Nhap();
                    }
                }

                public MaTran Tong()
                {
                    MaTran t = new MaTran();
                    for (int i = 0; i < somt; i++)
                        t = t.Tong(ds[i]);
                    return t;
                }
            }
            class Test
            {
                static void Main1_4(string[] args)
                {
                    QLMT t = new QLMT();
                    t.Nhap();
                    Console.WriteLine("Ma tran tong");
                    t.Tong().Hien();
                    Console.ReadLine();
                }
            }
        }
