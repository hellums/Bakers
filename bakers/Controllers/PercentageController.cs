public class PercentageController : IPercentageController
{
    public void Run()
    {
        var myView = new PercentageView(); //setup
        var myModel = new PercentageModel(); //default
        //var myModel = new PercentageModel();
        while (true)
        {
            myView.GetValues(myModel, myModel.breadList); //input
            if (!myView.userSelectedExit)
            {
                switch (myModel.breadList) 
                {
                    case var _ when myModel.breadList.Contains("Ciabatta"):
                        myModel = new PercentageModel.Ciabatta();
                        break;
                    case var _ when myModel.breadList.Contains("Focaccia"):
                        myModel = new PercentageModel.Focaccia();
                        break;
                    case var _ when myModel.breadList.Contains("Pizza"):
                        myModel = new PercentageModel.Pizza();
                        break;
                    case var _ when myModel.breadList.Contains("Baguette"):
                        myModel = new PercentageModel.Baguette();
                        break;
                    case var _ when myModel.breadList.Contains("Sandwich"):
                        myModel = new PercentageModel.Sandwich();
                        break;
                    case var _ when myModel.breadList.Contains("Buns"):
                        myModel = new PercentageModel.Buns();
                        break;
                    //default:
                    //    myModel = new PercentageModel.Sandwich();
                    //    break;
                }
                myModel.Mass = myView.Mass; //processing
                myModel.Bread = myView.Bread;
                myModel.CalculateRatio();
                myView.ShowResults(myModel); //output
            }
            else break;
        }
    }
}