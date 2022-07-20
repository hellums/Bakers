using Logger = bakers.Models.Logger.Logger;

public class PercentageView : IPercentageView
{
    public bool userSelectedExit { get; set; } = false;
    public int Mass { get; set; } = 0;
    public string? Bread { get; set; } = "";
    public void GetValues(PercentageModel model, List<string>breadList)
    {
        var logger = new Logger();
        Mass = GetDoughAmount();
        userSelectedExit = (Mass == 0);
        bool isValidBreadType;
        if (!userSelectedExit) do
            {
                Console.WriteLine("\nAvailable bread types include:");
                foreach (string? style in breadList) { Console.WriteLine(style); }
                Console.Write("\nWhat type of dough do you need (or 0 to exit)? ");
                
                Bread = Console.ReadLine();
                if (Bread == "0") userSelectedExit = true;
                if (userSelectedExit) break;
                if (Bread == null) Bread = "Sandwich"; //failover to sandwich if needed
                Bread = Bread.ToLower();
                isValidBreadType = breadList.Contains(Bread);
                if (!isValidBreadType)
                {
                    logger.Log("user entered invalid bread type: " + Bread);
                    Console.WriteLine("\nNot a valid bread type");
                }
                    
            } while (!(isValidBreadType));
    }

    private int GetDoughAmount()
    {
        var logger = new Logger();
        int Number;
        bool isInteger = true;
        do
        {
            Console.Write("\nHow many grams of dough do you need (or 0 to exit)? ");
            isInteger = Int32.TryParse(Console.ReadLine(), out Number);
            if (Number < 0 || !isInteger)
            {
                logger.Log("user entered invalid dough amount: " + Number);
                Console.WriteLine("\nInvalid amount of dough\n");
            }
        } while ((Number < 0) || !(isInteger));
        return (int)Number;
    }
    public void ShowResults(IPercentageModel model)
    {
        Console.WriteLine("\n  For {0} grams of {1}:", model.Mass, model.Bread);
        Console.WriteLine("  ---------------------------");
        Console.WriteLine("  flour: {0}", (int)model.FlourAmount);
        Console.WriteLine("  water: {0}", (int)model.WaterAmount);
        if ((int)model.YeastAmount > 0) Console.WriteLine("  yeast: {0}", (int)model.YeastAmount);
        if ((int)model.SaltAmount > 0) Console.WriteLine("  salt: {0}", (int)model.SaltAmount);
        if ((int)model.SugarAmount > 0) Console.WriteLine("  sugar: {0}", (int)model.SugarAmount);
        if ((int)model.OilAmount > 0) Console.WriteLine("  oil/butter/fat: {0}", (int)model.OilAmount);
    }

    public void Goodbye()
    {
        Console.WriteLine("\nDon't have a good day. Have a GREAT day!");
    }
}
