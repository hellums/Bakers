public partial class PercentageModel : IPercentageModel
{
    public int Mass { get; set; } = 0;
    public string Bread { get; set; } = "";
    public double FlourAmount { get; set; } = 0.0;
    public double WaterAmount { get; set; } = 0.0;
    public double YeastAmount { get; set; } = 0.0;
    public double SaltAmount { get; set; } = 0.0;
    public double SugarAmount { get; set; } = 0.0;
    public double OilAmount { get; set; } = 0.0;
    public virtual double FlourPercent { get; set; } = 100.0;
    public virtual double WaterPercent { get; set; } = 0.0;
    public virtual double YeastPercent { get; set; } = 0.0;
    public virtual double SaltPercent { get; set; } = 0.0;
    public virtual double SugarPercent { get; set; } = 0.0;
    public virtual double OilPercent { get; set; } = 0.0;
    public List<string> breadList { get; set; } = new List<string>
        { "ciabatta", "focaccia", "pizza", "baguette", "sandwich", "buns", "rolls", "dumplings"};

    public void CalculateRatio()
    {
        double TotalPercent = (FlourPercent + WaterPercent + YeastPercent + SaltPercent + SugarPercent + OilPercent) / 100;
        FlourAmount = Math.Ceiling((double)(Mass / TotalPercent)); //round up to nearest whole number
        WaterAmount = Math.Ceiling((double)(FlourAmount * (WaterPercent/100)));
        YeastAmount = Math.Ceiling((double)(FlourAmount * (YeastPercent/100)));
        SaltAmount = Math.Ceiling((double)(FlourAmount * (SaltPercent/100)));
        SugarAmount = Math.Ceiling((double)(FlourAmount * (SugarPercent/100)));
        OilAmount = Math.Ceiling((double)(FlourAmount * (OilPercent/100)));
    }
}
