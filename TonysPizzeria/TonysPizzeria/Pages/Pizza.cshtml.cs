using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TonysPizzeria.Models;

namespace TonysPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4},

            new PizzasModel(){
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                FinalPrice=8},

             new PizzasModel(){
                ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=12},
             new PizzasModel(){
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pineapple=true,
                FinalPrice=10},
            new PizzasModel(){
                ImageTitle="Bolognese",
                PizzaName="Bolognese",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=7},
            new PizzasModel(){
                ImageTitle="Seafood",
                PizzaName="Seafood",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=13 },
            new PizzasModel(){
                ImageTitle="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=5},
            new PizzasModel(){
                ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                Ham=true,
                FinalPrice=10}

        };
        public void OnGet()
        {
        }
    }
}
