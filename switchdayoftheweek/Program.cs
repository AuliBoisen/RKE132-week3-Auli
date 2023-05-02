
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //vahemikus 0-6

switch(weekDay) //väärtus mida kontrollitakse
{
    case 0: //case 0 on tegelikult if kontrolliga ehk sama mis if(weekday == 0)
        Console.WriteLine("its sunday!");
        break;
    case 1:
        Console.WriteLine("its monday!");
        break;
    case 2:
        Console.WriteLine("its tuesday!");
        break;
    case 3:
        Console.WriteLine("its wednesday!");
        break;
    case 4:
        Console.WriteLine("its thursday!");
        break;
    case 5:
        Console.WriteLine("its friday!");
        break;
    case 6:
        Console.WriteLine("its saturday!");
        break;
    default:
        Console.WriteLine("oops your calender must be broken");
        break;
}
Console.WriteLine("have a nice day");