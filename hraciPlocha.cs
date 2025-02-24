using System.ComponentModel.Design;

namespace Sudoku_hra
{
    class hraciPlocha
    {

        public int[,] mrizka = new int[9, 9];
        private Random nahodne = new Random();

        public void generator()
        {
            Console.WriteLine("Jakou chceš obtížnost? [1 - jednoduchá, 2 - střední, 3 - těžká]");
            int obtiznost = Convert.ToInt32(Console.ReadKey());
            if (obtiznost == 1)
            {
                vyplneniPlochy();
                odstraneniCisel(20);
            } else if (obtiznost == 2)
            {
                vyplneniPlochy();
                odstraneniCisel(30);
            } else
            {
                vyplneniPlochy();
                odstraneniCisel(40);
            }
            
        }

        private bool vyplneniPlochy()
        {
            for (int radek = 0; radek < 9; radek++) 
            {
                for (int sloupec = 0; sloupec < 9; sloupec++) 
                {
                    if (mrizka[radek, sloupec] == 0)
                    {
                        for (int cislo = 1; cislo <= 9; cislo++)
                        {
                            int nahodneCislo = nahodne.Next(1, 10);
                            if (validaceTahu(radek, sloupec, nahodneCislo))
                            {
                                mrizka[radek, sloupec] = nahodneCislo;

                                if(vyplneniPlochy())
                                {
                                    return true;
                                }
                                mrizka[radek, sloupec] = 0;
                            }
                        }
                    } 
                    return false;
                }
            }
            return true;
        }

        private void odstraneniCisel(int pocet)
        {
            int odstraneni = 0;
            while (odstraneni < pocet) 
            {
                int radek = nahodne.Next(0, 9);
                int sloupec = nahodne.Next(0, 9);

                if (mrizka[radek, sloupec] != 0)
                {
                    mrizka[radek, sloupec] = 0;
                    odstraneni++;
                }
            }
        }

        public void vypsaniPlochy()
        {
            // logika pro vypis plochy
        }

        public bool validaceTahu(int radek, int sloupec, int cisloUzivatele)
        {

            return true;
        }
    }
}
