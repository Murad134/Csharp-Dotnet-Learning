// using System;
// class Car
// {
//     string color = "Red";
//     string model = "Mustang";
//     static void Main(string[] args)
//     {
//         Car myobj=new Car();
//         Console.WriteLine(myobj.color);
//         Car myobj2=new Car();
//         Console.WriteLine(myobj2.model);
//     }
// }


// using System;
// class Car
// {
//     string color = "Blue";
//     string model = "BMW";
//     static void Main(string[] args)
//     {
//         Car fst = new Car();
//         Car snd = new Car();
//         Console.WriteLine(fst.color);
//         Console.WriteLine(snd.model);
//     }
// }



using System;
class MyAplication
{
    class Car
    {
        string color = "Red";
        int mxSpeed = 200;
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.mxSpeed);
        }
    }
}