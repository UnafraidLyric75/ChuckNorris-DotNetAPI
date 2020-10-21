using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorisJokes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(ChuckNorrisClient.GetCategories());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string includeTypes = comboBox1.SelectedItem as string;
            var selectedJoke = ChuckNorrisClient.GetRandomJoke();

            while (selectedJoke != includeTypes)
            {
                selectedJoke = ChuckNorrisClient.GetRandomJoke();
            }
            textBox1.Text = WebUtility.HtmlDecode(selectedJoke);
        }
    }
}
