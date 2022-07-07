public partial class PercentageModel
{
    public class Ciabatta : PercentageModel
    {
        public override double FlourPercent { get => base.FlourPercent; set => base.FlourPercent = value; }
        public override double WaterPercent { get => base.WaterPercent; set => base.WaterPercent = value; }
        public override double YeastPercent { get => base.YeastPercent; set => base.YeastPercent = value; }
        public override double SaltPercent { get => base.SaltPercent; set => base.SaltPercent = value; }
        public override double SugarPercent { get => base.SugarPercent; set => base.SugarPercent = value; }
        public override double OilPercent { get => base.OilPercent; set => base.OilPercent = value; }
        public Ciabatta()
        {
            FlourPercent = 100.0;
            WaterPercent = 82.0;
            YeastPercent = 0.4;
            SaltPercent = 2.2;
            SugarPercent = 0.0;
            OilPercent = 0.0;
        }
    }
}
