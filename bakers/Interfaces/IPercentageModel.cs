public interface IPercentageModel
{
    public int? Mass { get; set; }
    public string? Bread { get; set; }
    public double FlourAmount { get; set; }
    public double WaterAmount { get; set; }

    public void CalculateRatio()
    {
    }

}