using System.Net;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API_callsCatDog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += Button1_Click;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (var webClient = new WebClient()) {
                var json = webClient.DownloadString("https://api.thecatapi.com/v1/images/search");
                var catImg = JsonConvert.DeserializeObject<List<Cat>>(json);
                var catUrl = catImg[0].url;
                pictureBox1.Height = 400;
                pictureBox1.Width = 400;
                pictureBox1.Location = new Point(0,0);
                pictureBox1.Load(catUrl);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}