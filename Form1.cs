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
            Uri uri = null;
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Method = "GET";
            var response = request.GetResponse();
            uri = response.ResponseUri;
            uri.ToString();
            Stream stream = response.GetResponseStream();
            Image image = Image.FromStream(stream);

            

            /*int Width = image.Width;
            int Height = image.Height;*/


            //this.ClientSize= new System.Drawing.Size(Width+112, Height+24);

            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            stream.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = @"https://api.r10086.com/img-api.php?type=日本COS中国COS";
            SetPicBox(url);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = @"https://api.r10086.com/img-api.php?type=极品美女图片";
            SetPicBox(url);
        }
    }
}
