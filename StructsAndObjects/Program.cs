using System;

namespace StructsAndObjects
{

    /*
     * Structs are normally allocated on the stack/inline.
     * Structs are value types.
     */
    struct LocationStruct
    {
        public int x;
        public int y;

        public LocationStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    /*
     * Classes are normally allocated on the heap and are garbage collected.
     * Classes are reference types.
     */
    class LocationClass
    {
        public int x;
        public int y;

        public LocationClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {

            // Create one struct
            LocationStruct locationStruct1 = new LocationStruct(100, 100);

            // Create a copy of location struct
            LocationStruct locationStruct2 = locationStruct1;   // Values are copied

            Console.WriteLine($"Before: locationStruct1={locationStruct1.x},{locationStruct1.y}, locationStruct2={locationStruct2.x},{locationStruct2.y}");

            // Add 10 to x of locationStruct1
            locationStruct1.x += 10;

            Console.WriteLine($"After +10 to locationStruct1: locationStruct1={locationStruct1.x},{locationStruct1.y}, locationStruct2={locationStruct2.x},{locationStruct2.y}");
            // Notice how only locationStruct1 was affected



            // Classes use referece pointers
            // Create one class
            LocationClass locationClass1 = new LocationClass(100, 100);

            // Create a copy of location class
            LocationClass locationClass2 = locationClass1;   // Values are copied

            Console.WriteLine($"Before: locationClass1={locationClass1.x},{locationClass1.y}, locationClass2={locationClass2.x},{locationClass2.y}");

            // Add 10 to x of locationClass1
            locationClass1.x += 10;

            Console.WriteLine($"After +10 to locationClass1: locationClass1={locationClass1.x},{locationClass1.y}, locationClass2={locationClass2.x},{locationClass2.y}");
            // Notice how locationClass1 and locationClass2 were affected

        }
    }
}
