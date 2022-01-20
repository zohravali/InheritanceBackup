using Inheritance;
using System;

File[] files = new File[5]
 {
                new(1000),
                new(5000),
                new(780),
                new(50000),
                new(100000)
 };

Flash flash = new(640, "Flash drive", "Kingston", 128, "Quick transfers and convenient storage of documents, music, videos and more.");

flash.PrintDeviceInfo();
flash.Copy(files);
Console.WriteLine();

HDD hdd = new(640, "HDD drive", "SeaGate", 5000000, "Easily store and access 1TB to content on the go with the Seagate Portable Drive, a USB external hard drive");

hdd.PrintDeviceInfo();
hdd.Copy(files);
Console.WriteLine();

DVD dvd = new(36, "DVD drive", "ASUS", 9, "8X DVD write speed, ASUS ZenDrive U7M provides a complete, easy-to-use backup solution.", 2);

dvd.PrintDeviceInfo();
dvd.Copy(files);
Console.WriteLine();