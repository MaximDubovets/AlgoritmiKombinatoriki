using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2AlgoritmiKombinatorika
{
    public partial class Form1 : Form
    {
        int m, n;
        char[] A;
        int[] count;//счетчик перестановок
        char ch;
        string st;
        int k;
        char[] AA;
        int[] CC;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
            A = new char[n];
            count = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = (char)(65 + i);
                count[i] = 0;
            }
            listBox1.Items.Clear();
            L1:; //алгоритм перестановок
            st = "";
            for (int i = 0; i < n; i++) st = st + " "+A[i];
            listBox1.Items.Add(st);

            k = n - 2;
            L2:;
            count[k]++;
            ch = A[k];
            for (int i = k; i < n - 1; i++) A[i] = A[i + 1];
            A[n - 1] = ch; //перестановка
            if (count[k] <= n - k - 1) goto L1;
            count[k] = 0;
            k--;
            if (k >= 0) goto L2;
          }

        private void button2_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBox2.Text);
            m = int.Parse(textBox1.Text);
            A = new char[n];
            count = new int[m];
            for (int i = 0; i < n; i++) A[i] = (char)(65 + i);
            listBox1.Items.Clear();
            count[0] = 0;
            k = 0;
            L1:; //алгоритм сочетаний
            for (int i = k + 1; i < m; i++) count[i] = count[i - 1] + 1;
            st = "";
            for (int i = 0; i < m; i++) st = st + " " + A[count[i]];
            listBox1.Items.Add(st);

            k = m - 1;
            L2:;
            count[k]++;
            if (count[k] <= n - m + k) goto L1;
            k--;
            if (k >= 0) goto L2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBox2.Text);
            m = int.Parse(textBox1.Text);
            AA = new char[n];
            CC = new int[m];
            A = new char[m];
            count = new int[m];
            listBox1.Items.Clear();
            for (int i = 0; i < n; i++) AA[i]=(char)(65+i);
            CC[0] = 0;
            k = 0;

            LL1:; //алгоритм размещения
            for (int i = k + 1; i < m; i++) CC[i] = CC[i - 1] + 1;           
          
            
            //------------------------------------------------------//

            for (int i = 0; i < m; i++)
            {
                A[i] = AA[CC[i]];
                count[i] = 0;
            }
            L1: //алгоритм перестановок
            st = "";
            for (int i = 0; i < m; i++) st = st + " " + A[i];
            listBox1.Items.Add(st);

            //k = m -2;
            L2:
            count[k]++;
            ch = A[k];
            for (int i = k; i < m - 1; i++) A[i] = A[i + 1];
            A[m - 1] = ch; //перестановка
            if (count[k] <= m - k - 1) goto L1;
            count[k] = 0;
            k--;
            if (k >= 0) goto L2;

            //------------------------------------------------------//
            k = m - 1;
            LL2:;
            CC[k]++;
            if (CC[k] <= n - m + k) goto LL1;
            k--;
            if (k >= 0) goto LL2;
            
        }
    }
}
