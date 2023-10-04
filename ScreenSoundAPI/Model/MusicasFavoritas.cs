namespace ScreenSoundAPI.Model;

internal class MusicasFavoritas
{
    public string? Nome { get; set; }
    public List<Musica> Musicas { get; }

    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        Musicas = new List<Musica>();
    }

    public void Adicionar(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void Exibir()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }
}
