using System;
using MyFirstProgram;

namespace my_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
       Human human1 = new("John", 25);
      
            human1.Eat();
    }
}

class Human
{
    public string name;
    public int age;

    public Human(String name, int age){
        this.name = name;
        this.age = age;
    }
    public void IntroduceYourself()
    {
        Console.WriteLine($"Hi, I'm {name} and I'm {age} years old.");
    }

    public void Think()
    {
        Console.WriteLine($"{name} is thinking about something important...");
    }

    public void Eat(){
        Console.WriteLine(name + " is eating");
    }

    public void Sleep(){
        Console.WriteLine(name + " is sleeping");
    }
}

}