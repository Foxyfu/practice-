namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B(4.3f);
            Console.WriteLine(a.C);
            Console.WriteLine(b.C);
            Console.WriteLine(b.C2);
            Console.ReadLine();
        }
    }

    public class A
    {
        private float a = 3.2f;
        private float b = 5.1f;

        public float C
        {
            get { return a *= b / a; }
        }
    }
    class B : A
    {
        private float _d;

        public float C2
        {
            get
            {
                if (base.C > 5)
                    return base.C * _d;
                else
                    return base.C / _d;
            }
        }

        public B(float d) : base()
        {
            _d = d;
        }
    }
 }