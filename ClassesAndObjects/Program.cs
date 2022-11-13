using System;

namespace ClassesAndObjects // Note: actual namespace depends on the project name.
{
  public class Person
  {
    public string Name;
    public int Age;
    public bool HasPet;

    public void Greeting()
    {
      Console.WriteLine("Hi! My name is " + Name + " and my age is " + Age);
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Person person = new Person();

      person.Name = "John";
      person.Age = 28;
      person.HasPet = true;

      person.Greeting();
    }
  }
}