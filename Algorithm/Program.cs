using Algorithm;

public class Program
{
    public static void Main(string[] args)
    {
        //var son = int.Parse(Console.ReadLine());
        //var b = int.Parse(Console.ReadLine());
        //var c = int.Parse(Console.ReadLine());
        //var a = int.Parse(Console.ReadLine());
        LeetCode leet = new LeetCode();

        string[] strs = ["flower", "flower", "flower", "flower"];
        Console.WriteLine(leet.LongestCommonPrefix(strs));
    }
    
}