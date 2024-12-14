using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralManagementSystem
{
    class AddPackageClass
    {
        public delegate long DelegateNumber(long number);
        public delegate String DelegateText(string txt);

        public static String PackageName = " ";
        public static String Inclusions = " ";
        public static String PackageID = " ";
        public static long Price = 0;

        public static String GetPackage(String Package)
        {
            return Package;
        }

        public static String GetInclusions(String Inclusions)
        {
            return Inclusions;
        }

        public static long GetPrice(long Price)
        {
            return Price;
        }

        public static String getPackageID(String PackageID) {
            return PackageID;
        }
    }
}
