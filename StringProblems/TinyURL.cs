using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// TinyURL
    /// </summary>
    public static class TinyURL
    {
        static string alphabet = "1234567890abcdefghijklmnopqustuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static Dictionary<string, string> map = new Dictionary<string, string>();
        static Random rand = new Random();

        static string key = GetRandomKey();

        /// <summary>
        /// Encodes a given URL to a TinyUrl
        /// with a new Key Generated
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public static string getTinyURL(string URL)
        {
            //Check if key already exists if not generate new key
            while (map.ContainsKey(key))
                key = GetRandomKey();

            map.Add(key, URL);

            return "http://TinyURL.com/" + key;
        }

        /// <summary>
        /// Decodes a given tinyURL to its original value
        /// </summary>
        /// <param name="tinyURL"></param>
        /// <returns></returns>
        public static string getOriginalURL(string tinyURL)
        {
            string outUrl;
            map.TryGetValue(tinyURL.Replace("http://TinyURL.com/", ""), out outUrl);
            return outUrl;
        }

        /// <summary>
        /// Generates the key based on 6 random characters from alphabet
        /// </summary>
        /// <returns></returns>
        public static string GetRandomKey()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 6; i ++)
            {
                sb.Append(alphabet[rand.Next(62)]);
            }
            return sb.ToString();
        }
    }
}
