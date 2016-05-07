using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using ArbetsprovV2.Models.ViewModels;

namespace ArbetsprovV2.Models
{
    public class DataManager : IDataRepository
    {
        private HttpWebRequest request;
        private string postData;
        private string apiUrl;
        private NameValueCollection outgoingQueryString;

        public DataManager()
        {
            outgoingQueryString = HttpUtility.ParseQueryString(String.Empty);
            outgoingQueryString.Add("api_key", "6DVLSUX99YDAESKAX");
            //postData = outgoingQueryString.ToString();
            apiUrl = "http://developer.echonest.com/api/v4/";
           // request = (HttpWebRequest)WebRequest.Create("http://developer.echonest.com/api/v4/");
        }

        public List<Song> GetSongs(SongViewModel args)
        {

            if (!string.IsNullOrEmpty(args.ArtistName) && !string.IsNullOrEmpty(args.Title))
                outgoingQueryString.Add("combined", args.ArtistName + "&" +args.Title);

            else if(!string.IsNullOrEmpty(args.ArtistName) && string.IsNullOrEmpty(args.Title))
            outgoingQueryString.Add("artist", args.ArtistName);

            else if (string.IsNullOrEmpty(args.ArtistName) && !string.IsNullOrEmpty(args.Title))
                outgoingQueryString.Add("title", args.Title);

            string postData = outgoingQueryString.ToString();
            request = (HttpWebRequest)WebRequest.Create(apiUrl + "song/search?" +  postData);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var songRequest = JsonConvert.DeserializeObject<SongRequest>(responseString);
            List<Song> songsList = songRequest.Response.Song;
            return songsList;
        }

        public List<Artist> GetArtists(ArtistViewModel args)
        {
            outgoingQueryString.Add("bucket", "hotttnesss");

            if (!string.IsNullOrEmpty(args.Name))
                outgoingQueryString.Add("name", args.Name);

            string postData = outgoingQueryString.ToString();
            request = (HttpWebRequest)WebRequest.Create(apiUrl + "genre/artists?" + postData);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var artistsRequest = JsonConvert.DeserializeObject<ArtistRequest>(responseString);
            List<Artist> artistsList = artistsRequest.Response.Artists;
            return artistsList;
        } 
    }
}