    using System;
    using System.Linq;

    namespace MuseumVault
    {
        public class Vault<T> where T: class, IArtifact
        {
            private T[] items;

            public int Count => items.OfType<T>().Count();

            public Vault(int capacity)
            {
                items = new T[capacity];
            }

            public bool Store(T item)
            {
                if (Count >= items.Length)
                {
                    Console.WriteLine($"Vault is full!! \"{item.Name}\" not stored");
                    return false;
                }

                items[Count] = item;
                Console.WriteLine($"Stored \"{item.Name}\" successfully.");
                return true;
            }
        

        public T? Retrieve(int index)
        {
            if (index < 0 || index >= Count)
            {
                Console.WriteLine($"Error: index {index} is invalid. The vault holds {Count} items.");
                return null;
            }
            return items[index];
        }

        public void DisplayAll()
        {
            Console.WriteLine("Vault Contents");

            var stored = items
                .OfType<T>()
                .Select((artifact, index) => new {artifact, index})
                .ToList();
            
            if (!stored.Any())
            {
                Console.WriteLine("The Vault is empty.");
                return;
            }

            foreach (var entry in stored)
            {
                Console.WriteLine($"[{entry.index}] {entry.artifact.Name} - approximately {entry.artifact.EstimatedAgeYears:N0} years old");

                Console.WriteLine($"{entry.artifact.Describe()}");
            }
        }
    }
}