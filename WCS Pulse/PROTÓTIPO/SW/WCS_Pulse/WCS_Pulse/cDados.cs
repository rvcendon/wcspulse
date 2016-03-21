using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCS_Pulse
{
    public class cDados
    {
        private cBroker broker;

        public int id { get; set; }
        public int id_avaliacao { get; set; }
        public DateTime data { get; set; }
        public int fc { get; set; }

        public cDados() { 

        }

        public int ListarPessoas(ref cDados []list)
        {
            broker = new cBroker();
            return broker.ListarDados(this, ref list);
        }

        public bool InsereDado()
        {
            broker = new cBroker();
            return broker.DesmaterializaDado(this);
        }
    }
}
