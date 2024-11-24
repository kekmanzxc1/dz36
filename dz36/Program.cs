using System;
//Завдання 1
//class Program
//{
//static void DrawSquare(int sideLength, char symbol)
//{
//for (int i = 0; i < sideLength; i++)
//{
//Console.WriteLine(new string(symbol, sideLength));
//        }
//    }
//
//static void Main()
//{
//DrawSquare(10, '*');
//    }
//}
//Завдання 2
//class Program
//{
//static bool Palindrome(int number)
//{
//string numStr = number.ToString();
//string Str = new string(numStr.Reverse().ToArray());
//
//return numStr == Str;
//    }

//static void Main()
//{
//Console.WriteLine(Palindrome(1221));
//Console.WriteLine(Palindrome(3443));
//Console.WriteLine(Palindrome(7854));
//    }
//}
//Завдання 4 
class Website
{
    private string name;
    private string url;
    private string description;
    private string ipAddress;

    public void SetData(string name, string url, string description, string ipAddress)
    {
        this.name = name;
        this.url = url;
        this.description = description;
        this.ipAddress = ipAddress;
    }

    public string GetName() => name;
    public void SetName(string name) => this.name = name;

    public string GetUrl() => url;
    public void SetUrl(string url) => this.url = url;

    public string GetDescription() => description;
    public void SetDescription(string description) => this.description = description;

    public string GetIpAddress() => ipAddress;
    public void SetIpAddress(string ipAddress) => this.ipAddress = ipAddress;

    public void DisplayInfo()
    {
        Console.WriteLine($"Site name: {name}");
        Console.WriteLine($"Website URL: {url}");
        Console.WriteLine($"Site description: {description}");
        Console.WriteLine($"IP address of the site: {ipAddress}");
    }
}

class Program
{
    static void Main()
    {
        Website website = new Website();

        website.SetData("My Site", "https://www.dota2.com/home?l=russian", "Test", "192.168.1.1");

        website.SetName("Updated test");
        Console.WriteLine($"Name after the update: {website.GetName()}");

        website.DisplayInfo();
    }
}
