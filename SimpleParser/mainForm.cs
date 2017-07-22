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
        ParserWorker<List<string>> parser;
        int pageNumber;

        public MainForm()
        {
            InitializeComponent();
            parser = new ParserWorker<List<string>>(
                new HabrParser());

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, List<string> arg2)
        {
            arg2.Insert(0, $"Page {++pageNumber}");
            arg2.Add("");
            ListTitles.Items.AddRange(arg2.ToArray());
        }

        private void Parser_OnCompleted(object obj)
        {
            labelProgressStatus.Text = "Done.";

            var parserWorker = (ParserWorker<List<string>>) obj;
            
            if (!parserWorker.IsActive)
                labelProgressStatus.Text = "Aborted.";

            pageNumber = 0;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            ListTitles.Items.Clear();
            labelProgressStatus.Text = "";

            parser.Settings = new HabrSettings(
                (int)NumericStart.Value,
                (int)NumericEnd.Value,
                textBaseUrl.Text,
                textPrefix.Text );

            parser.Start(textSelector.Text, textContent.Text);
        }

        private void Abort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelProgressStatus.Text = "";
            ListTitles.Items.Clear();
        }
    }
}
