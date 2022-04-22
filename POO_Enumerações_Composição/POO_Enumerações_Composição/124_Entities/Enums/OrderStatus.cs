namespace POO_Enumerações_Composição.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0, // pagamento pendente
        Processing = 1, // processando
        Shipped = 2, // enviado
        Delivered = 3 // entregue
    }
}
