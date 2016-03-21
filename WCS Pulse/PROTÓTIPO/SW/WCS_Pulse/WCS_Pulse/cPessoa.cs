using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCS_Pulse
{
    public class cPessoa
    {
        private cBroker broker;

        public int ID { get; set; }
        public string sNome { get; set; }
        public string sSexo { get; set; }
        public DateTime dtDataNasc { get; set; }

        public bool CarregaPessoa(){
            broker = new cBroker();
            return broker.MaterializaPessoa(this);
        }

        public int ListarPessoas(ref string [][]list) {
            broker = new cBroker();
            return broker.ListarPessoas(this, ref list);
        }

        public bool InserePessoa()
        {
            broker = new cBroker();
            return broker.DesmaterializaPessoa(this);
        }
    }
}
