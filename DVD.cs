using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class DVD : Storage
    {
        public decimal RWSpeed { get; set; }

        public int Sides { get; set; }

        private decimal filesize;

        public DVD(decimal speed, string mediaName, string model, decimal size, string deviceInfo, int sides) : base(mediaName, model, size, deviceInfo)
        {
            RWSpeed = speed;
            Sides = sides;
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

            var dvdCount = filesize / SizeOfMedia;
            if (dvdCount < 1)
            {
                SizeOfMedia -= filesize;
                Console.WriteLine($"Count of drive needed: {1}");
            }

            else
                Console.WriteLine($"Count of drive needed: {dvdCount}");


            var Minute = (filesize / RWSpeed) / 60;

            Console.WriteLine($"Writing minute: {Minute}");

        }

        public override void PrintDeviceInfo()
        {
            Console.WriteLine($"Media name: {MediaName}\nModel: {Model}\nSize: {SizeOfMedia}\nSpeed: {RWSpeed}\nSides: {Sides}\nDevice Info: {DeviceInfo}");
        }
    }

}

