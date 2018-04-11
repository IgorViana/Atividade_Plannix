using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    
    public class Obra
    { 
        public int CodObra { get; set; }
        public string CodObraExterno { get; set; }
        public string Cliente { get; set; }
        public string NomeObra { get; set; }
        public string Sigla { get; set; }
        public string Tipo { get; set; }
        public string DataIni { get; set; }
        public string DataFim { get; set; }
        public string CorLegendaObra { get; set; }
        public int Status { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Obsevacoes { get; set; }
        public string Datainicialold { get; set; }
        public string Datafinalold { get; set; }
        public int Delayprojeto { get; set; }
        public int Delayfabricacao { get; set; }
        public int Delaylogistica { get; set; }
        public int Delaymontagem { get; set; }
        public string Cnpj { get; set; }
        public string Incsestadual { get; set; }
        public string Incsmunicipal { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Organizacaovenda { get; set; }
        public string Canaldistribuicao { get; set; }
        public int Qtdecargas { get; set; }
        public Char Classeobra { get; set; }
    }
}
