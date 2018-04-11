using DataAccess.Contrato;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccess.Servicos
{
    public class ObrasRepositoy : IObrasRepository
    {
        
        private static string connString  = @"Data Source=PLANNIXSERVER\SQL2008R2;
            Initial Catalog=TEA1101;
            User Id=sa;
            Password=plannix@2016;";


        public void Inserir(Obra obra)
        {
            SqlConnection conn = new SqlConnection(connString);
            string sql = @"INSERT INTO POBRAS VALUES ( @Codobra,
            @Codobraexterno,
            @Cliente, 
            @Nomeobra,
            @Sigla,
            @Tipo,
            @Dataini,
            @Datafim, 
            @Corlegendaobra, 
            @Status, 
            @Telefone1, 
            @Telefone2,
            @Logradouro,
            @Numero, 
            @Bairro, 
            @Cep,
            @Cidade, 
            @Estado,
            @Observacoes,
            @Datainicialold,
            @Datafinalold,
            @Delayprojeto,
            @Delayfabricacao,
            @Delaylogistica,
            @Delaymontagem,
            @Cnpj, 
            @Inscestadual, 
            @Inscmunicipal, 
            @Cpf, 
            @Rg,
            @Organizacaovenda,
            @Canaldistribuicao,
            @Qtdecargas,
            @Classobra)";

            conn.Open();
            conn.Execute(sql, obra);
            conn.Close();
            
        }

        public List<Obra> ShowObra()
        {
            SqlConnection conn = new SqlConnection(connString);

            string sql = @"SELECT * FROM POBRAS";

            conn.Open();
           
            List<Obra> ObrasLista = (List<Obra>)conn.Query<Obra>(sql);
            conn.Close();

            return ObrasLista;
           
        }
    }
}
