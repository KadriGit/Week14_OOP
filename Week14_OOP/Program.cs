
Dog GoodBoy = new Dog("Good Boy");

Console.WriteLine($"Name: {GoodBoy.Name}; Level og the happiness: {GoodBoy.LevelOfHappiness}");

GoodBoy.Bark();
Console.WriteLine($"Name: {GoodBoy.Name}; Level og the happiness: {GoodBoy.LevelOfHappiness}");


while (GoodBoy.LevelOfHappiness < 5)
{
    GoodBoy.Bark();
}
GoodBoy.Wag();


class Dog
{
    public string Name;
    public int LevelOfHappiness;

    public Dog(string Name)
    {
        Name = Name;
        LevelOfHappiness = 0;
        Console.WriteLine($"{Name} is your friend now.");
    }

    public void Bark()
    {
        LevelOfHappiness++;
        Console.WriteLine("Whoof-whoof!");
    }

    public void Wag()
    {
        LevelOfHappiness++;
        Console.WriteLine($"{Name} starts wagging it's tail");
        Console.WriteLine("Whoosh-whoosh");
    }
}