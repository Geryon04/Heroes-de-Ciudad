using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Template_Method
{
   public abstract class TemplateMethod
    {
        public void Method( IInfartable i)
        {
            this.AnalizarBoca();
            this.EstadoDelPaciente();

            if (!i.estasConciente())
            {
                this.LlamarAmbulancia();
                this.DescubrirTorax();
                this.AcomodarCabeza();
                while (!i.estasRespirando())
                {
                    this.CompresionToraxica();
                    this.HacerInsuflaciones();
                    while (!i.tenesRitmoCardiaco())
                    {
                        this.Desfibrilador();
                    }
                }
            }
        }

        public abstract void AnalizarBoca();
        public abstract void EstadoDelPaciente();
        public abstract void LlamarAmbulancia();
        public abstract void DescubrirTorax();
        public abstract void AcomodarCabeza();
        public abstract void CompresionToraxica();
        public abstract void HacerInsuflaciones();
        public abstract void Desfibrilador();
    }
}
