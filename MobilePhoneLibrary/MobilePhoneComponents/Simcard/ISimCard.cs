using SimCorp.IMS.MobilePhoneLibrary.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Simcard
{
    public interface ISimCard
    {
        int Number { get; set; }
        int Pin { get; set; }
        void Call(object data);
    }

    public class NanoSim : ISimCard
    {
        public int Number { get; set; }
        public int Pin { get; set; }

        private IOutput Output;

        public NanoSim(IOutput output)
        {
            Output = output;
        }

        public void Call(object data)
        {
            //Console.WriteLine($"{nameof(NanoSim)} call");
            Output.WriteLine($"{nameof(NanoSim)} call");
        }
    }

    public class MicroSim : ISimCard
    {
        public int Number { get; set; }
        public int Pin { get; set; }


        private IOutput Output;

        public MicroSim(IOutput output)
        {
            Output = output;
        }

        public void Call(object data)
        {
            //Console.WriteLine($"{nameof(MicroSim)} call");
            Output.WriteLine($"{nameof(MicroSim)} call");
        }
    }

    public class MiniSim : ISimCard
    {
        public int Number { get; set; }
        public int Pin { get; set; }

        private IOutput Output;

        public MiniSim(IOutput output)
        {
            Output = output;
        }


        public void Call(object data)
        {
            //Console.WriteLine($"{nameof(MiniSim)} call");
            Output.WriteLine($"{nameof(MiniSim)} call");
        }
    }

    public class Sim : ISimCard
    {
        public int Number { get; set; }
        public int Pin { get; set; }

        private IOutput Output;

        public Sim(IOutput output)
        {
            Output = output;
        }


        public void Call(object data)
        {
            //Console.WriteLine($"{nameof(Sim)} call");
            Output.WriteLine($"{nameof(Sim)} call");
        }
    }


}
