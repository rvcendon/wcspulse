using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCS_Pulse
{
    public class repAvaliacao
    {
        public int      id                   { get; set; }
        public string   data_avaliacao       { get; set; }
        public int      idade                { get; set; }
        public int      peso                 { get; set; }
        public int      altura               { get; set; }
        public string   nivel_atividade      { get; set; }
        public decimal  gordura              { get; set; }
        public decimal  vo2                  { get; set; }
        public string   descricao_atividade  { get; set; }
        public string   observacoes          { get; set; }
        public int      fc_max               { get; set; }
        public int      fc_min               { get; set; }
        public int      fc_med               { get; set; }
        public int      kcal                 { get; set; }
        public int      fc_basal             { get; set; }
        public int      tmb                  { get; set; }
        public string   nome                 { get; set; }
        public string   dt_nascimento        { get; set; }
        public string   sexo                 { get; set; }
        public DateTime dthr_medida          { get; set; }
        public int      fc                   { get; set; }
        public int      imc                  { get; set; }

        public repAvaliacao() { }
    }
}

