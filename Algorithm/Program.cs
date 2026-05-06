public class Program
{
    public static void Main(string[] args)
    {
        var son = int.Parse(Console.ReadLine());
        //var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());
        

        Program p = new Program();
        //Console.WriteLine(p.Task1(son));
        //Console.WriteLine(p.Task2(son));
        //Console.WriteLine(p.Task3(son));
        //Console.WriteLine(p.Task4(son));
        //Console.WriteLine(p.Task5(son, b));
        //Console.WriteLine(p.Task6(son, b));
        //p.ThreeDigitNumber(son);
        //p.Repair(son, b);
        //p.FourDigitNumber(son);
        //Console.WriteLine(p.Number(son));
        //p.Three(son, b, c);
        //p.Grade(son);
        //Console.WriteLine(p.Symbol(son, "+", c));
        //p.Good(son);
        //p.Team(son, b);
        //p.Abs(son);
        //p.Triangle(son, b, c);
        
    }
    public int Task1(int a) => a * 5;
    public int Task2(int a) => (int)Math.Pow(a, 2);
    public int Task3(int a) => (int)Math.Pow(a, 2) * 6;
    public int Task4(int a) => (int)Math.Pow(a, 3);
    public int Task5(int a, int b) => 2*(a+b);
    public int Task6(int a, int b) => a*b;
    public void ThreeDigitNumber(int a)
    {
        var x = 0;
        for (int i=0; i<3; i++)
        {
            x = a % 10;
            Console.WriteLine(x);
            a = a / 10;
        }
    }
    public void Repair(int a, int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine(a + " " + b);
    }
    public void FourDigitNumber(int a)
    {
        
        var v = 0;
        var reverse = 0;
        bool b = true;
        while(b)
        {
            if (a > 0)
            {
                
                v = a % 10;
                a = a / 10;
                reverse = reverse * 10 + v;
            }
            else if (reverse > 0 && a == 0)
            {
                v = reverse % 10;
                Console.WriteLine(v);
                reverse = reverse / 10;
            }
            else b = false;
        }
    }
    public void Year(int month) => Console.WriteLine(month / 12);
    public int Number(int number) => number = (number % 10) * 10 + number / 10;
    public void Three(int a, int b, int c)
    {
        var x = c;
        c = b; b = a; a = x;
        Console.WriteLine(a+" "+b+" "+c);
    }
    public void Week(int a)
    {
        switch (a)
        {
            case 1: Console.WriteLine("Dushanba"); break;
            case 2: Console.WriteLine("Seshanba"); break;
            case 3: Console.WriteLine("Chorshanba"); break;
            case 4: Console.WriteLine("Payshanba"); break;
            case 5: Console.WriteLine("Juma"); break;
            case 6: Console.WriteLine("Shanba"); break;
            case 7: Console.WriteLine("Yakshanba"); break;
            default: Console.WriteLine("Bunday kun yo'q"); break;
        }
    }
    public void Grade(int ball)
    {
        switch (ball)
        {
            case > 80 and <= 100: Console.WriteLine("5"); break;
            case > 60 and <= 80: Console.WriteLine("4"); break;
            case > 40 and <= 60: Console.WriteLine("3"); break;
            case >= 20 and <= 40: Console.WriteLine("2"); break;
                default : Console.WriteLine("Bahosiz"); break ;
        }
    }  //with gpt
    public float Symbol(float a, string symbol, float b)
    {

        return symbol switch
        {
            ">" => a > b ? a : b,
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => a / b,
            _ => 0
        };
    }
    public void Good(int a) => Console.WriteLine(a % 3 == 0 && a % 6 != 0 ? "Good" : "Bad");
    public void Team(int a, int b) => Console.WriteLine(a % b == 0 || b % a == 0 ? "Chelsea" : "Liverpol");
    public int Abs(int a) => Math.Abs(a);
    //C7 switch case 
    //C8 switch case
    //C9 for switch case
    public void Triangle(int a, int b, int c) => Console.WriteLine(180 >= a + b + c ? "Mavjud" : "Yoq");
    public int If1(int a) => a > 0 ? ++a : a;
    public int If2(int a) => a > 0 ? ++a : a-=2;
    public int If3(int a)
    {
        if (a == 0) a = 10;
        else if (a > 0) a++;
        else a -= 2;
        return a;
    }
    public int If4(int a, int b, int c)
    {
        var sum = 0;
        for (int i = 0; i <= 3; i++)
        {
            if (a >= 0) sum++;
            if (b >= 0) sum++;
            if (c >= 0) sum++;
        }
        return sum;
        
    }
    public void If5(int a, int b, int c)
    {
        var sum = 0;
        for (int i = 0; i <= 3; i++)
        {
            if (a >= 0) sum++;
            if (b >= 0) sum++;
            if (c >= 0) sum++;
        }
        Console.WriteLine("Musbat:" + sum + "  Manfiy: " + (3 - sum));
    }
    public int If6(int a, int b) => a > b ? a : b;
    public int If7(int a, int b) => a > b ? 1 : 2;
    public void If8(int a, int b) => Console.WriteLine(a > b ? (b + "" + a) : (a + "" + b));
    public void If9(int a, int b)
    {
        if (a>b)
        {
            a = a * (-1);
            b = b * (-1);
        }
        Console.Write(a + " " + b);
    }
    public void If10(int a, int b)
    {
        if (a != b)
        {
            a = a + b;
            b = a;
        } 
        else
        {
            a = 0;
            b = 0;
        }
        Console.WriteLine(a + "" + b);
    }

}