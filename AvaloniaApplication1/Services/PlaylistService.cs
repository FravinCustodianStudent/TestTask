using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AvaloniaApplication1.Models;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AvaloniaApplication1.Services
{
    public class PlaylistService
    {

        public async Task<Playlist> GetPlaylist(string url)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            await Task.Delay(3000);
            var page = driver.PageSource;
            var elements = driver.FindElement(By.TagName("music-text-row"));

            return null;
        }
    }
}
