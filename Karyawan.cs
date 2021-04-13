using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrograman3351
{
    class Karyawan
    {
        int identitas { get; set; }
        String Nama { get; set; }
        int Gaji { get; set; }

        public Karyawan(int identitas, string Nama, int Gaji)
        {
            if (Gaji < 0)
            {
                this.Gaji = 0;
            }
            else
            {
                this.Gaji = Gaji;
            }

            this.identitas = identitas;
            this.Nama = Nama;
        }

        public static void NaikGaji(Karyawan obj1, Karyawan obj2)
        {
            Console.WriteLine("");
            Console.WriteLine("Alhamdulillah dapat kenaikan gaji 10%!");
            Console.WriteLine("");
            obj1.Gaji += obj1.Gaji * 10/100;
            obj2.Gaji += obj2.Gaji * 10/100;

        }
        public static void Show(Karyawan obj1, Karyawan obj2)
        {
            Console.WriteLine("No Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("1  {0} {1}\t{2}", obj1.identitas, obj1.Nama, obj1.Gaji);
            Console.WriteLine("2  {0} {1}\t{2}", obj2.identitas, obj2.Nama, obj2.Gaji);

        }
    }
}
