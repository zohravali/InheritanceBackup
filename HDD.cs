using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class HDD: Storage
    {
        public decimal Speed { get; set; }

        private decimal filesize;

        public HDD(decimal speed, string mediaName, string model, decimal size, string deviceInfo) : base(mediaName, model, size, deviceInfo)
        {
            Speed = speed;
        }
        public override void Copy(File[] files)
        {

            Files = new File[files.Length];
            for (int i = 0; i < Files.Length; i++)
            {
                Files[i] = files[i];
            }

            for (int i = 0; i < files.Length; i++)
            {
                filesize += files[i].FileSize;
            }

            var hddCount = filesize / SizeOfMedia;
            if (hddCount < 1)
            {
                SizeOfMedia -= filesize;
                Console.WriteLine($"Count of drive needed: {1}");
            }

            else
                Console.WriteLine($"Count of drive needed: {hddCount}");


            var Minute = (filesize / Speed) / 60;

            Console.WriteLine($"Writing minute: {Minute}");
        }

        public override void PrintDeviceInfo()
        {
            Console.WriteLine($"Media name: {MediaName}\nModel: {Model}\nSize: {SizeOfMedia}\nSpeed: {Speed}\nDevice Info: {DeviceInfo}");
        }
    }
}
