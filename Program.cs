int Read(string argument)
{
    int number;
    System.Console.WriteLine($"input {argument}: ");
    while((!int.TryParse(Console.ReadLine(), out number)))
    {
        System.Console.WriteLine("not a number!");
    }
    return number;
}

double Leght()
{
    int x1 = Read("x1");
    int x2 = Read("x2");
    int x3 = Read("x3");
    int y1 = Read("y1");
    int y2 = Read("y2");
    int y3 = Read("y3");
    double Lenght = Math.Sqrt(Math.Pow(x1 - x2 - x3, 2) + Math.Pow(y1 - y2 - y3, 2));
    return Lenght;
}

void Answer()
{
    double L = Leght();
    System.Console.WriteLine($"Segment leght = {L}");

}

Answer();
