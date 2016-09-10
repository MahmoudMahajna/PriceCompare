namespace PriceCompare.Model.Interfaces
{
    public interface IItemCart
    {
        long ItemCode { get; set; }
        int CartId { get; set; }
        string ItemName { get; set; }
        int Count { get; set; }
        Item Item { get; set; }
        Cart Cart { get; set; }
    }
}