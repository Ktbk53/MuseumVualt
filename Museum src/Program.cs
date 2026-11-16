namespace MuseumVault {

class Program {
    static void Main (string[] args) {
        Vault vault = new Vault (5);

        Painting monaLisa = new Painting ("Mona Lisa", 520 , "Leonardo da Vinci");
        Coin denarius = new Coin ("Denarius", 2237, "Amcient Rome" );
        Fossil trilobite = new Fossil ("Trilobite",300000000 , "Paleozoic Era");
        HistoricalDocument declarationOfIndependence = new HistoricalDocument("Declaration of Independence", 250, "English");

        vault.Store(monaLisa);
        vault.Store(denarius);
        vault.Store(trilobite);
        vault.Store(declarationOfIndependence);


        vault.DisplayAll();

        

    }
}
}