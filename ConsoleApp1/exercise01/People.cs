namespace ConsoleApp1.exercise01;

public class People
{
    public string name { get; set; }
    public bool gender { get; set; }
    public int age { get; set; }

    public People()
    {
    }

    public People(string name, bool gender, int age)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
    }

    
}