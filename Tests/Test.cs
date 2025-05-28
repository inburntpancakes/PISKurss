using Moq;
using PISKursovaya;
using PISKursovaya.Logic;
using PISKursovaya.Model;

namespace Tests
{
    [TestClass]
    public class Test
    {
        private Mock<IDatabaseAccess> mockDb;
        private BuisnessLogic buisnessLogic;

        public Test()
        {
            mockDb = new Mock<IDatabaseAccess>();
            buisnessLogic = new BuisnessLogic(mockDb.Object);
        }

        [TestMethod]
        public void TryAuthorizeAccess_ValidCredentials_ReturnsTrueAndUser()
        {
            var testUsers = new List<User>
            {
                new User { login = "test", password = "pass", user_id = 1 }
            };
            mockDb.Setup(db => db.GetAllUsers()).Returns(testUsers);

            bool result = buisnessLogic.TryAuthorizeAccess("test", "pass", out User user);

            Assert.IsTrue(result);
            Assert.IsNotNull(user);
            Assert.AreEqual("test", user.login);
        }

        [TestMethod]
        public void TryAuthorizeAccess_InvalidCredentials_ReturnsFalse()
        {
            var testUsers = new List<User>
            {
                new User { login = "somethingelse", password = "somethingelse", user_id = 1 }
            };
            mockDb.Setup(db => db.GetAllUsers()).Returns(testUsers);

            bool result = buisnessLogic.TryAuthorizeAccess("test", "pass", out User user);

            Assert.IsFalse(result);
            Assert.IsNull(user);
        }

        [TestMethod]
        public void GetProductsOfSupplier_ReturnsCorrectProducts()
        {
            var products = new List<Product>
            {
                new Product {supplier_id = 1, product_article = "art1" },
                new Product {supplier_id = 2, product_article = "art2" },
                new Product {supplier_id = 1, product_article = "art3" }
            };
            mockDb.Setup(db => db.GetAllProducts()).Returns(products);

            var result = buisnessLogic.GetProductsOfSupplier(1);

            Assert.AreEqual(2, result.Count());
            Assert.IsTrue(result.Exists(p => p.product_article == "art1"));
            Assert.IsTrue(result.Exists(p => p.product_article == "art3"));
        }

        [TestMethod]
        public void GetProductsOnSale_ReturnsOnlyOnSaleProducts()
        {
            var products = new List<Product>
            {
                new Product {is_on_sale = true, product_article = "art1" },
                new Product {is_on_sale = false, product_article = "art2" },
                new Product {is_on_sale = true, product_article = "art3" }
            };
            mockDb.Setup(db => db.GetAllProducts()).Returns(products);

            var result = buisnessLogic.GetProductsOnSale();

            Assert.AreEqual(2, result.Count());
            Assert.IsTrue(result.Exists(p => p.product_article == "art1"));
            Assert.IsTrue(result.Exists(p => p.product_article == "art3"));
        }

        [TestMethod]
        public void GetAllOrdersInProgress_ReturnsCorrectOrders()
        {
            var orders = new List<Order>
            {
                new Order { status = OrderStatus.InProgress, order_id = 1 },
                new Order { status = OrderStatus.Finished, order_id = 2 },
                new Order { status = OrderStatus.AwaitsSupplierConfirmation, order_id = 3 }
            };
            mockDb.Setup(db => db.GetAllOrders()).Returns(orders);

            var result = buisnessLogic.GetAllOrdersInProgress();

            Assert.AreEqual(2, result.Count());
            Assert.IsTrue(result.Exists(o => o.order_id == 1));
            Assert.IsTrue(result.Exists(o => o.order_id == 3));
        }

        [TestMethod]
        public void ConfirmOrderInProgressBySupplier_ChangesStatusCorrectly()
        {
            var order = new Order { status = OrderStatus.AwaitsSupplierConfirmation };
            mockDb.Setup(db => db.SaveChangedOrder(It.IsAny<Order>())).Callback<Order>(o => order = o);

            buisnessLogic.ConfirmOrderInProgressBySupplier(order);

            Assert.AreEqual(OrderStatus.Finished, order.status);
            mockDb.Verify(db => db.SaveChangedOrder(order), Times.Once);
        }

        [TestMethod]
        public void AddProduct_CallsDatabaseAccessCorrectly()
        {
            var product = new Product { product_article = "art1", product_name = "Test" };
            int supplierId = 1;

            buisnessLogic.AddProduct(product, supplierId);

            mockDb.Verify(db => db.AddProduct(product, supplierId), Times.Once);
        }

        [TestMethod]
        public void GetSupplierByUserId_ReturnsCorrectSupplier()
        {
            var testSuppliers = new List<Supplier>
            {
                new Supplier { user_id = 1, supplier_name = "a" },
                new Supplier { user_id = 2, supplier_name = "b" }
            };
            mockDb.Setup(db => db.GetAllSuppliers()).Returns(testSuppliers);

            var result = buisnessLogic.GetSupplierByUserId(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.supplier_name, "a");
        }

        [TestMethod]
        public void SaveChangedUser_CallsDatabaseAccess()
        {
            var user = new User { user_id = 1, password = "newpass" };

            buisnessLogic.SaveChangedUser(user);

            mockDb.Verify(db => db.SaveChangedUser(user), Times.Once);
        }

        [TestMethod]
        public void GetOrdersInProgressOfSupplier_ReturnsFilteredOrders()
        {
            // Arrange
            var testOrders = new List<Order>
            {
                new Order { status = OrderStatus.InProgress, supplier_id = 1, order_id = 1 },
                new Order { status = OrderStatus.Finished, supplier_id = 1, order_id = 2 },
                new Order { status = OrderStatus.AwaitsSupplierConfirmation, supplier_id = 1, order_id = 3 },
                new Order { status = OrderStatus.InProgress, supplier_id = 2, order_id = 4 }
            };
            mockDb.Setup(db => db.GetAllOrders()).Returns(testOrders);

            var result = buisnessLogic.GetOrdersInProgressOfSupplier(1);

            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Exists(o => o.order_id == 1));
            Assert.IsTrue(result.Exists(o => o.order_id == 3));
            Assert.IsFalse(result.Exists(o => o.order_id == 4));
        }

        [TestMethod]
        public void ConfirmOrderInProgressByFirm_ChangesStatusCorrectly()
        {
            var order1 = new Order { status = OrderStatus.AwaitsFirmConfirmation };
            buisnessLogic.ConfirmOrderInProgressByFirm(order1);
            Assert.AreEqual(OrderStatus.Finished, order1.status);
            mockDb.Verify(db => db.SaveChangedOrder(order1), Times.Once);

            mockDb.Invocations.Clear();
            var order2 = new Order { status = OrderStatus.InProgress };
            buisnessLogic.ConfirmOrderInProgressByFirm(order2);
            Assert.AreEqual(OrderStatus.AwaitsSupplierConfirmation, order2.status);
            mockDb.Verify(db => db.SaveChangedOrder(order2), Times.Once);
        }

        [TestMethod]
        public void GetOrdersOfSupplier_ReturnsCorrectOrders()
        {
            var testOrders = new List<Order>
            {
                new Order { supplier_id = 1, order_id = 1 },
                new Order { supplier_id = 2, order_id = 2 },
                new Order { supplier_id = 1, order_id = 3 }
            };
            mockDb.Setup(db => db.GetAllOrders()).Returns(testOrders);

            var result = buisnessLogic.GetOrdersOfSupplier(1);

            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Exists(o => o.order_id == 1));
            Assert.IsTrue(result.Exists(o => o.order_id == 3));
        }

        [TestMethod]
        public void GetAllOrders_ReturnsAllOrders()
        {
            var testOrders = new List<Order>
            {
                new Order { order_id = 1 },
                new Order { order_id = 2 }
            };
            mockDb.Setup(db => db.GetAllOrders()).Returns(testOrders);

            var result = buisnessLogic.GetAllOrders();

            Assert.AreEqual(2, result.Count);
            mockDb.Verify(db => db.GetAllOrders(), Times.Once);
        }

        [TestMethod]
        public void DeleteProduct_CallsDatabaseAccess()
        {
            var product = new Product { product_article = "art1" };

            buisnessLogic.DeleteProduct(product);

            mockDb.Verify(db => db.DeleteProduct(It.Is<Product>(p =>
                p.product_article == "art1")), Times.Once);
        }

        [TestMethod]
        public void SaveChangedProduct_CallsDatabaseAccess()
        {
            var product = new Product { product_article = "art1", product_name = "New Name" };

            buisnessLogic.SaveChangedProduct(product);

            mockDb.Verify(db => db.SaveChangedProduct(It.Is<Product>(p =>
                p.product_article == "art1" &&
                p.product_name == "New Name")), Times.Once);
        }

        [TestMethod]
        public void SaveChangedOrder_CallsDatabaseAccess()
        {
            var order = new Order { order_id = 1, status = OrderStatus.InProgress };

            buisnessLogic.SaveChangedOrder(order);

            mockDb.Verify(db => db.SaveChangedOrder(It.Is<Order>(o =>
                o.order_id == 1 &&
                o.status == OrderStatus.InProgress)), Times.Once);
        }
    }
}
