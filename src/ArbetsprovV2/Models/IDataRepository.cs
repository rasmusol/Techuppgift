using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ArbetsprovV2.Models.ViewModels;

namespace ArbetsprovV2.Models
{
    public interface IDataRepository
    {
        List<Song> GetSongs(SongViewModel args);
        List<Artist> GetArtists(ArtistViewModel args);
    }
}
