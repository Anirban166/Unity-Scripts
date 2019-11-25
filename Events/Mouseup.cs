using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_MouseUp(object sender, MouseEventArgs e)
    {
        int add;
        add = Convert.ToInt32(textBox1.Text) +Convert.ToInt32(textBox2.Text);
        textBox3.Text = Convert.ToString(add);
        MessageBox.Show("Addition is performed with MouseUp Event");
    }
}
}
