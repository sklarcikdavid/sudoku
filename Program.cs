using Sudoku_hra;

class Hra
{
    private hraciPlocha hraciPlocha = new hraciPlocha();

    public void Start()
    {
        hraciPlocha.generator();
        hraciPlocha.vypsaniPlochy();

        while (true)
        {
            Console.WriteLine("Zadej tah (sloupec, řádek, číslo): ");
            Console.ReadLine();
        }
    }
}