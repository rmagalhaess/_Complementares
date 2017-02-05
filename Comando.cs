using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Desligar
{
    class Comando
    {
        // ===========================================================================
            Process Processo = null;
            ProcessStartInfo Parametros = null;
        
        // ===========================================================================
        public Comando()
        {
            this.Processo = new Process();
            this.Parametros = new ProcessStartInfo();

            this.Parametros.WindowStyle = ProcessWindowStyle.Hidden;
            this.Parametros.FileName = "cmd.exe";
        }

        // ===========================================================================
        public bool Executar( string p_Comando )
        {
            // Variáveis:
                bool Executar = false;

            // Programa
                this.Parametros.Arguments = p_Comando;
                this.Processo.StartInfo = this.Parametros;
                Executar = this.Processo.Start();
            /*
                MessageBox.Show( p_Comando, 
                                 "Comando",
                                 MessageBoxButtons.OKCancel, 
                                 MessageBoxIcon.Asterisk);
            */

            // Fim
                return Executar;
        }

    }
}
