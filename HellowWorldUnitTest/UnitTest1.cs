using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldTeamCity;
using System.Windows.Forms;

namespace HellowWorldUnitTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1( ) {
            HelloWorldForm helloWorldForm = new HelloWorldForm( );
            Assert.AreEqual( "Hello World!", helloWorldForm.label1.Text );
        }
    }
}
