using System.Text;

DateTime Date1;
DateTime Date2;
TimeSpan DateDif;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Input first date in format YYYY-MM-DD");

while (!DateTime.TryParse(Console.ReadLine(), out Date1))
{
    Console.WriteLine("Invalid date format.Try again!");

}
Console.WriteLine(Date1.ToLongDateString());

Console.WriteLine("Input second date in format YYYY-MM-DD");


while (!DateTime.TryParse(Console.ReadLine(), out Date2))
{
    Console.WriteLine("Invalid date format.Try again!");

}
Console.WriteLine(Date2.ToLongDateString());


DateDif = DateExtract(Date1, Date2);

Console.WriteLine($"Difference in dates is days:{DateDif}");

TimeSpan DateExtract(DateTime d1, DateTime d2)
{
    return d1 - d2;
}

