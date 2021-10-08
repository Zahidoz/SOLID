

namespace InterfaceAgregation
{
    interface İfly
    {
        void İcanFly();
    }
    interface İfloats
    {
        void İcanFloats();
    }

    class Boeing : İfly
    {
        public void İcanFly()
        {
            Console.WriteLine("I Can Fly");
        }
    }

    class boat : İfloats
    {
        public void İcanFloats()
        {
            Console.WriteLine("I Can Floats");
        }
    }

    class HU_16_Albatros : İfloats, İfly
    {
        public void İcanFloats()
        {
            Console.WriteLine("I Can Fly");
        }

        public void İcanFly()
        {
            Console.WriteLine("I Can Floats");
        }
    }

    class Program
    {
        static void Main()
        {
           

        }
    }

}









