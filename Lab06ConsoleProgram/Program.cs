namespace Lab06ConsoleProgram
{
    public abstract class Animal       //public access modifier     //base class  //bastract class
    {

        public abstract string Name { get; set; }     //abstract properity
        public abstract int Age { get; set; }          //abstract preoperity


        public virtual string Food { get; set; }     //virtual preoperity
        public virtual string Habitat { get; set; }      //virtual preoperity

        public Animal(string name, int age,string food,string habitat)
        {
            Name = name;
            Age = age;
            Food = food;
            Habitat = habitat;
        }

        public abstract string Eat();     //abstract method
        public abstract string Sleep();   //abstract method
        public abstract string Sound();   //abstract method
    }

    // Mammal class inheriting from Animal
    public abstract class Mammal : Animal    //public access modifier    //abstract class
    {
        //override Abstract
        public override string Name { get; set; }
        public override int Age { get; set; }

        //override Virtual
        public override string Food { get; set; }
        public override string Habitat { get; set; }
        public Mammal(string name, int age, string food, string habitat) : base(name, age, food,habitat)
        {
            Name = name;
            Age = age;
            Food=food;
            Habitat = habitat;
        }

        public virtual void GiveBirth()        //Virtual method
        {
            Console.WriteLine($"Mammal animals gives birth to live cubs.");
        }       
    }

    // Reptile class inheriting from Animal
    public abstract class Reptile : Animal     //public access modifier    //abstract class
    {

        //override abstract
        public override string Name { get; set; }
        public override int Age { get; set; }

        //override virsual
        public override string Food { get; set; }
        public override string Habitat { get; set; }
        public Reptile(string name, int age, string food, string habitat) : base(name, age, food, habitat)
        {
            Name = name;
            Age = age;
            Food = food;
            Habitat=habitat;
        }

        public virtual void LayEggs()   //Virtual method
        {
            Console.WriteLine($"Reptile animals lays eggs.");
        }     
    }

    // Concrete classes implementing specific animals

    // Lion class inheriting from Mammal
    public class Lion : Mammal      //public access modifier
    {
        public Lion(string name, int age, string food, string habitat) : base(name, age, food, habitat)
        {
        }

        public override string Eat()       //override method
        {
            return "Lions eat meat";
        }

        public override string Sleep()     //override method
        {
            return "Lion is Sleeping";
        }

        public override string Sound()     //override method
        {
            return "Lion's sound is roaring";
        }

        public override void GiveBirth()     //override method
        {
            Console.WriteLine($"{Name} the Lion gives birth to live cubs.");
        }
    }

    // Tiger class inheriting from Mammal
    public class Tiger : Mammal        //public access modifier
    {
        public Tiger(string name, int age, string food, string habitat) : base(name, age, food, habitat)
        {
        }

        public override string Eat()       //override method
        {
            return "Tiger eats meat";
        }

        public override string Sleep()     //override method
        {
            return "Tiger is sleeping";
        }

        public override string Sound()     //override method
        {
           return "Tiger's sound is roaring";
        }

        public override void GiveBirth()     //override method
        {
            Console.WriteLine($"{Name} the Tiger gives birth to live cubs.");
        }
    }


    // Snake class inheriting from Reptile
    public class Snake : Reptile    //public access modifier
    {
        public Snake(string name, int age, string food, string habitat) : base(name, age, food, habitat)
        {
        }

        public override string Eat()      //override method
        {
            return "Snake is eating";
        }

        public override string Sleep()     //override method
        {
            return "Snake is sleeping";
        }

        public override string Sound()      //override method
        {
            return "Snake's sound is hissing";
        }
        public override void LayEggs()      //override method
        {
            Console.WriteLine($"{Name} the Snake lays eggs.");
        }
    }

    // Snake class inheriting from Reptile
    public class Crocodile : Reptile         //public access moifier
    {
        public Crocodile(string name, int age, string food, string habitat) : base(name, age, food, habitat)
        {
        }

        public override string Eat()      //override method
        {
           return "Crocodile is eating";
        }

        public override string Sleep()     //override method
        {
            return "Crocodile is sleeping";
        }

        public override string Sound()      //override method
        {
            return "Crocodile's sound is hissing";
        }
        public override void LayEggs()      //override method
        {
            Console.WriteLine($"{Name} the Crocodile lays eggs.");
        }
    }

    // Bird class inheriting from Animal
    public abstract class Bird : Animal        //public access modifier    //abstract class
    {
        //override abstract
        public override string Name { get; set; }
        public override int Age { get; set; }

        //override virsual
        public override string Food { get; set; }
        public override string Habitat { get; set; }

        public Bird(string name, int age, string food, string habitat) : base(name, age, food, habitat)
        {
            Name = name;
            Age = age;
            Food = food;
            Habitat = habitat;
        }

        public abstract void Fly();       //abstract method
    }

    // Eagle class inheriting from Bird
    public class Eagle : Bird       //public access modifier
    {
        public Eagle(string name, int age, string food, string habitat) : base(name, age, food, habitat)
        {
        }

        public override string Eat()        //override method
        {
            return "Eagle is eating";
        }

        public override string Sleep()      //override method
        {
            return "Eagle is sleeping";
        }

        public override string Sound()       //override method
        {
            return "Eagle's sound is Pealing";
        }

        public override void Fly()       //override method
        {
            Console.WriteLine($"{Name} the Eagle is flying.");
        }
    }

    // Penguin class inheriting from Bird
    public class Penguin : Bird            //public access modifier
    {
        public Penguin(string name,int age, string food, string habitat) : base(name, age, food, habitat)
        {
        }

        public override string Eat()     //override method
        {
            return "Penguin is eating";
        }

        public override string Sleep()      //override method
        {
            return "Penguin is sleeping";
        }

        public override string Sound()       //override method
        {
            return "Penguin's sound is honking";
        }
        public override void Fly()       //override method
        {
            Console.WriteLine($"{Name} the Penguin cannot fly.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate concrete animals
            Lion lion = new Lion("Simba",15,"Meat","Zoo");
            Tiger tiger = new Tiger("Tony", 15, "Meat", "Zoo");
            Snake snake = new Snake("Nagini", 15, "Meat", "Zoo");
            Crocodile crocodile = new Crocodile("Species", 15, "Meat", "Zoo");
            Eagle eagle = new Eagle("Aquila", 15, "Meat", "Zoo");
            Penguin penguin = new Penguin("Pingu", 15, "Meat", "Zoo");

            // Call methods and demonstrate inheritance
            Console.WriteLine(lion.Eat());
            Console.WriteLine(lion.Sleep());
            Console.WriteLine(lion.Sound());
            lion.GiveBirth();

            Console.WriteLine();

            Console.WriteLine(tiger.Eat()); 
            Console.WriteLine(tiger.Sleep()); 
            Console.WriteLine(tiger.Sound()); 
            tiger.GiveBirth();

            Console.WriteLine();

            Console.WriteLine(snake.Eat()); 
            Console.WriteLine(snake.Sleep()); 
            Console.WriteLine(snake.Sound()); 
            snake.LayEggs();

            Console.WriteLine();

            Console.WriteLine(crocodile.Eat()); 
            Console.WriteLine(crocodile.Sleep()); 
            Console.WriteLine(crocodile.Sound()); 
            crocodile.LayEggs();

            Console.WriteLine();

            Console.WriteLine(eagle.Eat()); 
            Console.WriteLine(eagle.Sleep()); 
            Console.WriteLine(eagle.Sound()); 
            eagle.Fly();

            Console.WriteLine();

            Console.WriteLine(penguin.Eat()); 
            Console.WriteLine(penguin.Sleep()); 
            Console.WriteLine(penguin.Sound()); 
            penguin.Fly();

            Console.ReadKey();
        }
    }
}