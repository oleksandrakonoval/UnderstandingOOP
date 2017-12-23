using SimCorp.IMS.MobilePhoneLibrary.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset
{
    public interface IPlayback
    {
        void Play(object data);
    }

    public class iPhoneHeadset : IPlayback
    {
        private IOutput Output;

        public iPhoneHeadset (IOutput output)
        {
            Output = output;
        }

        public void Play (object data)
        {
            //Console.WriteLine($"{nameof(iPhoneHeadset)} sound");
            Output.WriteLine($"{nameof(iPhoneHeadset)} sound");
        }
    }

    public class SamsungHeadset : IPlayback
    {
        private IOutput Output;

        public SamsungHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            //Console.WriteLine($"{nameof(SamsungHeadset)} sound");
            Output.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }

    public class UnoffocoaliPhoneHeadset : IPlayback
    {
        private IOutput Output;

        public UnoffocoaliPhoneHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            //Console.WriteLine($"{nameof(UnoffocoaliPhoneHeadset)} sound");
            Output.WriteLine($"{nameof(UnoffocoaliPhoneHeadset)} sound");
        }
    }

    public class PhoneSpeaker : IPlayback
    {
        private IOutput Output;

        public PhoneSpeaker(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            //Console.WriteLine($"{nameof(PhoneSpeaker)} sound");
            Output.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
    }
}
