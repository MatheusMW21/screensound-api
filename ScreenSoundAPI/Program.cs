using ScreenSoundAPI.Model;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{   
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;
        musicas[1998].Exibir();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Não foi possível processar a requisão - {ex.Message}");
    }
}
