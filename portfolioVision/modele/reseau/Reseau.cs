namespace portfolioVision.modele.reseau
{
    public class Reseau
    {
        public String EmplacementImage { get; set; }
        public String Contenu {  get; set; }

        public Reseau(String Emplacement, String Contenu)
        {
            this.EmplacementImage = Emplacement;
            this.Contenu = Contenu;
        }
    }
}
