
namespace portfolioVision.composants.grandTitre
{
    public partial class GrandTitre
    {
        [Microsoft.AspNetCore.Components.Parameter]
        public String Texte {  get; set; }

        protected async override Task OnInitializedAsync()
        {
            if (Texte == null)
            {
                Texte = "Pas de titre spécifié...";
            }

            base.OnInitializedAsync();
        }
    }
}
