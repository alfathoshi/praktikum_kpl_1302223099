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
    public class SimpleDataBase<T>
    {
        private List<T> storedData = new List<T>();
        private List<DateTime> inputeDates = new List<DateTime>();
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputeDates = new List<DateTime>();
        }
        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputeDates.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]} yang disimpan pada waktu UTC: {inputeDates[i]}");
            }
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
        Console.WriteLine();

        SimpleDataBase<long> db = new SimpleDataBase<long>();
        db.AddNewData(x);
        db.AddNewData(y);
        db.AddNewData(z);
        db.PrintAllData();
    }
}