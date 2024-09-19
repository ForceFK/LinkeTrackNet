using LinkeTrackNet;
using LinkeTrackNet.Models;

//Os exemplos abaixo utilizam o usuário teste.
//Para solicitar um novo usuário e token envie e-mail para api@linketrack.com
//Mais informações: https://github.com/chipytux/correiosApi
using LinkeTrackClient client = new("teste", "1abcd00b2731640e886fb41a8a9671ad1434c599dbaa0a0de9a5aa619f29a83f");

TrackResult result = await client.TrackAsync("LX002249507BR");

// Use o resultado como desejar
Console.WriteLine(result.Code);
