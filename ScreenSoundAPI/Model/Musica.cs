using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Model;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName ("artist")]
    public string Artista { get; set; }

    [JsonPropertyName("year")]
    public string? AnoString { get; set; }

    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void Exibir()
    {
        Console.WriteLine($"Artista:{Artista}\nMúsica: {Nome}\nAno: {Ano}\nGênero: {Genero}");
    }

}
