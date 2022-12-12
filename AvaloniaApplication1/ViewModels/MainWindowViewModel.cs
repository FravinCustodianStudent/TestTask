
using System.Collections.Generic;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<Track> list { get; set; }

        public MainWindowViewModel()
        {
            list = new List<Track>();
            for (int i = 0; i < 3; i++)
            {
                list.Add(new Track()
                {
                    Name = i.ToString()
                });
            }
        }
    }
}