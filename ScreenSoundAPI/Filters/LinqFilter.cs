using ScreenSoundAPI.Model;

namespace ScreenSoundAPI.Filters;

internal class LinqFilter
{
    public static void FiltrarGenero(List<Musica> musicas)
    {
        var todosGeneros = musicas.Select(generos => 
        generos.Genero).Distinct().ToList();

        foreach(var genero in todosGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }
}
