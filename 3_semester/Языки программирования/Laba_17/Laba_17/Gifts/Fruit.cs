namespace Laba_17.Gifts
{
    public class Fruit : ITucker
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public float Calorie { get; set; }
        public double Price { get; set; }
        
        public bool IsVitaminC { get; set; }
        public bool IsVitaminA { get; set; }

        public Fruit(
            string name, 
            float weight, 
            float calorie, 
            double price,
            bool isVitaminC,
            bool isVitaminA)
        {
            Name = name;
            Weight = weight;
            Calorie = calorie;
            Price = price;
            IsVitaminC = isVitaminC;
            IsVitaminA = isVitaminA;
        }
        
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Weight: {Weight} грамм\n" +
                   $"Calorie: {Calorie} ккалл/100 грамм\n" +
                   $"Price: {Price} $ за 1 кг\n" +
                   $"Vitamin C: {IsVitaminC}\n" +
                   $"Vitamin A: {IsVitaminA}\n";
        }
        
        public string GetTucker()
        {
            return $"{Name}\t{Weight}\t{Calorie}\t{Price}\t{IsVitaminC}\t{IsVitaminA}";
        }
    }
}