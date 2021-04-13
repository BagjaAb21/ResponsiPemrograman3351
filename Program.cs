using System;

namespace ResponsiPemrograman3351

{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karr1 = new Karyawan(190302123, "Paijo", 3300000);
            Karyawan karr2 = new Karyawan(190302124, "Jono", 2200000);

            Karyawan.Show(karr1, karr2);
            Karyawan.NaikGaji(karr1, karr2);
            Karyawan.Show(karr1, karr2);
        }
    }
}
