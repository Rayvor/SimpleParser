using SimpleParser.Core;
using SimpleParser.Core.Habr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleParser
{
    public partial class MainForm : Form
    {
        ParserWorker<string[]> parser;
        List<string[]> storageListTitles;
        int pageNumber;

        public MainForm()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                new HabrParser());

            storageListTitles = new List<string[]>();

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnCompleted(object obj)
        {
            //ListTitles.Items.Clear();

            //foreach (var item in storageListTitles)
            //{
            //    ListTitles.Items.AddRange(item);
            //}

            labelProgressStatus.Text = "Done.";
            pageNumber = 0;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Items.Add($"Page {++pageNumber}");

            storageListTitles.Add(arg2);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //storageListTitles.Clear();

            parser.Settings = new HabrSettings(
                (int)NumericStart.Value,
                (int)NumericEnd.Value,
                "http://habrahabr.ru/all/",
                "page{CurrentId}" );

            parser.Start();
        }

        private void Abort_Click(object sender, EventArgs e)
        {
            parser.Abort();

            ListTitles.Items.Clear();
            storageListTitles.Clear();

        }

        private void progressBar_Click(object sender, EventArgs e)
        {
        }
    }
}
