using CoffeeShopConsoleAppNet60;

namespace MSTestCoffeeShop
{
    [TestClass]
    public class CoffeeTests
    {
        [TestMethod]
        public void PriceTest()
        {


        }
        // Equal to the correct price.
        [DataTestMethod]
        [DataRow(40)]
        [TestMethod]
        public void Latte_Price_AreEqual_40(int value)
        {
            // Arrange
            var latte = new Latte();
            // Act
            int price = latte.Price();
            // Assert
            Assert.AreEqual(value, price);
        }
        [DataTestMethod]
        [DataRow(20)]
        [TestMethod]
        public void BlackCoffee_Price_AreEqual_20(int value)
        {
            // Arrange
            var blackCoffee = new BlackCoffee();
            // Act
            int price = blackCoffee.Price();
            // Assert
            Assert.AreEqual(value, price);
        }
        [DataTestMethod]
        [DataRow(25)]
        [TestMethod]
        public void Cortado_Price_AreEqual_25(int value)
        {
            // Arrange
            var coratdo = new Cortado();
            // Act
            int price = coratdo.Price();
            // Assert
            Assert.AreEqual(value, price);
        }
        [DataTestMethod]
        [DataRow(40)]
        [TestMethod]
        public void FlatWhite_Price_AreEqual_40(int value)
        {
            // Arrange
            var flatWhite = new FlatWhite();
            // Act
            int price = flatWhite.Price();
            // Assert
            Assert.AreEqual(value, price);
        }

        // Equal to the correct amount of milk
        [DataTestMethod]
        [DataRow(200)]
        [TestMethod]
        public void Latte_Milk_AreEqual_200(int value)
        {
            // Arrange
            var latte = new Latte();
            // Act
            int mlMilk = latte.MlMilk();
            // Assert
            Assert.AreEqual(value, mlMilk);
        }
        [DataTestMethod]
        [DataRow(0)]
        [TestMethod]
        public void BlackCoffee_Milk_AreEqual_0(int value)
        {
            // Arrange
            var blackCoffee = new BlackCoffee();
            // Act
            int mlMilk = blackCoffee.MlMilk();
            // Assert
            Assert.AreEqual(value, mlMilk);
        }
        [DataTestMethod]
        [DataRow(40)]
        [TestMethod]
        public void Cortado_Milk_AreEqual_40(int value)
        {
            // Arrange
            var cortado = new Cortado();
            // Act
            int mlMilk = cortado.MlMilk();
            // Assert
            Assert.AreEqual(value, mlMilk);
        }
        [DataTestMethod]
        [DataRow(30)]
        [TestMethod]
        public void FlatWhite_Milk_AreEqual_30(int value)
        {
            // Arrange
            var flatWhite = new FlatWhite();
            // Act
            int mlMilk = flatWhite.MlMilk();
            // Assert
            Assert.AreEqual(value, mlMilk);
        }

        // Eqaul to the correct Coffee Type
        [DataTestMethod]
        [DataRow("Latte")]
        [TestMethod]
        public void Latte_CoffeeType_AreEqual_Latte(string value)
        {
            // Arrange
            var latte = new Latte();
            // Act
            string coffeType = latte.CoffeeType();
            // Assert
            Assert.AreEqual(value, coffeType);
        }
        [DataTestMethod]
        [DataRow("Black Coffee")]
        [TestMethod]
        public void BlackCoffee_CoffeeType_AreEqual_BlackCoffeee(string value)
        {
            // Arrange
            var blackCoffee = new BlackCoffee();
            // Act
            string coffeType = blackCoffee.CoffeeType();
            // Assert
            Assert.AreEqual(value, coffeType);
        }
        [DataTestMethod]
        [DataRow("Cortado")]
        [TestMethod]
        public void Cortado_CoffeeType_AreEqual_Cortado(string value)
        {
            // Arrange
            var cortado = new Cortado();
            // Act
            string coffeType = cortado.CoffeeType();
            // Assert
            Assert.AreEqual(value, coffeType);
        }
        [DataTestMethod]
        [DataRow("Flat White")]
        [TestMethod]
        public void FlatWhite_CoffeeType_AreEqual_FlatWhite(string value)
        {
            // Arrange
            var flatWhite = new FlatWhite();
            // Act
            string coffeType = flatWhite.CoffeeType();
            // Assert
            Assert.AreEqual(value, coffeType);
        }

        // Eqaul to the correct Strength
        [DataTestMethod]
        [DataRow("Weak")]
        [TestMethod]
        public void Latte_Strength_AreEqual_Weak(string value)
        {
            // Arrange
            var latte = new Latte();
            // Act
            string coffeType = latte.Strength();
            // Assert
            Assert.AreEqual(value, coffeType);
        }
        [DataTestMethod]
        [DataRow("Strong")]
        [TestMethod]
        public void BlackCoffee_Strength_AreEqual_Strong(string value)
        {
            // Arrange
            var blackCoffee = new BlackCoffee();
            // Act
            string coffeType = blackCoffee.Strength();
            // Assert
            Assert.AreEqual(value, coffeType);
        }
        [DataTestMethod]
        [DataRow("Medium")]
        [TestMethod]
        public void Cortado_Strength_AreEqual_Medium(string value)
        {
            // Arrange
            var cortado = new Cortado();
            // Act
            string coffeType = cortado.Strength();
            // Assert
            Assert.AreEqual(value, coffeType);
        }
        [DataTestMethod]
        [DataRow("Medium")]
        [TestMethod]
        public void FlatWhite_Strength_AreEqual_Medium(string value)
        {
            // Arrange
            var flatWhite = new FlatWhite();
            // Act
            string coffeType = flatWhite.Strength();
            // Assert
            Assert.AreEqual(value, coffeType);
        }

        // Question here. Is it correct that the test has to fail for the assignment?
        // Throw Expection if discount is > 5
        [DataTestMethod]
        [DataRow(20)]
        [DataRow(15)]
        [DataRow(10)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Latte_DiscountPrice_GreaterThan_5(int value)
        {
            // Arrange
            var latte = new Latte(value);
            // Act
            int price = latte.Price();
            // Assert
            
            Assert.AreEqual(40, price);
        }



    }
}