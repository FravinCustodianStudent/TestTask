using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AvaloniaApplication1.Models;
using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AvaloniaApplication1.Services
{
    public class PlaylistService
    {
        
        public async Task<Playlist> GetPlaylist(string url)
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            //Waiting for full load of page
            await Task.Delay(5000);


            Playlist playlist;

            try
            {
                //Get general information about playlist by get head element of page
                var header = driver.FindElement(By.TagName("music-detail-header"));

                //Create Playlist
                playlist = Playlist.Create()
                    .WithName(header.GetAttribute("headline"))
                    .WithAvatar(header.GetAttribute("image-src"))
                    .WithDescription(header.GetAttribute("secondary-text"))
                    .WithTracks()
                    .Build();

                //Adding tracks to playlist
                var tracks = driver.FindElements(By.TagName("music-image-row"));
                foreach (var musicRow in tracks)
                {
                    //Finding a values for track from website
                    var trackName = musicRow.FindElement(By.ClassName("col1")).Text;
                    var artistName = musicRow.FindElement(By.ClassName("col2")).FindElements(By.TagName("music-link")).First().Text;
                    var albumName = musicRow.FindElement(By.ClassName("col2")).FindElements(By.TagName("music-link")).Last().Text;
                    var Duration = musicRow.FindElement(By.ClassName("col4")).Text;
                    playlist.Tracks.Add(new Track()
                    {
                        Name = trackName,
                        Duration = Duration,
                        ArtistName = artistName,
                        AlbumName = albumName
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            

            return playlist;
        }
    }
}
