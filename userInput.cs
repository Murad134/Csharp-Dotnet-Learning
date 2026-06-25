// Console.WriteLine("Please enter your name:");
// string name = Console.ReadLine();
// Console.WriteLine("Hello, " + name + "! Welcome to C# programming.");



/* Math
Console.WriteLine(Math.Max(10,5));
Console.WriteLine(Math.Min(10,5));
double ans=Math.Sqrt(65);
Console.WriteLine(ans);
/*


/* String

string firstName = "Murad";
string lastName = "Hosen Munna";
string fullName =string.Concat(firstName+" "+lastName);
Console.WriteLine(fullName);

firstName = firstName.ToUpper();
Console.WriteLine(firstName);
lastName = lastName.ToLower();
Console.WriteLine(lastName);

*/




/*

string fst = "Murad";
string lst = "Hosen Munna";
string name = $"My name is : {fst} {lst}";
Console.WriteLine(name);

*/

/*
string myString = "Hello, World!";
Console.WriteLine(myString[3]);
*/


/*
int x=10;
int y=5;
Console.WriteLine(x>y);
*/


/*if-else

int time =20;
string result = (time<18) ? "Good day." : "Good evening.";
Console.WriteLine(result);

*/


/*Switch


*/




/*

int day = 3;
switch (day)
{
    case 1:
        Console.WriteLine("Monday"); break;
    case 2:
        Console.WriteLine("Tuesday"); break;
    case 3:
        Console.WriteLine("Wednesday"); break;
    case 4:
        Console.WriteLine("Thursday"); break;
}

*/





/*Array

int[] arr = { 1, 2, 3, 4, 5 };
Array.Reverse(arr);
foreach (int i in arr)
{
    Console.WriteLine(i);
}
*/

string[] names = { "Murad", "Hosen", "Munna" };
Array.Sort(names);
foreach (string name in names)
{
    Console.WriteLine(name);
}