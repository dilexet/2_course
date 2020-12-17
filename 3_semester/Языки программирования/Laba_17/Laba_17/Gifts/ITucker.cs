namespace Laba_17.Gifts
{
    public interface ITucker
    {
        string Name { get; set; }
        float Weight { get; set; }
        float Calorie { get; set; }
        double Price { get; set; }

        string GetTucker();
    }
}