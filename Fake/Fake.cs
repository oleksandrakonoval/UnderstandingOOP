using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset;

namespace SimCorp.IMS.Fake
{
    public class FakeHeadset : IPlayback
    {
        private IOutput Output;

        public FakeHeadset(IOutput output)
        {
            Output = output;
        }

        public void Play(object data)
        {
            Output.WriteLine($"{nameof(iPhoneHeadset)} sound");
        }
    }
}
