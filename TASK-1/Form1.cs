using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      var labels = new[] { label1, label2, label3, label4 };
      Random rnd = new Random();
      int value_kol = rnd.Next(0, 4);

      for (int i = 0; i < value_kol; i++)
      {
        int value_i = rnd.Next(0, 4);
        labels[value_i].ForeColor = Color.White;
      }

      value_kol = rnd.Next(0, 4);

      for (int i = 0; i < value_kol; i++)
      {
        int value_i = rnd.Next(0, 4);
        labels[value_i].ForeColor = Color.Black;
      }
      if ((label1.ForeColor == Color.White) && (label2.ForeColor == Color.White) && (label3.ForeColor == Color.White) && (label4.ForeColor == Color.White))
      {
        MessageBox.Show("Вы выиграли!");
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      var labels = new[] { label1, label2, label3, label4 };
      Random rnd = new Random();
      int value_kol = rnd.Next(0, 4);

      for (int i = 0; i < value_kol; i++)
      {
        int value_i = rnd.Next(0, 4);
        labels[value_i].ForeColor = Color.White;
      }

      value_kol = rnd.Next(0, 4);

      for (int i = 0; i < value_kol; i++)
      {
        int value_i = rnd.Next(0, 4);
        labels[value_i].ForeColor = Color.Black;
      }

      if ((label1.ForeColor == Color.White) && (label2.ForeColor == Color.White) && (label3.ForeColor == Color.White) && (label4.ForeColor == Color.White))
      {
        MessageBox.Show("Вы выиграли!");
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      var labels = new[] { label1, label2, label3, label4 };
      Random rnd = new Random();
      int value_kol = rnd.Next(0, 4);

      for (int i = 0; i < value_kol; i++)
      {
        int value_i = rnd.Next(0, 4);
        labels[value_i].ForeColor = Color.White;
      }

      value_kol = rnd.Next(0, 4);

      for (int i = 0; i < value_kol; i++)
      {
        int value_i = rnd.Next(0, 4);
        labels[value_i].ForeColor = Color.Black;
      }

      if ((label1.ForeColor == Color.White) && (label2.ForeColor == Color.White) && (label3.ForeColor == Color.White) && (label4.ForeColor == Color.White))
      {
        MessageBox.Show("Вы выиграли!");
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      var labels = new[] { label1, label2, label3, label4 };
      Random rnd = new Random();
      int value_kol = rnd.Next(0, 4);

      for (int i = 0; i < value_kol; i++)
      {
        int value_i = rnd.Next(0, 4);
        labels[value_i].ForeColor = Color.White;
      }

      value_kol = rnd.Next(0, 4);

      for (int i = 0; i < value_kol; i++)
      {
        int value_i = rnd.Next(0, 4);
        labels[value_i].ForeColor = Color.Black;
      }

      if ((label1.ForeColor == Color.White) && (label2.ForeColor == Color.White) && (label3.ForeColor == Color.White) && (label4.ForeColor == Color.White))
      {
        MessageBox.Show("Вы выиграли!");
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      
    }
  }
}
