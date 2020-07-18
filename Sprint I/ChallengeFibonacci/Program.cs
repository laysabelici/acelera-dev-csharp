using System.Collections.Generic;

namespace ChallengeFibonacci
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            List<int> valor = new List<int>();
            int num1 = 0;
            int num2 = 1;
            int soma = num1 + num2;

            valor.Add(num1);
            valor.Add(num2);

            while (soma <= 350)
            {
                valor.Add(soma);

                num1 = num2;
                num2 = soma;

                soma = num1 + num2;
            }
            return valor;
        }
        
        public bool IsFibonacci(int result)
        {
            if(result == 0||result == 1)
            {
                return true;
            }
            int num1 = 0;
            int num2 = 1;
            int soma = num1 + num2;

            while(soma<=result)
            {
                if(result==soma)
                {
                    return true;
                }
                num1 = num2;
                num2 = soma;

                soma = num1 + num2;
            }
            return false;
        }
    }
}
