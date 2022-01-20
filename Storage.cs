using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class File
    {
        public decimal FileSize { get; set; }

        //public string Unit { get; set; }

        public File(decimal fileize)
        {
            FileSize = fileize;
           // Unit = unit;
        }
    }
//daxil edilen butun unitlerden MB-a convert etmek ucun ayrica metod yazdim, amma verilen file size-i unitine gore mb - a cevirende decimala vurmaliyam, o zaman da "*" operatorunu decimalda islede bilmediyi ucun error verdi. Operator overloadingden de istifade etdim yene alinmadi. Basqa yolu var?
    abstract class Storage
    {

        public File[] Files { get; set; }
        public string MediaName { get; set; }

        public string Model { get; set; }

        public string DeviceInfo;

        public decimal SizeOfMedia { get; set; }

        public Storage()
        {

        }

        public Storage(string mediaName, string model, decimal size, string deviceInfo)
        {
            MediaName = mediaName;
            Model = model;
            SizeOfMedia = size;
            DeviceInfo = deviceInfo;
        }

        abstract public void Copy(File[] files);

        protected decimal FreeMemory()
        {
            return SizeOfMedia;
        }

        abstract public void PrintDeviceInfo();

    }


}
