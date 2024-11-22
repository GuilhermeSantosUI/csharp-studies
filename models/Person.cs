namespace LearningApp.models;

public class Person(int id, string name, int age, string email)
{
    private int Id { get; set; } = id;
    private string Name { get; set; } = name;
    private int Age { get; set; } = age;
    private string Email { get; set; } = email;

    public void Print()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}, Email: {Email}");
    }
}