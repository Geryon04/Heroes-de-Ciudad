using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Template_Method
{
    public class RealizarRCP : TemplateMethod
    {
        public override void AcomodarCabeza()
        {
            Console.WriteLine("Acomodando la cabeza del paciente");
        }

        public override void AnalizarBoca()
        {
            Console.WriteLine("Abri la boca");
        }

        public override void CompresionToraxica()
        {
            Console.WriteLine("Iniciando compresiones");
        }

        public override void DescubrirTorax()
        {
            Console.WriteLine("Descubriendo el torax");
        }

        public override void Desfibrilador()
        {
            Console.WriteLine("Desfibrilando al paciente. Despejen!!!");
        }

        public override void EstadoDelPaciente()
        {
            Console.WriteLine("Estas consciente?");
        }

        public override void HacerInsuflaciones()
        {
            Console.WriteLine("Realizando insuflaciones al paciente");
        }

        public override void LlamarAmbulancia()
        {
            Console.WriteLine("Llamando a una ambulancia");
        }
    }
}
