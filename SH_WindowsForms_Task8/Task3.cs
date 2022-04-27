using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SH_WindowsForms_Task8
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private delegate int AsyncSumm(int a, int b);

        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000); return a + b;
        }

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Сума введених чисел дорівнює {0}",
            summdelegate.EndInvoke(ar)); MessageBox.Show(str, "Результат операції");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                // Перетворення типів даних.
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("При виконанні перетворення типів виникла помилка");
                textBox1.Text = textBox2.Text = ""; return;

            }

            AsyncSumm summdelegate = new AsyncSumm(Summ); AsyncCallback cb = new
            AsyncCallback(CallBackMethod); summdelegate.BeginInvoke(a, b, cb, summdelegate);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Робота кипить!!!");
        }
    }
}
