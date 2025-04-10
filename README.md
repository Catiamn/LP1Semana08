# Diagrama UML do MiniGame

```mermaid
classDiagram

    class Enemy { }

    class Player { }

    class Character {
        Name
        Weapon
    }

    class Weapon{
        float power()
    }

    class Gun{
        Ammo
        (float power, int ammo) : base(power)

        public void FireGun()
    }


    class Sword{
        BladeLength
        (float power, float bladeLength) : base(power)

        public void AttackWithSword()
    }


    class Program{
        +static void Main()

    }
    
    Player <-- Character
    Enemy <-- Character
    Character --> Weapon
    Weapon --|> Gun
    Weapon --|> Sword

    
    Character o-- Program 
```