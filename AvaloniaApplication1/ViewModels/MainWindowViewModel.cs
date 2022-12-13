
using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using AvaloniaApplication1.Models;
using AvaloniaApplication1.Services;
using ReactiveUI;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase,IActivatableViewModel
    {
        public Task<Playlist> Playlist => SetPlaylist(@"https://music.amazon.com/playlists/B01M11SBC8");


        public MainWindowViewModel() : base()
        {
            Activator = new ViewModelActivator();
        }

        private void WhenActivated(Action<Action<IDisposable>> block)
        {
            throw new NotImplementedException();
        }

        async public Task<Playlist> SetPlaylist(string url)
        {
            PlaylistService service = new PlaylistService();
            var result = await service.GetPlaylist(url);

            return result;
        }

        public ViewModelActivator Activator { get; }
    }
}