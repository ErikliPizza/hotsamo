using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
namespace Deneme
{

    public partial class Form1 : Form
    {



        public bool itsokay = false;
        OpenFileDialog of = new OpenFileDialog();
        string line = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).SetValue("Hotsamo", "\"" + Application.ExecutablePath + "\"");

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
 
        }

        private void test_Click(object sender, EventArgs e)
        {
  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName);
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        task1.Text = File.ReadLines(of.FileName).ElementAt(0);
                        task2.Text = File.ReadLines(of.FileName).ElementAt(1);
                        task3.Text = File.ReadLines(of.FileName).ElementAt(2);
                        task4.Text = File.ReadLines(of.FileName).ElementAt(3);
                        task5.Text = File.ReadLines(of.FileName).ElementAt(4);

                    }
                }
                sr.Close();
                itsokay = true;
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (itsokay == true)
            {
                if (e.KeyCode == Keys.NumPad1 && (e.Alt || e.Control || e.Shift))
                {
                    Process.Start(task1.Text);
                }
                if (e.KeyCode == Keys.NumPad2 && (e.Alt || e.Control || e.Shift))
                {
                    Process.Start(task2.Text);
                }
                if (e.KeyCode == Keys.NumPad3 && (e.Alt || e.Control || e.Shift))
                {
                    Process.Start(task3.Text);
                }
                if (e.KeyCode == Keys.NumPad4 && (e.Alt || e.Control || e.Shift))
                {
                    Process.Start(task4.Text);
                }
                if (e.KeyCode == Keys.NumPad5 && (e.Alt || e.Control || e.Shift))
                {
                    Process.Start(task5.Text);
                }
            }
        }


    }
}
