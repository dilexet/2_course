using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string APP_Name = "Ultimate predictor";
        private readonly string Predections_config_path = $"{Environment.CurrentDirectory}\\tsconfig1.json";
        private string[] _prediction;
        private Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = APP_Name;
            try
            {
                var data = File.ReadAllText(Predections_config_path, Encoding.GetEncoding(1251));
                _prediction = JsonConvert.DeserializeObject<string[]>(data);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(_prediction == null)
                {
                    Close();
                }
                else if (_prediction.Length == 0)
                {
                    MessageBox.Show("Предсказания закончились");
                    Close();
                }
            }
        }

        private async void bPredict_Click(object sender, EventArgs e)
        {
            bPredict.Enabled = false;
            await Task.Run(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        UpdateProgressBar(i);
                        this.Text = $"{i}%";
                    }));
                    Thread.Sleep(100);
                }
            });
            var index = _random.Next(_prediction.Length);
            var prediction = _prediction[index];
            MessageBox.Show(prediction);
            progressBar1.Value = 0;
            this.Text = APP_Name;
            bPredict.Enabled = true;
        }

        private void UpdateProgressBar(int i)
        {
            if (i == progressBar1.Maximum)
            {
                progressBar1.Maximum = i + 1;
                progressBar1.Value = i + 1;
                progressBar1.Maximum = i;
            }
            else
            {
                progressBar1.Value = i + 1;
            }
            progressBar1.Value = i;
        }
    }
}
