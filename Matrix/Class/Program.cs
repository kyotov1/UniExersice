using System;

namespace Class
{
    class Program
    {
        class Telefone
        {
            string name;
            string model;
            int weight;
            int diagonal;
            public int Weight
            {
                get
                {
                    return weight;
                }
                set
                {
                    if (value > 500 || value < 0)
                        throw new ArgumentException("Not correct weight");
                    else
                    {
                        weight = value;
                    }
                }
            }
            public Telefone(string name, string model, int weight, int diagonal)
            {
                this.name = name;
                this.model = model;
               this.weight= weight;
                this.diagonal = diagonal;
            }
            public override string ToString()
            {
                return $"Telefone {name}; Model {model}; weight {weight} g.; diagonal {diagonal:f2} inch ";
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine($"a={1.56879134:f3}; a={1.56879134:f3};a={1.56879134:f3}");
            double rmin;
            double rmax;
            double delta;
            do { Console.Write("rmin: "); }
            while (!double.TryParse(Console.ReadLine(), out rmin));
            do { Console.Write("rmax: "); }
            while (!double.TryParse(Console.ReadLine(), out rmax));
            do { Console.Write("delta: "); }
            while (!double.TryParse(Console.ReadLine(), out delta));
            Circlecs circle = new Circlecs();

            for(double i=rmin; i<rmax; i+=delta)
            {
                circle._R = i;
                Console.WriteLine(circle.ToString());
            }

            Telefone t1 = new Telefone("Samsung", "A20",1630, 6);
            //t1.Weight = 1600;
            Console.WriteLine(t1.ToString());
            Telefone[] tel = new Telefone[] {
                new Telefone("Samsung", "S20", 200,6),
                new Telefone("Xiaomi", "A20", 100,5)            
            };

            int w = 0;
            foreach (Telefone tels in tel)
            {
                w += tels.Weight;
            }
            Console.WriteLine(w);
        }
    }
}
