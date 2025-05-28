using System.Collections;
using System.ComponentModel.DataAnnotations;

public class Dish
{
    [Display (Name = "ID")]
    public int Id { get; set; }

    [Display(Name = "Блюда")]
    public string Name { get; set; }

    [Display(Name = "Описание")]
    public string Description { get; set; }

    [Display(Name = "Цена")]
    public decimal Price { get; set; }       
    public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>(); 
 
}
