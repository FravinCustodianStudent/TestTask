using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.Helpers
{
    public class PlaylistBuilder
    {
        private readonly Playlist root = new Playlist();

        public PlaylistBuilder WithName(string name)
        {
            root.Name = name;
            return this;
        }
        public PlaylistBuilder WithAvatar(string url)
        {
            root.AvatarUrl = url;
            return this;
        }
        public PlaylistBuilder WithDescription(string description)
        {
            root.Description = description;
            return this;
        }
        public PlaylistBuilder WithTracks()
        {
            root.Tracks = new List<Track>();
            return this;
        }

        public Playlist Build() => root;

        public static implicit operator Playlist(PlaylistBuilder builder)
        {
            return builder.root;
        }
    }
}
