using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ui.Activities;

namespace ui
{
    public partial class Form1 : Form
    {
        PropertyGrid activityPropertyGrid = new PropertyGrid();
        List<Activity> Activities = new List<Activity>();

        public Form1()
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
            Activities.Add(new CsvImporterActivity());
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
        }

        private void csvImporterButton_Click(object sender, EventArgs e)
        {
            Activities.Add(new CsvImporterActivity());
            Refresh();
        }

        private void csvExporterButton_Click(object sender, EventArgs e)
        {
            Activities.Add(new CsvExporterActivity());
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

        private void executeButton_Click(object sender, EventArgs e)
        {
            string config = ActivityConfigGenerator.Generate(Activities);
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"D:\projects\ml_framework_poc\py\config.json"))
            {
                sw.Write(config);
                sw.Flush();
                sw.Close();
            }

            //System.Diagnostics.Process p = new System.Diagnostics.Process();
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.FileName = @"cmd python D:\projects\ml_framework_poc\py\demo.py D:\projects\ml_framework_poc\py\config.json";
            //p.StartInfo.CreateNoWindow = true;
            //p.Start();
        }


    }
}
