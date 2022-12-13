
using System.Collections.Generic;
using AvaloniaApplication1.Models;
using AvaloniaApplication1.Services;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public Playlist Playlist { get; set; }
        public List<Track> list { get; set; }

        public MainWindowViewModel()
        {
            PlaylistService service= new PlaylistService();
            var s = service.GetPlaylist(@"https://music.amazon.com/albums/B0BLH6NR6N");
            Playlist = new Playlist();
            Playlist.Name = "example";
            Playlist.AvatarUrl = "url";
            Playlist.Description = "description";
            
            Playlist.Tracks = new List<Track>();
            for (int i = 0; i < 3; i++)
            {
                Playlist.Tracks.Add(new Track()
                {
                    Name = i.ToString(),
                    ArtistName = (i+2).ToString(),
                    AlbumName = (i+3).ToString(),
                    Duration = (i+4).ToString()
                });
            }
        }
    }
}