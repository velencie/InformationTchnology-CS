using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      dataGridView1.RowCount = 15; 
      dataGridView1.ColumnCount = 15;

      dataGridView2.RowCount = 15;
      dataGridView2.ColumnCount = 15;

      int[,] a = new int[15, 15]; 
      int i, j;
      Random rand = new Random();
      for (i = 0; i < 15; i++)
        for (j = 0; j < 15; j++)
          a[i, j] = rand.Next(-100, 100);
      for (i = 0; i < 15; i++)
        for (j = 0; j < 15; j++)
        {
          dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
          dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
        }  
          
      int max_elem = int.MinValue;
      int min_elem = int.MaxValue;
      int str_min = 0, str_max = 0;

      for (i = 0; i < 15; i++)
        for (j = 0; j < 15; j++)
          if (a[i, j] > max_elem)
          {
            max_elem = a[i, j];
            str_max = i;
          };

      for (i = 0; i < 15; i++)
        for (j = 0; j < 15; j++)
          if (a[i, j] < min_elem)
          {
            min_elem = a[i, j];
            str_min = i;
          }


      if (str_min > str_max) str_min = str_max + (str_max = str_min) * 0;

      DataGridViewRow row1 = dataGridView2.Rows[str_min];
      DataGridViewRow row2 = dataGridView2.Rows[str_max];

      dataGridView2.Rows.Remove(row1);
      dataGridView2.Rows.Remove(row2);

      dataGridView2.Rows.Insert(str_min, row2);
      dataGridView2.Rows.Insert(str_max, row1);

      int k_max = str_max + 1;
      int k_min = str_min + 1;

      label3.Text = "Поменяны строки местами " + k_max.ToString() + " и " + k_min.ToString();

    }
  }
}
