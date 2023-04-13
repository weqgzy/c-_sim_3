Number();

int Read()
{
    System.Console.WriteLine("введите число");
    int N = int.Parse(Console.ReadLine());
    return N;
}

void Number()
{
    int n = 1;
    int N = Read();
     while (n <= N)
     {
        double d = Math.Pow(n , 3);
        System.Console.Write(d+" ");
        n++;
     }
}