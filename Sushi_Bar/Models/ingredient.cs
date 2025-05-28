using System.ComponentModel.DataAnnotations;

public class Ingredient
{

    [Display(Name = "ID")]
    public int Id { get; set; }

    [Display(Name = "Имя")]
    public string Name { get; set; }

    [Display(Name = "Аллерген")]
    public bool IsAllergen { get; set; }     
    
      public ICollection<Dish> Ingredients { get; set; } = new List<Dish>(); 
}