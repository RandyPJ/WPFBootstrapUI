using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFBootstrapUI.Controls.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Instrumentation;

namespace WPFBootstrapUI.Controls.Modals.Tests
{
    [TestClass()]
    public class ModalServiceTests
    {
        [TestMethod()]
        public void ShowModalTest()
        {
            Assert.AreEqual(ModalService.ShowModal(BootstrapUISample.App.Current.MainWindow,"Titulo","Hola","Aceptar","Cancelar",true),ModalResult.Accept);
        }

        [TestMethod()]
        public void ShowModalAsyncTest()
        {
            //Assert.Fail();
        }
    }
}