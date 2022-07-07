public partial class PercentageModel
{
    public class Baguette : PercentageModel
    {
        public override double FlourPercent { get => base.FlourPercent; set => base.FlourPercent = value; }
        public override double WaterPercent { get => base.WaterPercent; set => base.WaterPercent = value; }
        public override double YeastPercent { get => base.YeastPercent; set => base.YeastPercent = value; }
        public override double SaltPercent { get => base.SaltPercent; set => base.SaltPercent = value; }
        public override double SugarPercent { get => base.SugarPercent; set => base.SugarPercent = value; }
        public override double OilPercent { get => base.OilPercent; set => base.OilPercent = value; }
        public Baguette()
        {
            FlourPercent = 100.0;
            WaterPercent = 66.0;
            YeastPercent = 1.25;
            SaltPercent = 2.0;
            SugarPercent = 0.0;
            OilPercent = 0.0;
        }
    }
}
