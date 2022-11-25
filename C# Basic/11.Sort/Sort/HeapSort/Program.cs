using System;

namespace HeapSort
{
    public class HeapSort : ICloneable
    {
        public static void Main(string[] args)
        {
            var clone = new HeapSort();

            var clone2 = clone.GetClone();

            Console.WriteLine(clone._a);
            Console.WriteLine(clone2._a);

            Console.Read();
        }

        public int _a = 10;
        public int _b = 20;

        public HeapSort()
        {
        }

        public object Clone() => MemberwiseClone();

        private HeapSort GetClone() => (HeapSort) Clone();
    }


    public class Id
    {
        string id { get; set; }
    }
}