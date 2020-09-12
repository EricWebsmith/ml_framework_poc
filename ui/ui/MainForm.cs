using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ui
{
    public partial class MainForm : Form
    {
        PropertyGrid activityPropertyGrid = new PropertyGrid();
        List<Node> Activities = new List<Node>();

        public MainForm()
        {
            InitializeComponent();

            // The initial constructor code goes here.

            //Sequencer sequencer = new Sequencer();
            
            activityPropertyGrid.CommandsVisibleIfAvailable = true;
            activityPropertyGrid.Location = new Point(10, 19);
            activityPropertyGrid.Size = new System.Drawing.Size(500, 500);
            activityPropertyGrid.TabIndex = 1;
            activityPropertyGrid.Text = "Property Grid";
            this.propertyGroupBox.Controls.Add(activityPropertyGrid);

            //activityPropertyGrid.SelectedObject = sequencer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void activityControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Activities.Add(new CsvImporter());
            Refresh();
        }



        private void Refresh()
        {

            workflowGroupBox.Controls.Clear();
            for (int i=0;i< Activities.Count; i++)
            {
                ActivityControl theActivityControl = new ActivityControl();
                theActivityControl.Location = new Point(19, 19 + i * 83);
                theActivityControl.Size = new Size(162, 79);
                theActivityControl.Activity = Activities[i];
                theActivityControl.Click += TheActivityControl_Click;
                theActivityControl.ContextMenuStrip = activityContextMenuStrip;

                workflowGroupBox.Controls.Add(theActivityControl);
            }
        }

        private void TheActivityControl_Click(object sender, EventArgs e)
        {
            ActivityControl activityControl = (ActivityControl)sender;
            activityPropertyGrid.SelectedObject = activityControl.Activity;
            activityPropertyGrid.Text = activityControl.Activity.GetType().Name;
            // set style
            var boldFont = new Font(activityControl.Font, FontStyle.Bold);
            var regularFont = new Font(activityControl.Font, FontStyle.Regular);
            
            foreach(var control in workflowGroupBox.Controls)
            {
                ActivityControl ac = (ActivityControl)control;
                ac.Font = regularFont;
            }

            activityControl.Font = boldFont;
        }

        private void csvImporterButton_Click(object sender, EventArgs e)
        {
            Activities.Add(new CsvImporter());
            Refresh();
        }

        private void csvExporterButton_Click(object sender, EventArgs e)
        {
            Activities.Add(new CsvExporter());
            Refresh();
        }

        private void ordinalEncoderButton_Click(object sender, EventArgs e)
        {
            Activities.Add(new OrdinalEncoder());
            Refresh();
        }

        private void logisticRegressorButton_Click(object sender, EventArgs e)
        {
            Activities.Add(new LogisticRegressor());
            Refresh();
        }

        private void decisionTreeButton_Click(object sender, EventArgs e)
        {
            Activities.Add(new DecisionTreeClassifier());
            Refresh();
        }

        private void gradientBoostingClassifierButton_Click(object sender, EventArgs e)
        {
            Activities.Add(new GradientBoostingClassifier());
            Refresh();
        }

        private void linearRegressorButton_Click(object sender, EventArgs e)
        {
            Activities.Add(new LinearRegressor());
            Refresh();
        }

        private void elasticNetButton_Click(object sender, EventArgs e)
        {
            Activities.Add(new ElasticNet());
            Refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)menu.Owner;
            ActivityControl activityControl = (ActivityControl)cms.SourceControl;
            var activity = activityControl.Activity;
            Activities.Remove(activity);
            Refresh();
        }

        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)menu.Owner;
            ActivityControl activityControl = (ActivityControl)cms.SourceControl;
            var activity = activityControl.Activity;
            int index=Activities.IndexOf(activity);
            if (index == 0) { return; }
            Activities.Remove(activity);
            Activities.Insert(index-1, activity);
            Refresh();
        }

        private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)menu.Owner;
            ActivityControl activityControl = (ActivityControl)cms.SourceControl;
            var activity = activityControl.Activity;
            int index = Activities.IndexOf(activity);
            if (index == Activities.Count-1) { return; }
            Activities.Remove(activity);
            Activities.Insert(index+1, activity);
            Refresh();
        }

        private void Save()
        {
            string config = ActivityConfigGenerator.Generate(Activities);
            string config_file_path = ConfigurationManager.AppSettings["config_file_path"];
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(config_file_path))
            {
                sw.Write(config);
                sw.Flush();
                sw.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            Save();

            //System.Diagnostics.Process p = new System.Diagnostics.Process();
            //p.StartInfo.UseShellExecute = true;
            //p.StartInfo.FileName = @"python.exe";
            //p.StartInfo.Arguments = @"D:\projects\ml_framework_poc\py\job_executor.py D:\projects\ml_framework_poc\py\config.json";
            //p.StartInfo.CreateNoWindow = false;
            string outputString;
            string error;
            ProcessStartInfo prcStartInfo = new ProcessStartInfo
            {
                // full path of the Python interpreter 'python.exe'
                FileName = "python.exe", // string.Format(@"""{0}""", "python.exe"),
                WorkingDirectory = @"D:\projects\ml_framework_poc\py\",
                Arguments = @"job_executor.py config.json",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError =true,
            };

            using (Process process = Process.Start(prcStartInfo))
            {
                // read standard output JSON string
                using (StreamReader myStreamReader = process.StandardOutput)
                {
                    outputString = myStreamReader.ReadToEnd();
                    error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                }
            }

            MessageBox.Show(outputString + error);
        }


    }
}
