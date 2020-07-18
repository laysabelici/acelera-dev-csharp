using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //MODIFICADORES DE ACESSO
            //public: O acesso não é restrito
            //private: O acesso é limitado ao tipo de recipiente
            //protected: O acesso é limitado à classe que os contém
            //internal: O acesso é limitado ao assembly atual

            //protected internal: acesso é limitado ao assembly atual
            //ou aos tipos derivados da classe que os contém

            //private protected: acesso é limitado à classe que o contém
            //ou a tipos derivados da classe que o contém no assemby atual

            ClassPublic publica = new ClassPublic();
            //publica.MinhaPropInternal;


        }
    }
}
