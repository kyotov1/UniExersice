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
            public Telefone(string name, string model, int weight, int diagonal)
            {
                this.name = name;
                this.model = model;
                this.
            }
            public override string ToString()
            {
                return $"Telefone {name}; Model {model}; weight {weight} g.; diagonal {diagonal} inch ";
            }

        }
        static void Main(string[] args)
        {
            Telefone t1 = new Telefone();
            t1.model = "Samsung";
            t1.model = "S20";
            t1.weight = 150;
            t1.diagonal = 10;
            Console.WriteLine(t1.ToString());


        }
    }
}
