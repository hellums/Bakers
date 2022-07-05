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
                    case "Ciabatta":
                        myModel = new PercentageModel.Ciabatta();
                        break;
                    case "Focaccia":
                        myModel = new PercentageModel.Focaccia();
                        break;
                    case "Pizza":
                        myModel = new PercentageModel.Pizza();
                        break;
                    case "Baguette":
                        myModel = new PercentageModel.Baguette();
                        break;
                    case "Sandwich":
                        myModel = new PercentageModel.Sandwich();
                        break;
                    case "Buns":
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
    }
}