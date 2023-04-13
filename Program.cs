

bool IsPalindrom(int number)
{
    bool isPalindrom = true;
    string palindrom = number.ToString();

    for (int i = 0; i < palindrom.Length; i++)
    {
       if (palindrom[i] != palindrom[palindrom.Length - 1 - i])
       {
        isPalindrom = false;
        break;
       }  
    }

    return isPalindrom;
}

System.Console.WriteLine("напишите что угодно");
Console.ReadLine();

int j = 12821;
System.Console.WriteLine(j);
System.Console.WriteLine(IsPalindrom(j));
int i = 23432;
System.Console.WriteLine(i);
System.Console.WriteLine(IsPalindrom(i));
int a = 14212;
System.Console.WriteLine(a);
System.Console.WriteLine(IsPalindrom(a));
