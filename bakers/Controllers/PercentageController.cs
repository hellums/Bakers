public class PercentageController : IPercentageController
{
    public void Run()
    {
        var myView = new PercentageView(); //setup
        var myModel = new PercentageModel();

        myView.GetValues(myModel.breadList); //input

        myModel.Mass = myView.Mass; //processing
        myModel.Bread = myView.Bread;
        myModel.CalculateRatio();

        myView.ShowResults(); //output
        myView.ShowResults(myModel);
        myView.ShowResults((double)myModel.Mass, myModel.Bread);
    }
}