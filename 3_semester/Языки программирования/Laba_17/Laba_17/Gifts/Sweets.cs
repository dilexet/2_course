namespace Laba_17.Gifts
{
    public class Sweets : ITucker
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public float Calorie { get; set; }
        public double Price { get; set; }
        
        public float CocoaPercentage { get; set; }
        public string Filling { get; set; }
       
        public Sweets(
            string name, 
            float weight, 
            float calorie, 
            double price,
            float cocoaPercentage,
            string filling)
        {
            Name = name;
            Weight = weight;
            Calorie = calorie;
            Price = price;
            
            CocoaPercentage = cocoaPercentage;
            Filling = filling;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Weight: {Weight} грамм\n" +
                   $"Calorie: {Calorie} ккалл/100 грамм\n" +
                   $"Price: {Price} $ за 1 кг\n" +
                   $"CocoaPercentage: {CocoaPercentage} %\n" +
                   $"Filleng: {Filling}\n";
        }
        public string GetTucker()
        {
            return $"{Name}\t{Weight}\t{Calorie}\t{Price}\t{CocoaPercentage}\t{Filling}";
        }
    }
}