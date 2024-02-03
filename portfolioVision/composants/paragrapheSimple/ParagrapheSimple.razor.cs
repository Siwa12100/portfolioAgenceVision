using Microsoft.AspNetCore.Components;

namespace portfolioVision.composants.paragrapheSimple
{
    public partial class ParagrapheSimple
    {

        [Parameter]
        public String Texte {  get; set; }

        protected async override Task OnInitializedAsync()
        {
            if (Texte == null)
            {
                Texte = "Pas de texte spécifié...";
            }

            base.OnInitializedAsync();
        }
    }
}
