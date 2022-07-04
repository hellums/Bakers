public class PercentageView : IPercentageView
{
    public string? Input { get; set; }  
    public int? Mass { get; set; }
    public string? Bread { get; set; }
    public void GetValues(List<string> breadList)
    {
        Console.WriteLine("How many grams of dough do you need? (or 0 to exit)");
        Input = Console.ReadLine();
        Mass = Convert.ToInt32(Input);
        bool isValidBreadType = false;
        do
        {
            Console.WriteLine("\nAvailable bread types include:");
            foreach (string? style in breadList) { Console.WriteLine(style); }
            Console.WriteLine("\nWhat type of dough do you need? (or 0 to exit)");
            Bread = Console.ReadLine();
            if (Bread == "0") break;
            isValidBreadType = breadList.Contains(Bread);
            if (!(isValidBreadType))
            {
                Console.WriteLine("\nNot a valid bread type");
            }
        } while (!(isValidBreadType));
    }

    public void ShowResults()
    {
        Console.WriteLine("\nMaking: {0} grams of {1}", Mass, Bread);
    }
    public void ShowResults(IPercentageModel model)
    {
        Console.WriteLine("\nFlour: {0} Water: {1}", model.FlourAmount, model.WaterAmount);
    }

    public void ShowResults(double Mass, string Bread)
    {
        Console.WriteLine("\nAmount: {0} Style: {1}", Mass, Bread);
    }

}
