using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgressBar
{
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
        for (int i = 1; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(100);
                backgroundWorker1.ReportProgress(i);
            }
    }

    private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
        progressBar1.Value = e.ProgressPercentage;
        this.Text = e.ProgressPercentage.ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        backgroundWorker1.RunWorkerAsync();
    }
}
}
