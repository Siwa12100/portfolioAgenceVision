using Microsoft.AspNetCore.Components;

namespace portfolioVision.composants.carteFortaits
{
    public partial class CarteForfaits
    {
        [Parameter]
        public String Titre { get; set; }

        [Parameter]
        public String Prix { get; set; }

        [Parameter]
        public List<String> Caracteristiques { get; set; }

        //public CarteForfaits(String Titre, String Prix, List<String> Caracteristiques) {
        
        //    this.Titre = Titre;
        //    this.Prix = Prix;
        //    this.Caracteristiques = Caracteristiques;
        
        //}

        protected async override Task OnInitializedAsync()
        {
            if (Caracteristiques == null)
            {
                Caracteristiques = new List<String>();
                Caracteristiques.Add("Liste de caractéristiques vide...");
            }

            if (Titre == null)
            {
                Titre = "Pas de titre renseigné...";
            }

            if (Prix == null)
            {
                Prix = "Pas de prix renseigné...";
            }

            base.OnInitializedAsync();
        }
    }
}
