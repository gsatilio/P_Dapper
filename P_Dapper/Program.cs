using Controllers;
using Models;

Pedido pedido = new Pedido
{
    Id = 1,
    Descricao = "Quero tudo",
    Mesa = 10
};

if (new PedidoController().Inserir(pedido))
{
    Console.WriteLine("Inseriu tudo!");
}
else
{
    Console.WriteLine("ERRO");
}