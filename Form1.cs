using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAHAHA
{
    public partial class PicForm : Form
    {
        public PicForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = @"https://api.ixiaowai.cn/mcapi/mcapi.php";
            SetPicBox(url);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string url = @"https://api.ixiaowai.cn/api/api.php";
            SetPicBox(url);
        }

        public void SetPicBox(string url)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Method = "GET";
            var response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            Image image = Image.FromStream(stream);
            int Width = image.Width;
            int Height = image.Height;

            pictureBox1.Width = Width;
            pictureBox1.Height = Height;

            this.ClientSize= new System.Drawing.Size(Width+112, Height+24);

            pictureBox1.Image = image;
            stream.Close();
            //Console.WriteLine(image.ToString());
        }

        
    }
}
