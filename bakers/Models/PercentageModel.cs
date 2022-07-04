public class PercentageModel : IPercentageModel
{
    public int? Mass { get; set; }
    public string? Bread { get; set; }
    public double FlourAmount { get; set; }
    public double WaterAmount { get; set; }
    public List<string> breadList { get; set; } = new List<string>
        { "Ciabatta", "Focaccia", "Sandwich", "Pizza", "Buns" };

public void CalculateRatio()
    {
        FlourAmount = (double)(Mass * 0.6);
        WaterAmount = (double)(Mass * 0.4);
    }
}
