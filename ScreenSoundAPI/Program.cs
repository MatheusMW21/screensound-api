using ScreenSoundAPI.Filters;
using ScreenSoundAPI.Model;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{   
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;

        //LinqFilter.FiltrarGenero(musicas);
        //LinqOrder.Artistas(musicas);
        LinqFilter.ArtistaGenero(musicas, "blues");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Não foi possível processar a requisão - {ex.Message}");
    }
}
