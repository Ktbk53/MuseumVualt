namespace MuseumVault
{

    class Program
    {
        static void Main(string[] args)
        {
            Vault<IArtifact> vault = new Vault<IArtifact>(5);
            Console.WriteLine( "Vault count is " + vault.Count);
            Painting monaLisa = new Painting("Mona Lisa", 520, "Leonardo da Vinci");
            Coin denarius = new Coin("Denarius", 2237, "Ancient Rome");
            Fossil trilobite = new Fossil("Trilobite", 300000000, "Paleozoic Era");
            HistoricalDocument declarationOfIndependence = new HistoricalDocument("Declaration of Independence", 250, "English");

            vault.Store(monaLisa);
            vault.Store(denarius);
            vault.Store(trilobite);
            vault.Store(declarationOfIndependence);
            Console.WriteLine( "\nVault count is " + vault.Count);

            vault.DisplayAll();

            IArtifact? retrievedItem = vault.Retrieve(1);


            if (retrievedItem != null)
            {
                Console.WriteLine("\nRetrieved item: " + retrievedItem.Name);
            }
           












        }
    }
}