using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;


namespace meracomplier
{
    public partial class Form1 : Form
    {

        Machine Machine = new Machine();
        public Form1()
        {
            InitializeComponent();
            Machine.OnStateProcessed += UpdateCompilerWatch;
            Machine.OnStateProcessedFailed += CatchCompilerError;
            Machine.OnParseSuccessful += CatchCompilerCompletion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Machine.Parse(Code.Text);
            richTextBox3.Text = Machine.CPP.ToString();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCompilerWatch(string state)
        {
            CPPCode.Text += string.Format("\n{0}", state);
            

        }

        private void CatchCompilerError(string error)
        {
            MessageBox.Show(error, "Error",  MessageBoxButtons.OK);
        }

        private void CatchCompilerCompletion()
        {
            MessageBox.Show("Code fully parsed.", "Success", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
