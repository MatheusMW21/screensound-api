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

    public static void ArtistaGenero(List<Musica> musicas, string genero)
    {
        var artistas = musicas.Where(m => m.Genero!.Contains(genero)).Select(m => m.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");

        foreach(var artista in artistas) 
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void ArtistaMusica(List<Musica> musicas, string artista)
    {
        var artistas = musicas.Where(m => m.Artista!.Equals(artista)).ToList();
        Console.WriteLine(artista);

        foreach(var musica in artistas)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void AnoMusica(List<Musica> musicas, int ano)
    {
        var musicasAno = musicas.Where(m => m.Ano == ano).OrderBy(m => m.Nome).Select(m => m.Nome)
            .Distinct().ToList();

        Console.WriteLine($"Músicas de {ano}");

        foreach (var musica in musicasAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
