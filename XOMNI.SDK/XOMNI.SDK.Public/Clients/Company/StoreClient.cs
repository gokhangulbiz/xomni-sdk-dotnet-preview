using System;
using System.Net.Http;
using System.Threading.Tasks;
using XOMNI.SDK.Public.Clients;
using XOMNI.SDK.Public.Models;
using XOMNI.SDK.Public.Models.Company;
using XOMNI.SDK.Public.Extensions;

namespace XOMNI.SDK.Public.Clients.Company
{
	public class StoreClient : BaseClient
	{
		public StoreClient(HttpClient httpClient)
			: base(httpClient)
		{

		}

        public async Task<ApiResponse<PaginatedContainer<Store>>> GetAsync(string locationInfo, int searchDistance, int skip, int take)
		{
            Validator.For(locationInfo, "locationInfo").NotNull().IsEmpty().Contains(';');
            Validator.For(searchDistance, "searchDistance").InRange(0, 1);
            Validator.For(skip, "skip").IsGreaterThanOrEqual(0);
            Validator.For(take, "take").IsGreaterThanOrEqual(1);

			string path = string.Format("/company/stores?locationInfo={0}&searchDistance={1}&skip={2}&take={3}", locationInfo, searchDistance, skip, take);

			using (var response = await Client.GetAsync(path).ConfigureAwait(false))
			{
                return await response.Content.ReadAsAsync<ApiResponse<PaginatedContainer<Store>>>().ConfigureAwait(false);
			}
		}
	}
}