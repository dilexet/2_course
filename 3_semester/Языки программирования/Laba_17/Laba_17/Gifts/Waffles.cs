namespace Laba_17.Gifts
{
    public class Waffles : ITucker
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public float Calorie { get; set; }
        public double Price { get; set; }

        public string Flavor { get; set; }
        public bool IsGlase { get; set; }
        
        public Waffles(
            string name, 
            float weight, 
            float calorie, 
            double price,
            string flavor,
            bool isGlase)
        {
            Name = name;
            Weight = weight;
            Calorie = calorie;
            Price = price;
            Flavor = flavor;
            IsGlase = isGlase;
        }
        
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Weight: {Weight} грамм\n" +
                   $"Calorie: {Calorie} ккалл/100 грамм\n" +
                   $"Price: {Price} $ за 1 кг\n" +
                   $"Flavor: {Flavor}\n" +
                   $"Glass: {IsGlase}\n";
        }

        public string GetTucker()
        {
            return $"{Name}\t{Weight}\t{Calorie}\t{Price}\t{Flavor}\t{IsGlase}";
        }
    }
}