namespace BakersTest
{
    [TestClass]
    public class PercentageModelTest
    {
        private PercentageModel testModel = new();

        [TestMethod]
        public void CiabattaIngredientsCorrect()
        {
            //Arrange
            testModel = new PercentageModel.Ciabatta
            {
                Mass = 1000
            };

            //Act
            testModel.CalculateRatio();

            //Assert
            Assert.AreEqual(testModel.Mass, 1000);
            Assert.AreEqual(testModel.FlourAmount, 542);
            Assert.AreEqual(testModel.WaterAmount, 445);
            Assert.AreEqual(testModel.YeastAmount, 3);
            Assert.AreEqual(testModel.SaltAmount, 12);
            Assert.AreEqual(testModel.SugarAmount, 0);
            Assert.AreEqual(testModel.OilAmount, 0);
        }

        [TestMethod]
        public void SandwichIngredientsCorrect()
        {
            //Arrange
            testModel = new PercentageModel.Sandwich
            {
                Mass = 1000
            };

            //Act
            testModel.CalculateRatio();

            //Assert
            Assert.AreEqual(testModel.Mass, 1000);
            Assert.AreEqual(testModel.FlourAmount, 566);
            Assert.AreEqual(testModel.WaterAmount, 357);
            Assert.AreEqual(testModel.YeastAmount, 7);
            Assert.AreEqual(testModel.SaltAmount, 6);
            Assert.AreEqual(testModel.SugarAmount, 20);
            Assert.AreEqual(testModel.OilAmount, 46);
        }
        [TestMethod]
        public void FocacciaIngredientsCorrect()
        {
            //Arrange
            testModel = new PercentageModel.Focaccia
            {
                Mass = 1000
            };

            //Act
            testModel.CalculateRatio();

            //Assert
            Assert.AreEqual(testModel.Mass, 1000);
            Assert.AreEqual(testModel.FlourAmount, 492);
            Assert.AreEqual(testModel.WaterAmount, 443);
            Assert.AreEqual(testModel.YeastAmount, 4);
            Assert.AreEqual(testModel.SaltAmount, 18);
            Assert.AreEqual(testModel.SugarAmount, 0);
            Assert.AreEqual(testModel.OilAmount, 47);
        }
        [TestMethod]
        public void PizzaIngredientsCorrect()
        {
            //Arrange
            testModel = new PercentageModel.Pizza
            {
                Mass = 1000
            };

            //Act
            testModel.CalculateRatio();

            //Assert
            Assert.AreEqual(testModel.Mass, 1000);
            Assert.AreEqual(testModel.FlourAmount, 615);
            Assert.AreEqual(testModel.WaterAmount, 363);
            Assert.AreEqual(testModel.YeastAmount, 8);
            Assert.AreEqual(testModel.SaltAmount, 13);
            Assert.AreEqual(testModel.SugarAmount, 0);
            Assert.AreEqual(testModel.OilAmount, 4);
        }
        [TestMethod]
        public void BaguetteIngredientsCorrect()
        {
            //Arrange
            testModel = new PercentageModel.Baguette
            {
                Mass = 1000
            };

            //Act
            testModel.CalculateRatio();

            //Assert
            Assert.AreEqual(testModel.Mass, 1000);
            Assert.AreEqual(testModel.FlourAmount, 591);
            Assert.AreEqual(testModel.WaterAmount, 391);
            Assert.AreEqual(testModel.YeastAmount, 8);
            Assert.AreEqual(testModel.SaltAmount, 12);
            Assert.AreEqual(testModel.SugarAmount, 0);
            Assert.AreEqual(testModel.OilAmount, 0);
        }
        [TestMethod]
        public void BunsIngredientsCorrect()
        {
            //Arrange
            testModel = new PercentageModel.Buns
            {
                Mass = 1000
            };

            //Act
            testModel.CalculateRatio();

            //Assert
            Assert.AreEqual(testModel.Mass, 1000);
            Assert.AreEqual(testModel.FlourAmount, 565);
            Assert.AreEqual(testModel.WaterAmount, 373);
            Assert.AreEqual(testModel.YeastAmount, 12);
            Assert.AreEqual(testModel.SaltAmount, 9);
            Assert.AreEqual(testModel.SugarAmount, 15);
            Assert.AreEqual(testModel.OilAmount, 29);
        }
        [TestMethod]
        public void RollsIngredientsCorrect()
        {
            //Arrange
            testModel = new PercentageModel.Rolls
            {
                Mass = 1000
            };

            //Act
            testModel.CalculateRatio();

            //Assert
            Assert.AreEqual(testModel.Mass, 1000);
            Assert.AreEqual(testModel.FlourAmount, 545);
            Assert.AreEqual(testModel.WaterAmount, 327);
            Assert.AreEqual(testModel.YeastAmount, 13);
            Assert.AreEqual(testModel.SaltAmount, 8);
            Assert.AreEqual(testModel.SugarAmount, 55);
            Assert.AreEqual(testModel.OilAmount, 55);
        }
        [TestMethod]
        public void DumplingsIngredientsCorrect()
        {
            //Arrange
            testModel = new PercentageModel.Dumplings
            {
                Mass = 1000
            };

            //Act
            testModel.CalculateRatio();

            //Assert
            Assert.AreEqual(testModel.Mass, 1000);
            Assert.AreEqual(testModel.FlourAmount, 553);
            Assert.AreEqual(testModel.WaterAmount, 393);
            Assert.AreEqual(testModel.YeastAmount, 0);
            Assert.AreEqual(testModel.SaltAmount, 6);
            Assert.AreEqual(testModel.SugarAmount, 0);
            Assert.AreEqual(testModel.OilAmount, 50);
        }
    }
}
