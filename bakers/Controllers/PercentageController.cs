public class PercentageController : IPercentageController
{
    public void Run()
    {
        var myView = new PercentageView(); //setup
        var myModel = new PercentageModel();

        myView.GetValues(myModel, myModel.breadList); //input
        if (!myView.userSelectedExit)
        {
            myModel.Mass = myView.Mass; //processing
            myModel.Bread = myView.Bread;
            myModel.CalculateRatio();
            myView.ShowResults(myModel); //output
        }
    }
}