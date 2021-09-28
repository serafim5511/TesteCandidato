using EntitiesTesteCandidato;
using Giganti.Konsiga.CoreAPIClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi
{
    public partial class ApiCep: ApiClient
    {
        public ApiCep(Uri baseEndpoint)
        {
            BaseEndpoint = baseEndpoint ?? throw new ArgumentNullException("baseEndpoint");
        }

        public async Task<Cep> LoginDentista(Dentistas dentista)
        {
            var requestUrl = CreateRequestUri(
                           string.Format(System.Globalization.CultureInfo.InvariantCulture, "Dentistas/LoginDentista"));
            return await PostAsync<Dentistas>(requestUrl, dentista);
        }
    }
}
