namespace _240321App;

class Program
{
    static void Main(string[] args)
    {
        string s = "Hello,C#,Hello";
        int a = s.IndexOf("el");
        int b = s.LastIndexOf("el");
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        
        Console.WriteLine(s[1]);
        //e[1] = 'E'; => 에러 가지고 오는 건 되지만 바꾸는건 불가능

        string s1 = s.ToUpper();
        Console.WriteLine(s1);
        Console.WriteLine(s);

        string url = "naver.com";
        
        if(url.StartsWith("http://"))
            Console.WriteLine(url);
        else
            Console.WriteLine("http://" + url);

        string str = "ABCDEFG";
        string str1 = str.Substring(3);
        string str2 = str.Substring(3,2);
        Console.WriteLine(str1); //DEFG
        Console.WriteLine(str2); //DE

        string spstr = "C#,Java,Python";
        string[] s2 = spstr.Split(',');
        for(int i = 0; i< s2.Length; i++)
        {
            Console.WriteLine(s2[i]);
        }

        string comp = "C#";

        if (s == "C#")
        {
            Console.WriteLine("같");
        }
        else
        {
            Console.WriteLine("다름");
        }
        
        

    }
}