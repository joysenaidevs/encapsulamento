using System;
using encapsulamento.classe;

namespace encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard(); //criei uma instancia "MasterCard"

            m.Parcelas = 12;
            Console.WriteLine(m.Bandeira);
            Console.WriteLine(m.Parcelas);

            


        }
    }
}
