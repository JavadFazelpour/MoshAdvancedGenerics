using System.IO;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsynchronousProgramming;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void Button_Click(object sender, RoutedEventArgs e)
    {
        string url = @"https://news.yahoo.com/?guccounter=1&guce_referrer=aHR0cHM6Ly93d3cuZ29vZ2xlLmNvbS8&guce_referrer_sig=AQAAAJ6qSEDurdjk9-lzt9wyqAs05mwWHzCu12QwVP8PSmDIddsACqgCi95MBg4HcZ3BmuEgxxGLbZCJBYuw1lt3TUsSSVdCPuf_80meMm5T7xiFOgGK5jvp9Qn2e-f1HasXLej2pfQyE71r3mmYZ6wbSZiGV54Q7mm2mjbVJ9h9tMhP";
        //DownloadHtmlAsync(url);
        //var html =await GetHtmlAsync(url);
        var getHtmlTask =  GetHtmlAsync(url);
        MessageBox.Show("Waiting for the task to compelete.");

        var html = await getHtmlTask;
        MessageBox.Show(html.Substring(0, 10));
    }
    public async Task<string> GetHtmlAsync(string url)
    {
        var webClient = new WebClient();
        return await webClient.DownloadStringTaskAsync(url);
    }
    public string GetHtml(string url)
    {
        var webClient = new WebClient();
        return webClient.DownloadString(url);
    }
    public async Task DownloadHtmlAsync(string url)
    {
        var webClient = new WebClient();
        var html = await webClient.DownloadStringTaskAsync(url);

        using (var streamWriter = new StreamWriter(@"D:\html.txt"))
        {
            await streamWriter.WriteAsync(html);
        }
    }


    public void DownloadHtml(string url)
    {
        var webClient = new WebClient();
        var html = webClient.DownloadString(url);
        using (var streamWriter = new StreamWriter(@"D:\html.txt"))
        {
            streamWriter.Write(html);
        }
    }
}