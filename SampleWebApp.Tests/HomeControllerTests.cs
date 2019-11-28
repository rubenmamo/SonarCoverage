using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleWebApp.Controllers;

namespace SampleWebApp.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void IndexReturnsView()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void PrivacyReturnsView()
        {
            var controller = new HomeController();

            var result = controller.Privacy();

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
