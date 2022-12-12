using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication1.Models
{
    public class Playlist
    {
        public List<Track> Tracks { get; set; }
        public string Name { get; set; }

        public string AvatarUrl { get; set; }
        public string Description { get; set; }
    }
}
