using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Play piano = new Play("the piano");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\piano.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            button1.Text = "Play"; // текст на кнопке
            label1.Text = " "; // текст на label
            label1.Font = new Font("Serif", 10, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            piano.Play_music("C://piano.wav"); // вызываем метод Play_piano класса Play
            label1.Text = "You are listening the play on " + piano.getPlayName() + "!";// текст на label
        }
    }
}