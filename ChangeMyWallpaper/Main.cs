using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            SmallBasicProgram.SetWallpaper(keyword);


        }
    }

    internal sealed class SmallBasicProgram
    {
        private static Primitive assunto;
        private static Primitive foto;
        public static void SetWallpaper(String assunto)
        {
            SmallBasicApplication.BeginProgram();



            SmallBasicProgram.foto = Flickr.GetRandomPicture(assunto);
            Desktop.SetWallPaper(SmallBasicProgram.foto);

            GraphicsWindow.ShowMessage("Papel de parede mudado para" + SmallBasicProgram.assunto, "OK");

        }
    }
}
