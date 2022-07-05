public partial class PercentageModel
{
    public class Focaccia : PercentageModel
    {
        public override double FlourPercent { get => base.FlourPercent; set => base.FlourPercent = value; }
        public override double WaterPercent { get => base.WaterPercent; set => base.WaterPercent = value; }
        public override double YeastPercent { get => base.YeastPercent; set => base.YeastPercent = value; }
        public override double SaltPercent { get => base.SaltPercent; set => base.SaltPercent = value; }
        public override double SugarPercent { get => base.SugarPercent; set => base.SugarPercent = value; }
        public override double OilPercent { get => base.OilPercent; set => base.OilPercent = value; }
        public Focaccia()
        {
            FlourPercent = 100.0;
            WaterPercent = 90.0;
            YeastPercent = 0.75;
            SaltPercent = 3.5;
            SugarPercent = 0.0;
            OilPercent = 9.4;
        }
    }
}
