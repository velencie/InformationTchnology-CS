using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

      int index  = int.Parse(textBox1.Text);
      string str = (string)Строки.Items[index-1];
      int len = str.Length;
      int count = 0;
      int i = 0;
      while (i < len)
      {
        if (str[i] == '.' | str[i] == '!' | str[i] == '?')
          count++;
        i++;
      }
      label1.Text = "Количество предложений = " +
      count.ToString();
    }
  }
}
