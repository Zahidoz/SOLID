

namespace InterfaceAgregation
{
    abstract class Vechile
    {
        public abstract int speed { get; set; }
        public abstract void IamNV();
    }
    interface ICanYukDasimaq
    {
        public void ICanYukDasimaq();
    }

    class bmw : Vechile
    {
        public override int speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void IamNV()
        {
            Console.WriteLine("Men Neqliyat Vasitesiyem");
        }
    }


    class Shaqman : Vechile, ICanYukDasimaq
    {
        public override int speed { get ; set; }

        public override void IamNV()
        {
            Console.WriteLine("Men Neqliyat Vasitesiyem");
        }

        public void ICanYukDasimaq()
        {
            Console.WriteLine("Men Yuk Dasiya bilirem");
        }
    }


    class Program
    {
        static void Main()
        {


        }
    }

}









