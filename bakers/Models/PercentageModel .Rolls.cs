public partial class PercentageModel
{
    public class Rolls : PercentageModel
    {
        public override double FlourPercent { get => base.FlourPercent; set => base.FlourPercent = value; }
        public override double WaterPercent { get => base.WaterPercent; set => base.WaterPercent = value; }
        public override double YeastPercent { get => base.YeastPercent; set => base.YeastPercent = value; }
        public override double SaltPercent { get => base.SaltPercent; set => base.SaltPercent = value; }
        public override double SugarPercent { get => base.SugarPercent; set => base.SugarPercent = value; }
        public override double OilPercent { get => base.OilPercent; set => base.OilPercent = value; }
        public Rolls()
        {
            FlourPercent = 100.0;
            WaterPercent = 60.0;
            YeastPercent = 2.3;
            SaltPercent = 1.3;
            SugarPercent = 10.0;
            OilPercent = 10.0;
        }
    }
}
