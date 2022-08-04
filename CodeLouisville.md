## Instructions

To clone and run the tests and program on your local system, do the following:

- create a new folder, such as "test", then run these commands
- > cd test
- > git clone https://github.com/hellums/bakers.git
- > cd bakers
- > dotnet test
- > cd bakers
- > dotnet run

You can also use Visual Studio to run the tests and program from the IDE by loading the bakers.sln file in that folder, after cloning. To clean up, just return to the folder where you created test and remove that test folder using rmdir /q /s test (Windows) or rm -rf test (Mac or Linux).

## Code Louisville Requirements List
- [X] Project includes a [README file](https://github.com/hellums/bakers/blob/root/README.md) that explains the following:
  - [X] A one paragraph or longer description of what your project is about
  - [X] Any special instructions required for the reviewer to run your project
- [X] Implement a [“master loop”](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Controllers/PercentageController.cs#L11) console application, including choosing to exit the program
- [X] Create at least [one class and object instance](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Models/PercentageModel.cs#L1) with populated data used in the application
- [X] Create an additional [class which inherits one or more properties](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Models/PercentageModel.Ciabatta.cs#L3) from its parent
- [X] Create and call at least [3 functions or methods](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Views/PercentageView.cs#L47), at least one of which [returns a value used](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Views/PercentageView.cs#L45) in the application
- [X] Create a [dictionary or list](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Views/PercentageView.cs#L10), populate it with several values, [retrieve at least one value](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Controllers/PercentageController.cs#L13), and use it in your program
- [X] Implement a [log that records errors](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Models/Logger/Logger.cs#L16), invalid inputs, or other important events and writes them to a text file
- [X] Build a [conversion tool](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/bakers/Models/PercentageModel.cs#L20) that converts user input to another type and displays the results
- [X] Create [3 or more unit tests](https://github.com/hellums/bakers/blob/0a81141147874d55a5204060c133c755710801c0/BakersTest/PercentageModelTest.cs#L4)
- [X] Uses [interfaces and MVC architecture](https://github.com/hellums/bakers/blob/5aad293bc22abdc7f0d699225554acb3071999c0/bakers/Controllers/PercentageController.cs#L3) to separate UI from business logic and data layer
