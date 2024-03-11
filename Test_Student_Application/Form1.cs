using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test_Student_Application
{
    public partial class Form1 : Form
    {
        OpenFileDialog fd1 = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog obj = new OpenFileDialog();
            
                obj.FilterIndex = 1;
                DialogResult file = obj.ShowDialog();
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(obj.FileName);
                   // this.l,  = imageToByteArray(System.Drawing.Image.FromFile(obj.FileName));
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

