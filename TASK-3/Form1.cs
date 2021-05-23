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
      private void button1_Click(object sender, EventArgs e)
    {
      double x = Convert.ToDouble(textBox1.Text);
      textBox2.Text = "Результаты работы программы ст. Новиковой В.А. " + Environment.NewLine;

      int n = 0;
      if (radioButton2.Checked) n = 1;
      else if (radioButton3.Checked) n = 2;

      double u;
      switch (n)
      {
        case 0:
          if (x > 5) u = 0.5 * (Math.Exp(x) - Math.Exp(-x)) / 2;
          else if (x >= 0 && x <= 3) u = 2;
          else u = 1/((Math.Exp(x) - Math.Exp(-x)) / 2);
          textBox2.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 1:
          if (x > 5) u = 0.5 * (Math.Exp(x) + Math.Exp(-x)) / 2;
          else if (x >= 0 && x <= 3) u = 2;
          else u = 1 /((Math.Exp(x) + Math.Exp(-x)) / 2);
          textBox2.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 2:
          if (x > 5) u = 0.5 * Math.Exp(x);
          else if (x >= 0 && x <= 3) u = 2;
          else u = 1 / (Math.Exp(x));
          textBox2.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        default:
          textBox2.Text += "Решение не найдено" + Environment.NewLine;
          break;
      }
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
