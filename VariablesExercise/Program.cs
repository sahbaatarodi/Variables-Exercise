namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Mooki";
            int dogAge = 1;
            char firstInitial = 'M';
            bool isHungry = true;
            double dogWeight = 12.5;
            decimal dogHeight = 9.7m;


            Console.WriteLine($"My dog's name is {dogName} and her initial is {firstInitial}. " +
                $" SHe is {dogAge} years old. SHe weighs {dogWeight} pounds," +
                $" and She is {dogHeight} inches long");
            Console.WriteLine($"It is {isHungry} that Mooki is always hungry.");

        }
    }
}
