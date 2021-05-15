namespace Laba_5
{
    public class AdjacencyRib
    {
        public static int CountRib { get; set; }
        public int RibsNumber { get; }
        public int[] AdjacencyRibs { get; }

        public AdjacencyRib(int ribsNumber, int[] adjacencyRibs)
        {
            RibsNumber = ribsNumber;
            AdjacencyRibs = adjacencyRibs;
        }
    }
}