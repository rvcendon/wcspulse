using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCS_Pulse
{
    public class cAvaliacao
    {
        private cBroker broker;

        public int id { get; set; }
        public int id_pessoa { get; set; }
        public DateTime data_hora { get; set; }
        public int idade { get; set; }
        public float peso { get; set; }
        public float altura { get; set; }
        public int nivel_atividade { get; set; }
        public float gordura { get; set; }
        public float vo2 { get; set; }
        public string atividade { get; set; }
        public string observacoes { get; set; }
        public int fc_max { get; set; }
        public int fc_min { get; set; }
        public int fc_med { get; set; }
        public int fc_basal { get; set; }
        public int tmb { get; set; }

        public cDados[] fcs { get; set; }

        public cAvaliacao() { 

        }

        public bool CarregaAvaliacao()
        {
            broker = new cBroker();
           // return broker.MaterializaAvaliacao(this);
            return false;
        }

        public int ListarAvaliacoes(ref string[][] list)
        {
            broker = new cBroker();
           // return broker.ListarAvaliacoes(this, ref list);
            return 0;
        }

        public int InsereAvaliacao()
        {
            broker = new cBroker();
            return broker.DesmaterializaAvaliacao(this);
        }

        public bool ExcluirAvaliacao()
        {
            broker = new cBroker();
           // return broker.ExcluirAvaliacao(this);
            return false;
        }

    }
}
