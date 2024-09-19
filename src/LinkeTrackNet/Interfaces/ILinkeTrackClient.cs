using LinkeTrackNet.Models;

namespace LinkeTrackNet.Interfaces
{
    public interface ILinkeTrackClient
    {
        /// <summary>
        /// Rastreia uma encomenda utilizando o código fornecido.
        /// </summary>
        /// <param name="code">Código de Rastreamento da Encomenda</param>
        /// <returns>Uma tarefa que representa a operação assíncrona. O resultado contém um <see cref="TrackResult"/>.</returns>
        /// <exception cref="ArgumentNullException">Ocorre quando o <paramref name="code"/> está nulo.</exception>
        /// <exception cref="ArgumentException">Ocorre quando o <paramref name="code"/> é inválidos.</exception>
        /// <example cref="HttpRequestException"><inheritdoc/></exception>
        Task<TrackResult> TrackAsync(string code);
    }
}
