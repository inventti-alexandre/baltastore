using BaltaStore.Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var customer = new Customer(
                "Leonardo",
                "Ribeiro",
                "42432131878",
                "leonardostudent@gmail.com",
                "4243213187",
                "casa rua 20");

            var order = new Order(customer);
        }
    }
}
