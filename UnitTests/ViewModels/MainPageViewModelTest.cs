using Koyomi.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.ViewModels
{
    [TestClass]
    public class MainPageViewModelTest : TestBase
    {
        [TestMethod]
        public void 正常系_四季の範囲()
        {
            var viewModel = new MainPageViewModel();
            this.LongTimeLoopAction((d) =>
            {
                viewModel.Update(d);
                Assert.IsTrue(
                    viewModel.FourSeasonLower.Value <= d && d <= viewModel.FourSeasonUpper.Value,
                    "四季: " + d.ToString());
            });
        }

        [TestMethod]
        public void 正常系_二十四節気の範囲()
        {
            var viewModel = new MainPageViewModel();
            this.LongTimeLoopAction((d) =>
            {
                viewModel.Update(d);
                Assert.IsTrue(
                    viewModel.SolarTermLower.Value <= d && d <= viewModel.SolarTermUpper.Value,
                    "二十四節気" + d.ToString());
            });
        }

        [TestMethod]
        public void 正常系_七十二候の範囲()
        {
            var viewModel = new MainPageViewModel();
            this.LongTimeLoopAction((d) =>
            {
                viewModel.Update(d);
                Assert.IsTrue(
                    viewModel.SolarTermMicroLower.Value <= d && d <= viewModel.SolarTermMicroUpper.Value,
                    "七十二候" + d.ToString());
            });
        }

        [TestMethod]
        public void 正常系_十二星座の範囲()
        {
            var viewModel = new MainPageViewModel();
            this.LongTimeLoopAction((d) =>
            {
                viewModel.Update(d);
                Assert.IsTrue(
                    viewModel.StarSignLower.Value <= d && d <= viewModel.StarSignUpper.Value,
                    "十二星座" + d.ToString());
            });
        }
    }
}
