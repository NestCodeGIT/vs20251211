namespace Binärzahlen_dozent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // int dezimal = Convert.ToInt32 (Console.ReadLine());

            int dezimal ;
            bool erfolg;
            do
            {
                Console.WriteLine(" Eingabe Dezimalzahl : ");
               erfolg = int.TryParse(Console.ReadLine(), out dezimal);

                //int dezimal= int.Parse(Console.ReadLine());
                // argomentnullexception 

                //  byte binear = 0;



            }while( erfolg ==false );



            int[] binear = new int[8];
            int cnt = 0;
            while (dezimal > 0)
            {
                cnt++;
                binear[binear.Length - cnt] = dezimal % 2;
                dezimal /= 2;
            }
            for (int i = 0; i < binear.Length; i++)
            {
                Console.WriteLine(binear[i]);
            }
            Console.WriteLine();
;
            }

        
    }
}
