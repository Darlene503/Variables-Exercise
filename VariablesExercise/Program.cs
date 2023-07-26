namespace VariablesExercise
{

    public class Program
    {

        static void Main(string[] args)

        {
            string dogName = "Sir Dudley";
            int age = 9;
            char toys = '4';
            bool isUnder3 = false;
            double currentCostofDogfood = 42.99;
            decimal currentPriceofVetvisit = 52.50m;

            Console.WriteLine($"Dog Name:{dogName}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"Toys:{toys}");
            Console.WriteLine($"Is under 3:{isUnder3}");
            Console.WriteLine($"Current Cost Of dog food:{currentCostofDogfood}");
            Console.WriteLine($"Current Cost Of vet visit:{currentPriceofVetvisit}");


        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }

}