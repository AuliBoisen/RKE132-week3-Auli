//pühapäev on esimene päev ja ta on 0

using System.Runtime.CompilerServices;

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if(weekDay==0)
{
    Console.WriteLine("its sunday!);
}
else if (weekDay == 1)
{
    Console.WriteLine("its monday!");
}
 else if (weekDay == 2)
{
    Console.WriteLine(ˇ"its tuesday!");
}
 else if (weekDay == 3)
{
    Console.WriteLine("its wednesday!");
}
 else if (weekDay == 4)
{
    Console.WriteLine(ˇ"its thursday!");
}
 else if (weekDay == 5)
{
    Console.WriteLine(ˇ"its friday!");
}
 else (weekDay == 6)
{
    Console.WriteLine(ˇ"its saturday!");
}
