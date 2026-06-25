using System ;
namespace MyAplication
{
    class Student
    {
        public string name;
        public int age;
        public void display()
        {
            Console.WriteLine($"My name is : {name} and my age is : {age} years old");
        }
        static void Main(string[] args)
        {
            Student student1= new Student();
            student1.name="Murad";
            student1.age=25;

            Student student2= new Student();
            student2.name="Adiba Rahaman";
            student2.age=23;


            student1.display();
            student2.display();
        }
    }
}