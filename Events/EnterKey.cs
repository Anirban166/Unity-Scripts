using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void textBox1_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyValue == 13)
            MessageBox.Show("Enter key pressed");
    }
}
}
