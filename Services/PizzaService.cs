using ContosoPizza.Models;
namespace ContosoPizza.Services;
public static class PizzaService 
{
    static List<Pizza> Pizzas {get;}
    static int nextId = 3;
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza {Id = 1, Name ="Classic" , IsGlutenFree = false},
            new Pizza {Id = 2, Name ="Veggie" , IsGlutenFree = true}
        };
    }
    public static List<Pizza> GetAll() => Pizzas;  
    public static Pizza? Get(int Id) => Pizzas.FirstOrDefault(p => p.Id == Id);
    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    } 
    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if(index == -1)
        return;
        Pizzas[index] = pizza;
    }   
}