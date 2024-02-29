public class Handphone
{
    public String brand = "Iphone";
    public int pulse = 2500000;
}


public class Car
{
    public Car()
    {
        Color = "Purple";
        Brand = "BWM";
    }

    public string Brand { get; set; }
    public string Color { get; set; }
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
        return $"{name} is eating at the age of {age}";
    }
}

public class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }
    public Animal(string name, string color)
    {
        Name = name;
        Color = color;
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



