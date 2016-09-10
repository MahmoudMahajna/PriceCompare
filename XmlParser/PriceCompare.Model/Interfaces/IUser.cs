namespace PriceCompare.Model.Interfaces
{
    public interface IUser
    {
        int UserId { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Name { get; set; }
        int CartId { get; set; }
        Cart Cart { get; set; }
    }
}
