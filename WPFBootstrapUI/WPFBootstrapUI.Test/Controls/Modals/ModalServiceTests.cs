using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;

namespace WPFBootstrapUI.Controls.Modals.Tests
{
    [TestClass()]
    public class ModalServiceTests
    {
        [TestMethod()]
        public void ShowModalTest()
        {
            ModalResult result = ModalService.ShowModal(new Window(), "Hola", "Hola", "Accept", "Cancel", true);
            Assert.IsNotNull(result);
        }
    }
}