using System.ComponentModel.DataAnnotations;

public class Order
{

    [Display(Name = "ID")]
    public int Id { get; set; }                       
    public ICollection<Dish> Dishes { get; set; } = new List<Dish>();

    [Display(Name = "Время заказа")]
    public DateTime OrderTime { get; set; }

    [Display(Name = "Имя клиента")]
    public string CustomerName { get; set; }

    [Display(Name = "Адрес доставки")]
    public string DeliveryAddress { get; set; }       
    public decimal TotalPrice => Dishes.Sum(d => d.Price); 
}