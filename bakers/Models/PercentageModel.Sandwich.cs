public partial class PercentageModel
{
    public class Sandwich : PercentageModel
    {
        public override double FlourPercent { get => base.FlourPercent; set => base.FlourPercent = 100.0; }
        public override double WaterPercent { get => base.WaterPercent; set => base.WaterPercent = 63.0; }
        public override double YeastPercent { get => base.YeastPercent; set => base.YeastPercent = 1.2; }
        public override double SaltPercent { get => base.SaltPercent; set => base.SaltPercent = 1.0; }
        public override double SugarPercent { get => base.SugarPercent; set => base.SugarPercent = 3.5; }
        public override double OilPercent { get => base.OilPercent; set => base.OilPercent = 8.0; }
    }
}
