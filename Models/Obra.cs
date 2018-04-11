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
        public string Observacoes { get; set; }
        public string DataInicialOld { get; set; }
        public string DataFinalOld { get; set; }
        public int DelayProjeto { get; set; }
        public int DelayFabricacao { get; set; }
        public int DelayLogistica { get; set; }
        public int DelayMontagem { get; set; }
        public string Cnpj { get; set; }
        public string InscEstadual { get; set; }
        public string InscMunicipal { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string OrganizacaoVenda { get; set; }
        public string CanalDistribuicao { get; set; }
        public int QtdeCargas { get; set; }
        public Char ClassObra { get; set; }
    }
}
