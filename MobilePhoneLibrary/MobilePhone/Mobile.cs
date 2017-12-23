using SimCorp.IMS.MobilePhoneLibrary.Images;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents;
using System;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponent;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Simcard;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger;

namespace SimCorp.IMS.MobilePhoneLibrary.MobilePhone
{
    public abstract class Mobile {
        public abstract ScreenBase Screen { get; set; }
        public abstract Keyboard Keyboard { get; set; }
        public abstract Battery Battery { get; set; }
        public abstract SimCard SimCard { get; set; }
        public abstract MobilePhoneComponents.OperatingSystem OperatingSystem { get; set; }
        public abstract Camera Camera { get; set; }

        public IPlayback PlaybackComponent { get; set; }
        public ISimCard SimCardItem { get; set; }
        public ICharger ChargerComponenet { get; set; }


        private void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
        }

        public ScreenBase defineScreen() {
            ScreenBase result = new ColorfulScreen();
            Console.WriteLine("Choose screen type index:");
            Console.WriteLine($"0 - {nameof(MonochromeScreen)}");
            Console.WriteLine($"1 - {nameof(ColorfulScreen)}");
            int screenType = Convert.ToInt32(Console.ReadLine());
            if (screenType == 0)
            {
                result = new MonochromeScreen();
            }
            if (screenType == 1)
            {
                Console.WriteLine("Choose ColorfulScreen type index:");
                Console.WriteLine($"0 - {nameof(OLEDScreen)}");
                Console.WriteLine($"1 - {nameof(RetinaScreen)}");
                int colorfulScreenType = Convert.ToInt32(Console.ReadLine());
                if (colorfulScreenType == 0) {
                    result = new OLEDScreen();
                }
                else if (colorfulScreenType == 1) {
                    result = new RetinaScreen();
                }
            }
            return result;
        }

       /* public int defineEnumParam(string type) {
            
            Console.WriteLine($"Choose {type} index:");
            type = "SimCorp.IMS.UnderstandingOOP.MobilePhoneComponents." + type;
            Type currentType = Type.GetType(type);
            object thisObjectItem = Activator.CreateInstance(currentType);
            IEnumerable enumItem = thisObjectItem as IEnumerable;
            
            foreach (string item in Enum.GetNames(thisObjectItem.GetType()))
            {
                Console.WriteLine($"{Enum.Parse(thisObjectItem.GetType(), item).GetHashCode()} - {item.ToString()}");
            }
            int result = Convert.ToInt32(Console.ReadLine());
            return result;

        }*/

        public int defineEnumParam(Type type) {
            string[] enumInsts = Enum.GetNames(type);
            for(int i = 0; i < enumInsts.Length; i++) {
                Console.WriteLine($"{i} - {enumInsts[i]}");
            }
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }

    }
}
