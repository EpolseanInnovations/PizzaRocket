using PizzaStoreData.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizzaStoreData.Test
{
    class EFDataTests
    {
        #region Test Get List Functions
        [Fact]
        public void Test_GetAddressDetails()
        {
            var data = new EFData();
            var actual = data.GetAddressDetails();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetCardPayments()
        {
            var data = new EFData();
            var actual = data.GetCardPayments();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetCheeses()
        {
            var data = new EFData();
            var actual = data.GetCheeses();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetCheeseToppings()
        {
            var data = new EFData();
            var actual = data.GetCheeseToppings();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetCrusts()
        {
            var data = new EFData();
            var actual = data.GetCrusts();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetCustomers()
        {
            var data = new EFData();
            var actual = data.GetCustomers();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetEmails()
        {
            var data = new EFData();
            var actual = data.GetEmails();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetMeats()
        {
            var data = new EFData();
            var actual = data.GetMeats();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetMeatToppings()
        {
            var data = new EFData();
            var actual = data.GetMeatToppings();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetNames()
        {
            var data = new EFData();
            var actual = data.GetNames();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetPaymentTypes()
        {
            var data = new EFData();
            var actual = data.GetPaymentTypes();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetPhones()
        {
            var data = new EFData();
            var actual = data.GetPhones();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetPizzas()
        {
            var data = new EFData();
            var actual = data.GetPizzas();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetPizzaOrders()
        {
            var data = new EFData();
            var actual = data.GetPizzaOrders();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetPizzaOrderDetails()
        {
            var data = new EFData();
            var actual = data.GetPizzaOrderDetails();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetSauces()
        {
            var data = new EFData();
            var actual = data.GetSauces();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetSizes()
        {
            var data = new EFData();
            var actual = data.GetSizes();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetStores()
        {
            var data = new EFData();
            var actual = data.GetStores();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetStoreHours()
        {
            var data = new EFData();
            var actual = data.GetStoreHours();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetVegetables()
        {
            var data = new EFData();
            var actual = data.GetVegetables();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetVegetableToppings()
        {
            var data = new EFData();
            var actual = data.GetVegetableToppings();

            Assert.NotNull(actual);
        }
        #endregion

        #region Test Get Item Functions
        [Fact]
        public void Test_GetAddressDetail()
        {
            var data = new EFData();
            var actual = data.GetAddressDetail(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetCardPayment()
        {
            var data = new EFData();
            var actual = data.GetCardPayment(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetCheese()
        {
            var data = new EFData();
            var actual = data.GetCheese(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetCheeseTopping()
        {
            var data = new EFData();
            var actual = data.GetCheeseTopping(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetCrust()
        {
            var data = new EFData();
            var actual = data.GetCrust(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetCustomer()
        {
            var data = new EFData();
            var actual = data.GetCustomer(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetEmail()
        {
            var data = new EFData();
            var actual = data.GetEmail(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetMeat()
        {
            var data = new EFData();
            var actual = data.GetMeat(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetMeatTopping()
        {
            var data = new EFData();
            var actual = data.GetMeatTopping(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetName()
        {
            var data = new EFData();
            var actual = data.GetName(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetPaymentType()
        {
            var data = new EFData();
            var actual = data.GetPaymentType(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetPhone()
        {
            var data = new EFData();
            var actual = data.GetPhone(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetPizza()
        {
            var data = new EFData();
            var actual = data.GetPizza(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetPizzaOrder()
        {
            var data = new EFData();
            var actual = data.GetPizzaOrder(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetPizzaOrderDetail()
        {
            var data = new EFData();
            var actual = data.GetPizzaOrderDetail(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetSauce()
        {
            var data = new EFData();
            var actual = data.GetSauce(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetSize()
        {
            var data = new EFData();
            var actual = data.GetSize(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetStore()
        {
            var data = new EFData();
            var actual = data.GetStore(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetStoreHour()
        {
            var data = new EFData();
            var actual = data.GetStoreHour(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetVegetable()
        {
            var data = new EFData();
            var actual = data.GetVegetable(1);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_GetVegetableTopping()
        {
            var data = new EFData();
            var actual = data.GetVegetableTopping(1);

            Assert.NotNull(actual);
        }
        #endregion
    }
}
