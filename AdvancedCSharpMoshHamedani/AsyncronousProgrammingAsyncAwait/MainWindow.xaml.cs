using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncronousProgrammingAsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ButtonSync_Click(object sender, RoutedEventArgs e)
        {
            DownloadHtml(@"http://msdn.microsoft.com");
            var html = GetHtml(@"http://msdn.microsoft.com");

            MessageBox.Show(html.Substring(0, 10));
        }

        private async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();

            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"c:\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        private void DownloadHtml(string url)
        {
            var webClient = new WebClient();

            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"c:\result.html"))
            {
                streamWriter.Write(html);
            }
        }

        public async void ButtonAsync_Click(object sender, RoutedEventArgs e)
        {
            await DownloadHtmlAsync(@"http://msdn.microsoft.com");
            var html = await GetHtmlAsync(@"http://msdn.microsoft.com");

            MessageBox.Show(html.Substring(0, 10));
        }

        private string GetHtml(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }

        private async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
