using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivo
{
    public class chamada_de_outro_arquivo
    {

        public static void NaoMain()
        {

            Recursive recursivo = new Recursive();

            recursivo.Recursivao();

            Console.WriteLine("Caralho eu to usando dois arquivos que foda");

        }

    }
}
