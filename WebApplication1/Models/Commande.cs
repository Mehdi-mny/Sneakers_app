namespace WebApplication1.Models
{
    public class Commande
    {
        public int Id { get; set; } 
        public String adresse {  get; set; }   
        public Panier panier { get; set; } 

    }
}
