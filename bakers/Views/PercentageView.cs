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
