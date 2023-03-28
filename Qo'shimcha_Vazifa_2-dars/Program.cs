namespace Qoshimcha_Vazifa_2_dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            error:
            Console.Write("Row : ");
            string row = Console.ReadLine();
            bool tekshir = int.TryParse(row, out int row1 );
            if (!tekshir)
            {
                Console.Write($"!!! ERROR : {row}");
                goto error;
            }
            error1: 
            Console.Write("Col : ");
            string col = Console.ReadLine();
            bool tekshir1 = int.TryParse(col, out int col1);
            if (!tekshir)
            {
                Console.WriteLine($"!!! ERROR : {col}");
                goto error1;
            }
            for(int i = 0; i < row1; i++)
            {
                for(int j = 0; j < col1; j++)
                {
                    if ((j + i) % 2 == 0)
                    {
                        Console.Write(" + ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }     
        }        
    }
}