int n;
double x, y;

Console.Write("How many terms do you want? ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value of X......: ");
x = Convert.ToDouble(Console.ReadLine());
y = Taylor(x, n);
Console.WriteLine("f(x) = {0}",y);
Console.ReadKey();  

double Taylor (double x, int n)
{
    double t, s = 0;
    for (int i = 0; i < n; i++)
    {
        t = Math.Pow(x,i)/Factorial(i);
        s += t;
    }
    return s;
}

double Factorial(int i)
{
    double factorial = i;
    if (factorial > 0)
    {
        for (int x = i - 1; x > 0; x--)
        {
            factorial = factorial * x;
        }
        return factorial;
    }
    else
    {
        for (int x = i + 1; x < 0; x++)
        {
            factorial = factorial * x;
        }
        return factorial;
    }

}