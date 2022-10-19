namespace SegundaOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Televisao t = new Televisao();

            while (true)
            {
                Console.WriteLine("Olá!\nDeseja ligar o equipamento?");
                Console.WriteLine("Digite 1 para ligar.\nDigite 2 para desligar.\nDigite 3 para verificar o status.\nDigite 4 para sair");
                op = int.Parse(Console.ReadLine());
                //Eletronico e = new Eletronico();
                if (op == 1)
                {
                    //if (t.VerificaLigado())
                    if(t.Ligado)
                    {
                        Console.WriteLine("Já está ligado!!!");
                    }
                    else
                    {
                        t.Ligar();
                    }
                }
                else if (op == 2)
                {
                    //if (!t.VerificaLigado())
                    if(!t.Ligado)
                    {
                        Console.WriteLine("Já está desligado!");
                    }
                    else
                    {
                        t.Desligar();
                    }
                }
                else if (op == 3)
                {
                    //if (!t.VerificaLigado())
                    if(!t.Ligado)
                    {
                        Console.WriteLine("Aparelho está desligado!!");
                    }
                    else
                    {
                        Console.WriteLine("Aparelho está ligado!!");
                    }
                }
                else if (op == 4)
                {
                    break;
                }
            }

        }
    }
}