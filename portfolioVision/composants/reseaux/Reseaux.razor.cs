using Microsoft.AspNetCore.Components;
using portfolioVision.modele.reseau;

namespace portfolioVision.composants.reseaux
{
    public partial class Reseaux
    {
        [Parameter]
        public List<Reseau> ListeReseaux { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (ListeReseaux != null)
            {
                this.ListeReseaux = new List<Reseau>();
            }

            base.OnInitializedAsync();
        }

        protected override async Task OnParametersSetAsync()
        {
            Console.WriteLine("Passage dans le OnParameterSet ! ");

            foreach (Reseau r in this.ListeReseaux)
            {
                Console.WriteLine("img : " + r.EmplacementImage + " ; contenu : " + r.Contenu + ".");
            }
        }
    }
}
