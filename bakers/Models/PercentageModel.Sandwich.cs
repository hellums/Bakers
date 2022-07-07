public partial class PercentageModel
{
    public class Sandwich : PercentageModel
    {
        public override double FlourPercent { get => base.FlourPercent; set => base.FlourPercent = value; }
        public override double WaterPercent { get => base.WaterPercent; set => base.WaterPercent = value; }
        public override double YeastPercent { get => base.YeastPercent; set => base.YeastPercent = value; }
        public override double SaltPercent { get => base.SaltPercent; set => base.SaltPercent = value; }
        public override double SugarPercent { get => base.SugarPercent; set => base.SugarPercent = value; }
        public override double OilPercent { get => base.OilPercent; set => base.OilPercent = value; }

        public Sandwich()
        {
            FlourPercent = 100.0;
            WaterPercent = 63.0;
            YeastPercent = 1.2;
            SaltPercent = 1.0;
            SugarPercent = 3.5;
            OilPercent = 8.0;
        }
    }
}
