using System;

namespace Laba_5
{
    public class IncidentRibs: IComparable
    {
        public int V { get; }
        public int W { get; }
        
        public static int CountTops { get; set; }
        public static int CountRibs { get; set; }

        public IncidentRibs(int v, int w)
        {
            V = v;
            W = w;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (V * 397) ^ W;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj is IncidentRibs ribs)
                return V.CompareTo(ribs.V);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}