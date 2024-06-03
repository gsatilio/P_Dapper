using Microsoft.Data.SqlClient;
using Models;
using Dapper;
namespace Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private string Conn {  get; set; }
        public PedidoRepository()
        {
            Conn = "Data Source=127.0.0.1; Initial Catalog=dbRestaurante; User Id=SA; Password=SqlServer2019!;TrustServerCertificate=True";
        }

        public bool Inserir(Pedido pedido)
        {
            var status = false;
            using(var db = new SqlConnection (Conn))
            {
                db.Open();
                db.Execute("INSERT INTO TB_PEDIDO (Descricao, Mesa) VALUES (@Descricao, @Mesa)", pedido);
                status = true;
            }
            return status;
        }
    }
}
