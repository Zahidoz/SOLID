namespace OpenClose
{
    interface IghzCalculate
    {
        public int speed { get; set; }
        int Calculate();
    }


    class HP : IghzCalculate
    {
        public int speed { get; set; }

        public HP(int speed)
        {
            this.speed = speed;
        }
        public int Calculate()
        {
            return speed * 20;
        }


    }

    class ASUS : IghzCalculate
    {

        public ASUS(int speed)
        {
            this.speed = speed;
        }

        public int speed { get; set; }

        public int Calculate()
        {
            return speed * 10;
        }
    }

    class Program
    {
        static void Main()
        {
           HP hp1 = new HP(30);
           ASUS asus1 = new ASUS(30);
           
           List<IghzCalculate> compsSpeeds = new List<IghzCalculate>();
            compsSpeeds.Add(hp1);
            compsSpeeds.Add(asus1);

            foreach (IghzCalculate x in compsSpeeds) 
            {
                Console.WriteLine(x.Calculate()); 
            }
           
        }
    }

}









