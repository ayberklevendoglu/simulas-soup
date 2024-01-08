
SoupType GetSoupTypeInput()
{
    SoupType soupChoice;
    do
    {
        Console.WriteLine("What kind of soup do you want? Options are 'Soup', 'Stew', 'Gumbo'.");
        string input = Console.ReadLine().ToLower();
        soupChoice = input switch
        {
            "soup" => SoupType.Soup,
            "stew" => SoupType.Stew,
            "gumbo" => SoupType.Gumbo,
            _ => SoupType.Invalid
        };

        if (soupChoice == SoupType.Invalid)
            Console.WriteLine("That wasn't a valid option please try again.");

    } while (soupChoice == SoupType.Invalid);
    return soupChoice;
};


MainIngredient GetMainIngInput()
{
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
    return ingredientChoice;
};


Seasoning GetSeasoningInput()
{
    Seasoning seasoningChoice;
    do
    {
        Console.WriteLine("What kind of ingredient do you want? Options are 'Spicy', 'Salty', 'Sweet'.");
        string seasoning = Console.ReadLine().ToLower();
        seasoningChoice = seasoning switch
        {
            "spicy" => Seasoning.Spicy,
            "salty" => Seasoning.Salty,
            "sweet" => Seasoning.Sweet,
            _ => Seasoning.Invalid
        };

        if (seasoningChoice == Seasoning.Invalid)
            Console.WriteLine("That wasn't a valid option please try again.");

    } while (seasoningChoice == Seasoning.Invalid);
    return seasoningChoice;
};


(SoupType type,MainIngredient ingredient,Seasoning season) food = (GetSoupTypeInput(), GetMainIngInput(), GetSeasoningInput());

Console.WriteLine($"Congratz! You have made the {food.season} {food.ingredient} {food.type}.");

enum SoupType 
{
    Soup,
    Stew,
    Gumbo,
    Invalid
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
    Sweet,
    Invalid
}
