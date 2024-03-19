using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URL_Shortener
{
    public partial class Form1 : Form
    {
        private readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string originalUrl;
            do
            {
                originalUrl = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie die zu verkürzende URL ein:", "URL Shortener", "");
            } while (!IsValidUrl(originalUrl));

            string customAlias = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie den gewünschten Alias (optional) ein oder lassen Sie es leer:", "URL Shortener", "");

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://fast-url-shortener1.p.rapidapi.com/shorten"),
                Headers =
                {
                    { "X-RapidAPI-Key", "c943082d17mshbd35d2979817e91p1e50abjsn15a3cfac2b6e" },
                    { "X-RapidAPI-Host", "fast-url-shortener1.p.rapidapi.com" },
                },
                Content = new StringContent($"{{\"url\": \"{originalUrl}\", \"custom_alias\": \"{customAlias}\"}}")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };

            try
            {
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var shortenedUrl = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Verkürzte URL: " + shortenedUrl, "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler bei der Anfrage: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out _);
        }
    }
}
