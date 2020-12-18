using System.IO;

namespace Laba_17
{
    internal class Program
    {
        public static void Main()
        {
            Gift gift;
            
            using (StreamReader streamReader = new StreamReader(
                    @"C:\Users\dilexet\Documents\GitHub\2_course\3_semester\Языки программирования\Laba_17\Laba_17\bin\Debug\input.txt"))
            {
                var tuckers = Gift.ReadFile(streamReader);
                gift = new Gift(ref tuckers);
            }
            
            using (StreamWriter streamWriter = new StreamWriter(
                    @"C:\Users\dilexet\Documents\GitHub\2_course\3_semester\Языки программирования\Laba_17\Laba_17\bin\Debug\output.txt", 
                    false))
            {
                gift.WriteFile(streamWriter);
            }
        }
    }
}