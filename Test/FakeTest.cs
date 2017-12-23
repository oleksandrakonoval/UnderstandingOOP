using SimCorp.IMS.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.General;

namespace FakeTest
{
    [TestClass]
    public class FakeTest
    {
        [TestMethod]
        public void ConsoleFakePlay()
        {
            // Arrange / Act
            IOutput output = new OutputMock();
            FakeHeadset headset = new FakeHeadset(output);
            headset.Play(output);

            var expectedString = "iPhoneHeadset sound\r\n";
            
            //Assert
            Assert.AreEqual(expectedString, output.Output.ToString());
        }
        
    }
}
