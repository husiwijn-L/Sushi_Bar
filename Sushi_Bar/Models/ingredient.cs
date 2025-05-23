public class Ingredient
{
    public int Id { get; set; }              
    public string Name { get; set; }         
    public bool IsAllergen { get; set; }     
    
      public ICollection<Dish> Ingredients { get; set; } = new List<Dish>(); 
}