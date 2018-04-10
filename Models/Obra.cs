using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Obra
    {
        public Obra(Obra obraEx) {
            this.CodObra = obraEx.CodObra;
            this.CodObraExterno = obraEx.CodObraExterno;
            this.Cliente = obraEx.Cliente;
            this.NomeObra = obraEx.NomeObra;
            this.Sigla = obraEx.Sigla;
            this.Tipo = obraEx.Tipo;
            this.DataIni = obraEx.DataIni;
            this.DataFim = obraEx.DataFim;
            this.CorLegendaObra = obraEx.CorLegendaObra;
            this.Status = obraEx.Status;
            this.Telefone1 = obraEx.Telefone1;
            this.Telefone2 = obraEx.Telefone2;
            this.Logradouro = obraEx.Logradouro;
            this.Numero = obraEx.Numero;
            this.Bairro = obraEx.Bairro;
            this.Cep = obraEx.Cep;
            this.Cidade = obraEx.Cidade;
            this.Estado = obraEx.Estado;
            this.Obsevacoes = obraEx.Obsevacoes;
            this.Datainicialold = obraEx.Datainicialold;
            this.Datafinalold = obraEx.Datafinalold;
            this.Delayprojeto = obraEx.Delayprojeto;
            this.Delayfabricacao = obraEx.Delayfabricacao;
            this.Delaylogistica = obraEx.Delaylogistica;
            this.Delaymontagem = obraEx.Delaymontagem;
            this.Cnpj = obraEx.Cnpj;
            this.Incsmunicipal = obraEx.Incsmunicipal;
            this.Cpf = obraEx.Cpf;
            this.Rg = obraEx.Rg;
            this.Organizacaovenda = obraEx.Organizacaovenda;
            this.Canaldistribuicao = obraEx.Canaldistribuicao;
            this.Qtdecargas = obraEx.Qtdecargas;
            this.Classeobra = obraEx.Classeobra;

        }

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
        public int Telefone1 { get; set; }
        public int Telefone2 { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public int Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Obsevacoes { get; set; }
        public string Datainicialold { get; set; }
        public string Datafinalold { get; set; }
        public string Delayprojeto { get; set; }
        public string Delayfabricacao { get; set; }
        public string Delaylogistica { get; set; }
        public string Delaymontagem { get; set; }
        public int Cnpj { get; set; }
        public int Incsmunicipal { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public string Organizacaovenda { get; set; }
        public string Canaldistribuicao { get; set; }
        public int Qtdecargas { get; set; }
        public string Classeobra { get; set; }







    }
}
