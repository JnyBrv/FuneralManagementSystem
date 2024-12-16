using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralManagementSystem
{
    class AddPackageClass
    {
        public delegate decimal DelegateNumber(decimal number);
        public delegate String DelegateText(string txt);
        public delegate byte DelegateImage(byte img);

        public static String PackageName = " ";
        public static String Inclusions = " ";
        public static String PackageID = " ";
        public static decimal Price = 0;
        public static byte[] PImage;

        public static byte GetImage(byte Image)
        {
            return Image;
        }
        public static String GetPackage(String Package)
        {
            return Package;
        }

        public static String GetInclusions(String Inclusions)
        {
            return Inclusions;
        }

        public static decimal GetPrice(decimal Price)
        {
            return Price;
        }

        public static String getPackageID(String PackageID) {
            return PackageID;
        }
    }
}
