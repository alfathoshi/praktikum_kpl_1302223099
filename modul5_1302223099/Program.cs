internal class Program
{
    public class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T x, T y, T z)
        {
            dynamic tempx = x;
            dynamic tempy = y;
            dynamic tempz = z;
            dynamic total = tempx + tempy + tempz;
            Console.WriteLine("Total = " + total);
        }
    }
    private static void Main(string[] args)
    {
        Penjumlahan jumlah = new Penjumlahan();

        Console.Write("Angka 1 : ");
        long x = long.Parse(Console.ReadLine());
        Console.Write("Angka 2 : ");
        long y = long.Parse(Console.ReadLine());
        Console.Write("Angka 3 : ");
        long z = long.Parse(Console.ReadLine());

        jumlah.JumlahTigaAngka<long>(x, y, z);
    }
}