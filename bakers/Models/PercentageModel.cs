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
        FlourAmount = (double)(Mass / TotalPercent);
        WaterAmount = (double)(FlourAmount * (WaterPercent/100));
        YeastAmount = (double)(WaterAmount * (YeastPercent/100));
        SaltAmount = (double)(SaltAmount * (SaltPercent/100));
        SugarAmount = (double)(SugarAmount * (SugarPercent/100));
        OilAmount = (double)(OilAmount * (OilPercent/100));
    }
}
