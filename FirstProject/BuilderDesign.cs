using System;
using System.Collection.Generics;
// "Product" class
public class Meal
{
    public List<string> Items { get; private set; }

    public Meal()
    {
        Items = new List<string>();
    }

    public void AddItem(string item)
    {
        Items.Add(item);
    }

    public void ShowItems()
    {
        foreach (var item in Items)
        {
            Console.WriteLine($"Item: {item}");
        }
    }
}

// "Builder" abstract class
public abstract class MealBuilder
{
    protected Meal meal;

    public void CreateNewMeal()
    {
        meal = new Meal();
    }

    public Meal GetMeal()
    {
        return meal;
    }

    public abstract void BuildBurger();
    public abstract void BuildDrink();
    public abstract void BuildToy();
    public abstract void BuildFries();
}

// "ConcreteBuilder" class
public class KidsMealBuilder : MealBuilder
{
    public override void BuildBurger()
    {
        meal.AddItem("Kid's Burger");
    }

    public override void BuildDrink()
    {
        meal.AddItem("Small Drink");
    }

    public override void BuildToy()
    {
        meal.AddItem("Toy");
    }

    public override void BuildFries()
    {
        meal.AddItem("Small Fries");
    }
}

// "Director" class
public class Cashier
{
    private MealBuilder mealBuilder;

    public void SetMealBuilder(MealBuilder builder)
    {
        mealBuilder = builder;
    }

    public Meal GetMeal()
    {
        return mealBuilder.GetMeal();
    }

    public void ConstructMeal()
    {
        mealBuilder.CreateNewMeal();
        mealBuilder.BuildBurger();
        mealBuilder.BuildDrink();
        mealBuilder.BuildToy();
        mealBuilder.BuildFries();
    }
}

// "Client" class
class Customer
{
    static void Main(string[] args)
    {
        Cashier cashier = new Cashier();
        MealBuilder kidsMealBuilder = new KidsMealBuilder();

        cashier.SetMealBuilder(kidsMealBuilder);
        cashier.ConstructMeal();

        Meal meal = cashier.GetMeal();
        meal.ShowItems();
    }
}
