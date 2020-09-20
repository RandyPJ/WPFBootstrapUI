using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using System.Windows.Controls;

namespace WPFBootstrapUI.Converters.Tests
{
    [TestClass()]
    public class BooleanToVisibilityConverterTests
    {
        [TestMethod()]
        public void ConvertToVisibleTest()
        {
            BooleanToVisibilityConverter converter = new BooleanToVisibilityConverter();

            Assert.AreEqual(converter.Convert(true, typeof(FrameworkElement), null, null), Visibility.Visible);
        }

        [TestMethod()]
        public void ConvertCollapseTest()
        {
            BooleanToVisibilityConverter converter = new BooleanToVisibilityConverter();
            Assert.AreEqual(converter.Convert(false, typeof(FrameworkElement), null, null), Visibility.Collapsed);
        }

        [TestMethod()]
        public void ConvertBackTest()
        {
            BooleanToVisibilityConverter converter = new BooleanToVisibilityConverter();
            Assert.AreEqual(converter.ConvertBack(false, typeof(FrameworkElement), null, null), null);
        }
    }
}