public class Order
{
    public int Id { get; set; }                       
    public ICollection<Dish> Dishes { get; set; } = new List<Dish>();   
    public DateTime OrderTime { get; set; }          
    public string CustomerName { get; set; }          
    public string DeliveryAddress { get; set; }       
    public decimal TotalPrice => Dishes.Sum(d => d.Price); 
}