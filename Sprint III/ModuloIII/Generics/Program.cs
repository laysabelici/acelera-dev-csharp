using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Generics
                DesenvolvimentoDeSoftware dev = new DesenvolvimentoDeSoftware();
                CalculoGenerico<DesenvolvimentoDeSoftware> calcDev = new CalculoGenerico<DesenvolvimentoDeSoftware>();
                calcDev.CalcularValorUnitario(dev);

                Console.WriteLine($"O valor final de desenv é {dev.ValorFinal}");


                CarroUsado carro = new CarroUsado();
                CalculoGenerico<CarroUsado> calcCarro = new CalculoGenerico<CarroUsado>();
                calcCarro.CalcularValorUnitario(carro);

                Console.WriteLine($"{carro.ValorFinal}");


                var texto = "Meu nome é Laysa??? Sim... sobrenome Belici";

                texto.ContadorDePalavras();

                Console.WriteLine($"{texto.ContadorDePalavras()}");

                //string erro = null;
                //erro.ContadorDePalavras();
            }
            catch (Exception ex)
            {
                throw new Exception($"Deu ruim => {ex.Message}");
            }

            finally
            {
                Console.WriteLine("Isso acontece independente de dar erro ou não");
            }
        }
    }
}
