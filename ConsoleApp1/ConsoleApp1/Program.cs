// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
string a = "100";
string b = "123.456";

int aa = int.Parse(a);
double bb = double.Parse(b);

int c;
int.TryParse(a, out c);

Console.WriteLine(aa + bb);
Console.WriteLine(c + 1);
Console.WriteLine(Convert.ToInt32(a) + 1);
Console.WriteLine("{0} {0}", aa,bb);
Console.WriteLine($"{aa} {bb}");
Console.WriteLine("a={0} b={1}", aa,bb);
Console.WriteLine($"a={aa}, b={bb}");
Console.WriteLine("{0, 10}", aa); //10자리만큼 앞에 공백을 채워 aa를 표기하시오
Console.WriteLine("{0, -10}", aa); //10자리만큼 뒤에 공백을 채워 aa를 표기하시오

int ab = 25555928;

Console.WriteLine("{0:D}", ab); //10진수로 표현
Console.WriteLine("{0:X}", ab); //FF (16진수로 표현)

Console.WriteLine("{0:N}", ab); //1000자릿수 단위로 끊어줌
Console.WriteLine("{0:F}", ab); //소숫점 2자리로 출력함 .00
Console.WriteLine("{0:N0}", ab); //1000자릿수 단위로 끊어줌 0을 붙이면 소수점이 출력이 안댐
Console.WriteLine("{0:F0}", ab); //0을 붙이면 소수점이 출력이 안댐
Console.WriteLine("{0:N5}", ab); //5때문에 소수점 5개를 붙여서 출력함
