using System;
namespace Algorithms
{
    public class ExtractURLParams
    {

        private string _url;

        public ExtractURLParams(string url)
        {
            _url = url;
        }

        public void ExtractUrlParams()
        {
            var urlParams = _url.Split('?')[1];

            var individualParams = urlParams.Split('&');

            foreach (var param in individualParams)
            {
                Console.WriteLine(param);
            }
        }
    }
}
