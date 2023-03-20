using System;

namespace Wordplay
{
	public class FetchRandomWord
	{
		public string Url = "https://random-word-api.herokuapp.com/word";

		public string FetchWordFromApi()
		{
			var url = Url;

			HttpClient fetchWordClient = new HttpClient();
			var responseTask = fetchWordClient.GetAsync(url);
			responseTask.Wait();

            var fetchWordResult = responseTask.Result;

            if (fetchWordResult.IsSuccessStatusCode)
            {
                var fetchedWordTask = fetchWordResult.Content.ReadAsStringAsync();
                fetchedWordTask.Wait();

                var fetchedWord = fetchedWordTask.Result;

				char[] removeCharacters = { '[','"',']' };
				var trimmedFetchedWord = fetchedWord.Trim(removeCharacters);

				return trimmedFetchedWord;
            }
			else
			{
				var word = "xenaformatriceratroglodyte";
				return word;
			}
        }
	}
}

