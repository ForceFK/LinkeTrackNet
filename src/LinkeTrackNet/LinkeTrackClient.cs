using LinkeTrackNet.Interfaces;
using LinkeTrackNet.Models;
using System.Net.Http.Json;
using System.Text.RegularExpressions;

namespace LinkeTrackNet
{
    public class LinkeTrackClient : ILinkeTrackClient, IDisposable
    {
        private const string ApiEndpoint = "https://api.linketrack.com";
        private readonly HttpClient _httpClient;
        private bool disposedValue;
        private readonly string _user, _token;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="LinkeTrackClient"/>.
        /// </summary>
        /// <param name="user">Nome de usuário</param>
        /// <param name="token">Token do usuário</param>
        /// <exception cref="ArgumentNullException">Ocorre quando o <paramref name="user"/> ou <paramref name="token"/> estão inválidos.</exception>
        public LinkeTrackClient(string user, string token)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentNullException(nameof(token));

            _user = user;
            _token = token;
            _httpClient = new()
            {
                BaseAddress = new Uri(ApiEndpoint, UriKind.Absolute)
            };
        }

        /// <inheritdoc/>
        public Task<TrackResult> TrackAsync(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentNullException(nameof(code));

            if (!Regex.IsMatch(code, @"[a-z]{2}\d{9}[a-z]{2}", RegexOptions.IgnoreCase))
                throw new ArgumentException("Código Incorreto: O código de Rastreamento é composto de 13 dígitos, começando com 2 letras seguidas de 9 letras e de mais 2 letras.", nameof(code));

            return _httpClient.GetFromJsonAsync<TrackResult>($"track/json?user={_user}&token={_token}&codigo={code}")!;
        }

        /// <inheritdoc cref="Dispose()"/>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _httpClient.Dispose();
                }

                disposedValue = true;
            }
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
