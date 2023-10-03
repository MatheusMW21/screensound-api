using ScreenSoundAPI.Model;

namespace ScreenSoundAPI.Filters;

internal class LinqOrder
{
    public static void Artistas(List<Musica> musicas)
    {
        var artistas = musicas.OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista).Distinct().ToList() ;

        Console.WriteLine("Lista de Artistas Ordenados");

        foreach (var artista in artistas)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
