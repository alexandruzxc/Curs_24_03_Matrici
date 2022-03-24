using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Curs_24_03_Matrici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region CitireaMatriciiDinFisier
            TextReader load = new StreamReader(@"../../TextFile2.txt");
            List<string> data = new List<string>();
            /*data.Add(load.ReadLine());*/
            string buffer;
            while ((buffer = load.ReadLine()) != null)
                data.Add(buffer);
            load.Close();
            //am citit datele si dupa am inchis fisierul
            //toate datele sunt salvate in 'data' sub forma de stringuri
            #endregion
            foreach (string S in data)
                listBox1.Items.Add(S); //afisarea stringului
            #region CitireaMatriciiDinString
            int n = int.Parse(data[0].Split(' ')[0]);
            int m = int.Parse(data[0].Split(' ')[1]);
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] t = data[i + 1].Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(t[j]);
                }
            }
            #endregion
            #region AfisareValorilorMatriciiLinieCuLinie
            string b;
            for (int i = 0; i < n; i++)
            {
                b = "";
                for (int j = 0; j < m; j++)
                {
                    b += matrix[i, j] + " ";                   
                }
                listBox1.Items.Add(b);
            }
            #endregion
        }
    }
}
