namespace S2_Demo_Modele.Models
{
    public class ListeEtudiants
    {
        //Liste de données statique pour simuler la base de données
        public static List<Etudiant> GetEtudiants()
        {
            return new List<Etudiant>{
                new Etudiant("Alex", 1234567),
                new Etudiant("Emilie", 1111111),
                new Etudiant("Julie", 2222222),
                new Etudiant("Martin", 3333333)
            };
        }
    }
}
