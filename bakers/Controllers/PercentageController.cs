public class PercentageController : IPercentageController
{
    public void Run()
    {
        var myView = new PercentageView(); //setup
        var myModel = new PercentageModel(); //default
        while (true)
        {
            myView.GetValues(myModel, myModel.breadList); //input
            if (!myView.userSelectedExit)
            {
                switch (myView.Bread) 
                {
                    case "ciabatta":
                        myModel = new PercentageModel.Ciabatta();
                        break;
                    case "focaccia":
                        myModel = new PercentageModel.Focaccia();
                        break;
                    case "pizza":
                        myModel = new PercentageModel.Pizza();
                        break;
                    case "baguette":
                        myModel = new PercentageModel.Baguette();
                        break;
                    case "sandwich":
                        myModel = new PercentageModel.Sandwich();
                        break;
                    case "buns":
                        myModel = new PercentageModel.Buns();
                        break;
                    default:
                        myModel = new PercentageModel.Sandwich();
                        break;
                }
                myModel.Mass = myView.Mass; //processing
                myModel.Bread = myView.Bread;
                myModel.CalculateRatio();
                myView.ShowResults(myModel); //output
                //myView = new PercentageView();
                //myModel = new PercentageModel(); //default
            }
            else break;
        }
        myView.Goodbye();
    }
}