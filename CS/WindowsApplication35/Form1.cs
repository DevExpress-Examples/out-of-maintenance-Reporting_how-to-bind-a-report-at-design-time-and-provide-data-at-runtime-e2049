using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace WindowsApplication35 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            report.DataSource = CreateData();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private List<Data> CreateData() {
            List<Data> data = new List<Data>();

            Data item1 = new Data();
            item1.Date = DateTime.Now;
            item1.Id = 0;
            item1.Name = "First";
            data.Add(item1);

            Data item2 = new Data();
            item2.Date = DateTime.Now;
            item2.Id = 1;
            item2.Name = "Second";
            data.Add(item2);

            Data item3 = new Data();
            item3.Date = DateTime.Now;
            item3.Id = 2;
            item3.Name = "Third";
            data.Add(item3);

            return data;
        }

    }
}