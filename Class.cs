public class Handphone
{
    public String brand = "Iphone";
    public int pulse = 2500000;
}

// kalo ga pake constructor jadi objec biasa aja
public class Vehicle
{
    public int speed = 0;
    public string go()
    {
        return "The vehicle start going";
    }
}


public class Car : Vehicle
{
    public Car()
    {
        Color = "Purple";
        Brand = "BWM";
    }

    public string Brand { get; set; }
    public string Color { get; set; }
}

public class Motorbike : Vehicle
{
    public int wheel = 2;
}

public class Boat : Vehicle
{
    public int wheel = 0;
}

public class Message
{
    // if we use static it means immutable
    public static string Hello()
    {
        return "Hello welcome to the program";
    }
    public static string Waiting()
    {
        return "Im waiting for something that i dont know";
    }

    public static string Bye()
    {
        return "I have to say goodbye to you";
    }
}

public class Human
{
    public String name = "wibi";
    // integer by default is zero
    public int age;

    public string Eat()
    {
        return $"{name} is eating at the age of {age}";
    }

    public string Sleep()
    {
        return $"{name} is sleeping at the age of {age}";
    }
}

public class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }
    public static int totalAnimal;
    public Animal(string name, string color)
    {
        Name = name;
        Color = color;
        totalAnimal++;
    }

    public string Eat()
    {
        return $"that {Name} whic has {Color} color is eating";
    }

    public string Sleep()
    {
        return $"that {Name} which has {Color} color is sleeping";
    }
}


// kalo pake constructor bisa define sendiri sendiri
public class Plant
{
    public String name;
    public String color;
    public int amount;
    public static int totalPlant;

    public Plant(String name, String color, int amount)
    {
        this.name = name;
        this.color = color;
        this.amount = amount;
        totalPlant++;
    }

    public String Dying()
    {
        return $"{name} that have {color} color is dying";
    }

    public String CountPlant()
    {
        return $"{amount} plants have died during that accident";
    }

}

interface IPredator
{
    string Eat();
}

interface IPrey
{
    string Eaten();
}

public class Cat : IPrey
{
    public string Eaten()
    {
        return "cat is eaten by predator";
    }
}

public class Hawk : IPredator
{
    public string Eat()
    {
        return "hawk is eating the cat";
    }
}
public class Fish : IPrey, IPredator
{
    public string Eat()
    {
        return "fish eat smaller fish";
    }

    public string Eaten()
    {
        return "smaller fish is eaten by bigger fish";
    }
}

public class Player
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public static int totalPlayer;
    public Player(string userName, string password)
    {
        UserName = userName;
        Password = password;
        totalPlayer++;
    }
}



