// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter a number");
int usernum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int result = usernum % 2;
Console.WriteLine(result);

if (result != 0) //!= ei võrdu
{
    Console.WriteLine("user number is odd.");
}
else
{
    Console.WriteLine("user number is even.");
}