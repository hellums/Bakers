public partial class PercentageModel : IPercentageModel
{
    public int? Mass { get; set; }
    public string? Bread { get; set; }
    public double FlourAmount { get; set; }
    public double WaterAmount { get; set; }
    public double YeastAmount { get; set; }
    public double SaltAmount { get; set; }
    public double SugarAmount { get; set; }
    public double OilAmount { get; set; }
    public virtual double FlourPercent { get; set; } = 100;
    public virtual double WaterPercent { get; set; }
    public virtual double YeastPercent { get; set; }
    public virtual double SaltPercent { get; set; }
    public virtual double SugarPercent { get; set; }
    public virtual double OilPercent { get; set; }
    public List<string> breadList { get; set; } = new List<string>
        { "Ciabatta", "Focaccia", "Pizza", "Baguette", "Sandwich", "Buns" };

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
