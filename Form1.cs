using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;

using System.Windows.Forms;
using Microsoft.Web.WebView2.Wpf;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();

        public Form1()
        {
            InitializeComponent();
            InitBrowser();
            this.Resize += new System.EventHandler(this.Form_Resize);

            webView21.CoreWebView2InitializationCompleted += OnWebViewInitializationComplete;
        }

        public void OnWebViewInitializationComplete(object sender, EventArgs e) 
        {
            webView21.CoreWebView2.SourceChanged += CoreWebView2_SourceChanged;
            webView21.CoreWebView2.Settings.IsStatusBarEnabled = false;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);

        }

        private async Task initialize()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albums = albumsDAO.getAllAlbums();

            //connect the list to the grid view control
            albumBindingSource.DataSource = albums;
            dataGridView1.DataSource = albumBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.SearchTitles(textBox1.Text);
            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            //get the row number of the clicked cell
            int rowClicked = dataGridView.CurrentRow.Index;
            //MessageBox.Show($"You clicked row {rowClicked}");

            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            //MessageBox.Show($"URL={imageURL}");
            pictureBox1.Load(imageURL);



            tracksBindingSource.DataSource = albums[rowClicked].Tracks;
            dataGridView2.DataSource = tracksBindingSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //add a new item to the database
            Album album = new Album
            {
                AlbumName = txt_albumArtist.Text,
                ArtistName = txt_albumArtist.Text,
                Year = Int32.Parse(txt_albumYear.Text),
                ImageURL = txt_ImageURL.Text,
                Description = txt_description.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneAlbum(album);
            MessageBox.Show($"{result} new row(s) inserted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView2.CurrentRow.Index;
            //MessageBox.Show($"You clicked row {rowClicked}");
            int trackID = (int)dataGridView2.Rows[rowClicked].Cells[0].Value;
            //MessageBox.Show("ID of track" + trackID);

            AlbumsDAO albumsDAO = new AlbumsDAO();

            int result = albumsDAO.deleteTrack(trackID);

            //MessageBox.Show("Result " + result);

            dataGridView2.DataSource = null;
            albums = albumsDAO.getAllAlbums();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int rowClicked = dataGridView.CurrentRow.Index;
            //MessageBox.Show($"You clicked row {rowClicked}");
            String videoURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.SourceChanged += CoreWebView2_SourceChanged;
            }
        }

        private void CoreWebView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int rowClicked = dataGridView.CurrentRow.Index;
            //MessageBox.Show($"You clicked row {rowClicked}");
            String videoURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();
            webView21.Source = new Uri(videoURL);
            webView21.CoreWebView2.NavigateToString(videoURL);
        }

        /*private void NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            webView21.
        }
        //TODO: find out why navigating doesn't work*/
    }
}