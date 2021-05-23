using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      textBox1.Text = "0";
      textBox2.Text = "Практическая работа №2 Новикова В.А.";
      textBox2.Text += Environment.NewLine + "Рассчитать значение выражения варианта №7";

    }

    private void button1_Click(object sender, EventArgs e)
    {
      double x = double.Parse(textBox1.Text);

      if (x <= 0)
      {
        MessageBox.Show("Недопустимое значение");
      }
      if (x == 1)
      {
        MessageBox.Show("Делить на ноль нельзя");
      }
      else
      {
        textBox2.Text += Environment.NewLine +
      "При x = " + x.ToString();

        double y = (2 * Math.Log(x) * Math.Cos(2 * x) - (3 * ((Math.Pow(x + 1, 2)) / (x - 1))) / (2 + Math.Sqrt(x)));
        textBox2.Text += Environment.NewLine +
        "Результат y = " + y.ToString();
      }
    }
    private void textBox2_TextChanged(object sender, EventArgs e)
    {
    }
  }
}
