# linketracknet
Interface amigável .net não oficial para a API do Link &amp; Track (https://linketrack.com)

## Configuração

Para utilizar a API, é preciso criar uma conta vinculada ao serviço [Link & Track](https://linketrack.com/).

Basta enviar um e-mail para [api@linketrack.com](mailto:api@linketrack.com), solicitando a autorização de uso.

## Utilização

```c#
using LinkeTrackNet;
using LinkeTrackNet.Models;

using LinkeTrackClient client = new("USER", "TOKEN");
TrackResult result = await client.TrackAsync("CÓDIGO");

// Use o resultado como desejar
Console.WriteLine(result.Code);
```

