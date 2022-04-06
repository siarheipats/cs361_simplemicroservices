using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microservices_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getImageButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\CS361\prng-service.txt", "run 0");
            Thread.Sleep(1500);
            string prng_text = File.ReadAllText(@"C:\CS361\prng-service.txt");
            File.WriteAllText(@"C:\CS361\image-service.txt", prng_text);
            label1.Text = "Waiting";
            Thread.Sleep(1500);
            string img_path = File.ReadAllText(@"C:\CS361\image-service.txt");
            label1.Text = "Path: " + img_path;
            Thread.Sleep(1500);
            imageBox.Image = Image.FromFile(img_path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
