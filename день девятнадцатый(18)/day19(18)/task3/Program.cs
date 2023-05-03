namespace task3
{
    using System;
    using System.Collections.Generic;

    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        public Animal(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }

        public Animal Clone()
        {
            return new Animal(Name, Age, Species);
        }

        public override string ToString()
        {
            return $"{Name} ({Species}), {Age} years old";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание списка животных
            List<Animal> animals = new List<Animal>();

            // Добавление нескольких животных в список
            animals.Add(new Animal("Fido", 3, "Dog"));
            animals.Add(new Animal("Mittens", 2, "Cat"));
            animals.Add(new Animal("Fluffy", 1, "Rabbit"));

            // Вывод списка животных на экран
            Console.WriteLine("Animals:");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }

            // Клонирование животного
            Animal fidoClone = animals[0].Clone();
            Console.WriteLine($"Fido clone: {fidoClone}");

            // Удаление животного из списка
            animals.RemoveAt(1);
            Console.WriteLine("Animals after removing Mittens:");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }

            // Использование Dictionary
            Dictionary<string, Animal> animalDict = new Dictionary<string, Animal>();
            foreach (Animal animal in animals)
            {
                animalDict.Add(animal.Name, animal);
            }

            // Использование Nullable типа
            int? nullableInt = null;
            Console.WriteLine($"Nullable int: {nullableInt}");
        }
    }

}