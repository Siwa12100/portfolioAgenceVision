using portfolioVision.modele.reseau;

namespace portfolioVision.Pages.Index
{
    public partial class Index
    {


        private String TitreCarte1;
        private String TitreCarte2;

        private String PrixCarte1;
        private String PrixCarte2;

        private List<String> CaracteristiquesCarte1;
        private List<String> CaracteristiquesCarte2;

        private List<Reseau> Reseaux;


        protected override async Task OnInitializedAsync()
        {
            
            await this.InitialisationCartes();
            await this.InitialisationReseaux();

            Console.WriteLine("Passage dans le index.razor.cs ! ");

            foreach (Reseau r in this.Reseaux)
            {
                Console.WriteLine("img : " + r.EmplacementImage + " ; contenu : " + r.Contenu + ".");
            }


            base.OnInitializedAsync();
        }

        private async Task InitialisationCartes()
        {
            this.TitreCarte1 = "Format court";
            this.TitreCarte2 = "Format long";

            this.PrixCarte1 = "19,99€";
            this.PrixCarte2 = "24,99€";

            this.CaracteristiquesCarte1 = new List<String>();
            this.CaracteristiquesCarte2 = new List<String>();

            this.CaracteristiquesCarte1.Add("Montage de base (coupe et fusion des rushs),");
            this.CaracteristiquesCarte1.Add("Etalonnage des couleurs,");
            this.CaracteristiquesCarte1.Add("Conception sonore et mixage,");
            this.CaracteristiquesCarte1.Add("Animations Graphiques,");
            this.CaracteristiquesCarte1.Add("Sous-titrage,");
            this.CaracteristiquesCarte1.Add("Adaptation à la charte graphique,");
            this.CaracteristiquesCarte1.Add("Jusqu'à 15 minutes de rushs fournis,");
            this.CaracteristiquesCarte1.Add("Jusqu'à 2 minutes de durée finale,");
            this.CaracteristiquesCarte1.Add("Livraison sous 48 heures.");

            this.CaracteristiquesCarte2.Add("Montage de base (coupe et fusion des rushs),");
            this.CaracteristiquesCarte2.Add("Etalonnage des couleurs,");
            this.CaracteristiquesCarte2.Add("Conception sonore et mixage,");
            this.CaracteristiquesCarte2.Add("Animations Graphiques,");
            this.CaracteristiquesCarte2.Add("Sous-titrage,");
            this.CaracteristiquesCarte2.Add("Adaptation à la charte graphique,");
            this.CaracteristiquesCarte2.Add("Pas de limite de rushs fournis,");
            this.CaracteristiquesCarte2.Add("Pas de limite de durée finale.");
        }

        private async Task InitialisationReseaux()
        {

            
            this.Reseaux = new List<Reseau>();
            this.Reseaux.Add(new Reseau("/images/Fichier2.png", "azogs.vision@gmail.com"));
            this.Reseaux.Add(new Reseau("/images/Fichier3.png", "06.45.82.11.37"));
            this.Reseaux.Add(new Reseau("/images/Fichier4.png", "azogs_"));

        }
    }
}
