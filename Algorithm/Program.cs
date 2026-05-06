public class Program
{
    public static void Main(string[] args)
    {
        var son = int.Parse(Console.ReadLine());
        

        Program p = new Program();
        //Console.WriteLine(p.Task1(son));
        //Console.WriteLine(p.Task2(son));
    }
    public int Task1(int a) => a * 5;
    public int Task2(int a) => (int)Math.Pow(a, 2);
}