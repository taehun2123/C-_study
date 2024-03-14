namespace ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        int a = 123;
        int b = 0b1111;
        int c = 0xff;
        int i1 = 2_147_483_647; //실행됨
        long l1 = 1234567890123456789L;
        double ad = 3.14D;
        float bd = 3.14F;
        decimal d = 3.14M;
        double cd = 3.14;
        //float f1 = 3.14; //오류 
        //decimal f2 = 3.14; //오류
        double d1 = 3.14F;
        float f3 = 100;
        double f4 = 100;
        System.Int32 iVal = 123;
        Console.WriteLine("컴퓨터IT학부 2312008 김태훈");
        Console.WriteLine(a);
        Console.WriteLine(iVal);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(i1);
        Console.WriteLine(l1);
        Console.WriteLine(d);

        const int kk = 100;
        //kk = 200; err
    }
}