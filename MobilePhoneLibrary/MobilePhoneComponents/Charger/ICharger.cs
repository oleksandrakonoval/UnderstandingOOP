using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger
{
    public interface ICharger
    {
        void Charge (object data);
    }

    public class SamsungCharger : ICharger
    {
        private IOutput Output;

        public SamsungCharger(IOutput output)
        {
            Output = output;
        }
        public void Charge(object data)
        {
            //Console.WriteLine($"{nameof(SamsungCharger)} in progress");
            Output.WriteLine($"{nameof(SamsungCharger)} in progress");
        }
    }

    public class SonyCharger : ICharger
    {
        private IOutput Output;

        public SonyCharger(IOutput output)
        {
            Output = output;
        }
        public void Charge(object data)
        {
            //Console.WriteLine($"{nameof(SonyCharger)} in progress");
            Output.WriteLine($"{nameof(SonyCharger)} in progress");
        }
    }

    public class NokiaCharger : ICharger
    {
        private IOutput Output;

        public NokiaCharger(IOutput output)
        {
            Output = output;
        }
        public void Charge(object data)
        {
            //Console.WriteLine($"{nameof(NokiaCharger)} in progress");
            Output.WriteLine($"{nameof(NokiaCharger)} in progress");
        }
    }

    public class MotoCharger : ICharger
    {
        private IOutput Output;

        public MotoCharger(IOutput output)
        {
            Output = output;
        }

        public void Charge(object data)
        {
            //Console.WriteLine($"{nameof(MotoCharger)} in progress");
            Output.WriteLine($"{nameof(MotoCharger)} in progress");
        }
    }


}
