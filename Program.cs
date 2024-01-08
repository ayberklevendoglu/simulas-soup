Console.WriteLine("What kind of soup do you want? Options are 'Soup', 'Stew', 'Gumbo'.");
string input = Console.ReadLine().ToLower();
FoodType soupChoice = input switch
{
    "soup" => FoodType.Soup,
    "stew" => FoodType.Stew,
    "gumbo" => FoodType.Gumbo
};


MainIngredient ingredientChoice;
do
{
    Console.WriteLine("What kind of ingredient do you want? Options are 'Mushrooms', 'Chicken', 'Carrots', 'Potatoes'.");
    string ingredient = Console.ReadLine().ToLower();
    ingredientChoice = ingredient switch
    {
        "mushrooms" or "mushroom" => MainIngredient.Mushroom,
        "chicken" => MainIngredient.Chicken,
        "carrots" or "carrot" => MainIngredient.Carrot,
        "potatoes" or "potato" => MainIngredient.Potato,
        _ => MainIngredient.Invalid
    };
    if (ingredientChoice == MainIngredient.Invalid)
        Console.WriteLine("That wasn't a valid option please try again.");

} while (ingredientChoice == MainIngredient.Invalid);


Console.WriteLine("What kind of ingredient do you want? Options are 'Spicy', 'Salty', 'Sweet'.");
string seasoning = Console.ReadLine().ToLower();
Seasoning seasoningChoice = seasoning switch
{
    "spicy" => Seasoning.Spicy,
    "salty" => Seasoning.Salty,
    "sweet" => Seasoning.Sweet
};


(FoodType type,MainIngredient ingredient,Seasoning season) soup = (soupChoice, ingredientChoice, seasoningChoice);

Console.WriteLine($"Congratz! You have made the {soup.season} {soup.ingredient} {soup.type}.");

enum FoodType 
{
    Soup,
    Stew,
    Gumbo
}

enum MainIngredient
{
    Mushroom,
    Chicken,
    Carrot,
    Potato,
    Invalid
}

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
}
