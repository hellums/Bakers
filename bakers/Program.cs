using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static PercentageController? myController;
    public static void Main()
    {
    myController = new PercentageController();
    myController.Run();
    }
}
