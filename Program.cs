class Program
{
    public static void Main(){
        var peter = new Person();
        peter.Name = "Peter";
        var john = peter;
        peter.Name = "John";
        peter.PrintData();
        john.PrintData();
    }
}
