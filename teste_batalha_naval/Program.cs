using teste_batalha_naval;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player();

        //colocando navio
        player.InsertShip(0, 0);

        //atrando no navio
        Console.WriteLine(player.Shot(0,0));// esperado valor 2 


    }
}