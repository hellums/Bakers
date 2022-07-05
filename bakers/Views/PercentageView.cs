public class PercentageView : IPercentageView
{
    public bool userSelectedExit { get; set; } = false;
    public int? Mass { get; set; }
    public string? Bread { get; set; }
    public void GetValues(PercentageModel model, List<string>breadList)
    {
        Mass = GetDoughAmount();
        userSelectedExit = (Mass == 0);
        bool isValidBreadType = false;
        if (!userSelectedExit) do
            {
                Console.WriteLine("\nAvailable bread types include:");
                foreach (string? style in breadList) { Console.WriteLine(style); }
                Console.WriteLine("\nWhat type of dough do you need? (or 0 to exit)");
                Bread = Console.ReadLine();
                if (Bread == "0") userSelectedExit = true;
                if (userSelectedExit) break;
                isValidBreadType = breadList.Contains(Bread);
                if (!isValidBreadType) Console.WriteLine("\nNot a valid bread type");
            } while (!(isValidBreadType));
    }

    private int GetDoughAmount()
    {
        int Number;
        bool isInteger = true;
        do
        {
            Console.WriteLine("How many grams of dough do you need? (or 0 to exit)");
            isInteger = Int32.TryParse(Console.ReadLine(), out Number);
            if (Number < 0 || !isInteger) Console.WriteLine("\nInvalid amount of dough\n");
        } while ((Number < 0) || !(isInteger));
        return (int)Number;
    }
    public void ShowResults(IPercentageModel model)
    {
        Console.WriteLine("\nFor {0} grams of {1}:", model.Mass, model.Bread);
        Console.WriteLine("---------------------------");
        Console.WriteLine("Flour: {0}", (int)model.FlourAmount);
        Console.WriteLine("Water: {0}", (int)model.WaterAmount);
        Console.WriteLine("Yeast: {0}", (int)model.YeastAmount);
        Console.WriteLine("Salt: {0}", (int)model.SaltAmount);
        Console.WriteLine("Sugar: {0}", (int)model.SugarAmount);
        Console.WriteLine("Oil/butter/fat: {0}\n", (int)model.OilAmount);
    }
}
