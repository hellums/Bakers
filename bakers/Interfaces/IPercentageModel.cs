public interface IPercentageModel
{
    public int Mass { get; set; }
    public string Bread { get; set; }
    public double FlourAmount { get; set; }
    public double WaterAmount { get; set; }
    public double YeastAmount { get; set; }
    public double SaltAmount { get; set; }
    public double SugarAmount { get; set; }
    public double OilAmount { get; set; }
    public void CalculateRatio()
    {
    }
}