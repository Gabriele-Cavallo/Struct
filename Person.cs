struct Person
{
    public string Name {get; set;}
    public string LastName {get; set;}
    public byte Age {get; set;}

    public void PrintData(){
        Console.WriteLine($"{Name}, {LastName}, {Age}");
    }
}
