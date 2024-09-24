internal class Program
{
    private static void Main(string[] args)
    {
       // Console.WriteLine("Please enter your name:");
       // string name = Console.ReadLine();
       // Console.WriteLine("Please enter your age?");
       // int age = Convert.ToInt32(Console.ReadLine());
       // int newage = age + 5;
        // Console.WriteLine("Hello" + " " + name + "," + " " + "you will be" + " " + newage + " " + "in 5 years");
    }


    public static int Agecheck(string[] args)
    {
        Console.WriteLine("Please enter your age?");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age > 13)
        {
            Console.WriteLine("You are" + " " + age + "years old, you are a child");
        }
        else if (age >= 13 && age <= 18) 
        {
            Console.WriteLine("You are" + " " + age + "years old, you are a teenager");

        }
        else if (age >= 19 &&  110) // cant get this line to work
        {

}