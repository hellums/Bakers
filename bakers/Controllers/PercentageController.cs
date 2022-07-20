using bakers.Models.Logger;

public class PercentageController : IPercentageController
{
    public void Run()
    {
        var logger = new Logger();
        logger.Log("program started");
        var myView = new PercentageView();
        var myModel = new PercentageModel();
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
                    case "rolls":
                        myModel = new PercentageModel.Rolls();
                        break;
                    case "dumplings":
                        myModel = new PercentageModel.Dumplings();
                        break;
                    default:
                        myModel = new PercentageModel.Sandwich();
                        break;
                }
                myModel.Mass = myView.Mass; //processing
                if (myView.Bread == null)
                {
                    logger.Log("bread type came back null from user menu selection");
                    Environment.FailFast("Console read of bread variable failed");
                }
                myModel.Bread = myView.Bread;
                myModel.CalculateRatio();
                myView.ShowResults(myModel); //output
            }
            else 
            {
                logger.Log("user selected to exit menu");
                break;
            }
        }
        myView.Goodbye();
    }
}