namespace OpenWeatherMapAPI
{
	public class API
	{
		private string openWeatherAPIKey;
		

		public API(string apiKey)
		{
			openWeatherAPIKey = apiKey;
		}
		

		public void UpdateAPIKey(string apiKey)
		{
			openWeatherAPIKey = apiKey;
		}

		//Returns null if invalid request
		public Query Query(string queryStr, string queryType)
		{
			Query newQuery = new Query(openWeatherAPIKey, queryStr, queryType);
			if (newQuery.ValidRequest)
				return newQuery;
			return null;
		}
	}
}
