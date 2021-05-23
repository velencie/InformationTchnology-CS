using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }


    public static long Fact(long a)
    {
      if (a == 0)
        return 1;
      else
        return a * Fact(a - 1);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Double n = Convert.ToDouble(textBox1.Text);
      Double eps = Convert.ToDouble(textBox1.Text);
      textBox2.Text = "Результаты работы программы ст. Новиковой В.А. " + Environment.NewLine;

      double s = 0, ch;
      long i = 1;

      ch = 2 / Math.Sqrt(Fact(i) + 4);

      while (ch >= eps)
      {
        ch = 2 / Math.Sqrt(Fact(i) + 4);
        s += ch;
        i++;
      }
      textBox2.Text += "При eps = " + textBox1.Text + Environment.NewLine;
      textBox2.Text += "Расчет суммы ряда S = " + Convert.ToString(s) + Environment.NewLine;
    }
  }
}
