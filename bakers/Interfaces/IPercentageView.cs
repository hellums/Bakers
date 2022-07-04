public interface IPercentageView
{
    public string? Input { get; set; }
    public int? Mass { get; set; }
    public string? Bread { get; set; }
    public void GetValues(List<string> breadList)
    {
    }
    public void ShowResults()
    {
    }
    public void ShowResults(IPercentageModel model)
    {
    }
    public void ShowResults(double Mass, string Bread)
    {
    }
}