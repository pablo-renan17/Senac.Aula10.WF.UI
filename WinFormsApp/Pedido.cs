namespace WinFormsApp1
{
    public class Pedido
    {
        // Id, Nome, Email, Senha
        //
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public decimal valorTotal { get; set; }
        public string FormaPagamento { get; set; }
        public string Status { get; set; }
    }
}