namespace ui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.activityContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workflowGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.gradientBoostingClassifierButton = new System.Windows.Forms.Button();
            this.logisticRegressorButton = new System.Windows.Forms.Button();
            this.decisionTreeButton = new System.Windows.Forms.Button();
            this.ordinalEncoderButton = new System.Windows.Forms.Button();
            this.csvExporterButton = new System.Windows.Forms.Button();
            this.csvImporterButton = new System.Windows.Forms.Button();
            this.propertyGroupBox = new System.Windows.Forms.GroupBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.activityContextMenuStrip.SuspendLayout();
            this.buttonGroupBox.SuspendLayout();
            this.propertyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // activityContextMenuStrip
            // 
            this.activityContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.activityContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem});
            this.activityContextMenuStrip.Name = "activityContextMenuStrip";
            this.activityContextMenuStrip.Size = new System.Drawing.Size(159, 76);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.moveUpToolStripMenuItem.Text = "Move Up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.moveDownToolStripMenuItem.Text = "Move Down";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
            // 
            // workflowGroupBox
            // 
            this.workflowGroupBox.Location = new System.Drawing.Point(245, 16);
            this.workflowGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workflowGroupBox.Name = "workflowGroupBox";
            this.workflowGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workflowGroupBox.Size = new System.Drawing.Size(229, 594);
            this.workflowGroupBox.TabIndex = 6;
            this.workflowGroupBox.TabStop = false;
            this.workflowGroupBox.Text = "Workflow";
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.gradientBoostingClassifierButton);
            this.buttonGroupBox.Controls.Add(this.logisticRegressorButton);
            this.buttonGroupBox.Controls.Add(this.decisionTreeButton);
            this.buttonGroupBox.Controls.Add(this.ordinalEncoderButton);
            this.buttonGroupBox.Controls.Add(this.csvExporterButton);
            this.buttonGroupBox.Controls.Add(this.csvImporterButton);
            this.buttonGroupBox.Location = new System.Drawing.Point(14, 16);
            this.buttonGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGroupBox.Size = new System.Drawing.Size(224, 594);
            this.buttonGroupBox.TabIndex = 7;
            this.buttonGroupBox.TabStop = false;
            this.buttonGroupBox.Text = "Machine Learning Controls";
            // 
            // gradientBoostingClassifierButton
            // 
            this.gradientBoostingClassifierButton.Location = new System.Drawing.Point(8, 302);
            this.gradientBoostingClassifierButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gradientBoostingClassifierButton.Name = "gradientBoostingClassifierButton";
            this.gradientBoostingClassifierButton.Size = new System.Drawing.Size(210, 31);
            this.gradientBoostingClassifierButton.TabIndex = 0;
            this.gradientBoostingClassifierButton.Text = "Gradient Boosting Classifier";
            this.gradientBoostingClassifierButton.UseVisualStyleBackColor = true;
            this.gradientBoostingClassifierButton.Click += new System.EventHandler(this.gradientBoostingClassifierButton_Click);
            // 
            // logisticRegressorButton
            // 
            this.logisticRegressorButton.Location = new System.Drawing.Point(8, 224);
            this.logisticRegressorButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logisticRegressorButton.Name = "logisticRegressorButton";
            this.logisticRegressorButton.Size = new System.Drawing.Size(210, 31);
            this.logisticRegressorButton.TabIndex = 0;
            this.logisticRegressorButton.Text = "Logistic Regressor";
            this.logisticRegressorButton.UseVisualStyleBackColor = true;
            this.logisticRegressorButton.Click += new System.EventHandler(this.logisticRegressorButton_Click);
            // 
            // decisionTreeButton
            // 
            this.decisionTreeButton.Location = new System.Drawing.Point(8, 263);
            this.decisionTreeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decisionTreeButton.Name = "decisionTreeButton";
            this.decisionTreeButton.Size = new System.Drawing.Size(210, 31);
            this.decisionTreeButton.TabIndex = 0;
            this.decisionTreeButton.Text = "Decision Tree";
            this.decisionTreeButton.UseVisualStyleBackColor = true;
            this.decisionTreeButton.Click += new System.EventHandler(this.decisionTreeButton_Click);
            // 
            // ordinalEncoderButton
            // 
            this.ordinalEncoderButton.AccessibleDescription = "";
            this.ordinalEncoderButton.Location = new System.Drawing.Point(7, 150);
            this.ordinalEncoderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ordinalEncoderButton.Name = "ordinalEncoderButton";
            this.ordinalEncoderButton.Size = new System.Drawing.Size(210, 31);
            this.ordinalEncoderButton.TabIndex = 0;
            this.ordinalEncoderButton.Text = "Ordinal Encoder";
            this.ordinalEncoderButton.UseVisualStyleBackColor = true;
            this.ordinalEncoderButton.Click += new System.EventHandler(this.ordinalEncoderButton_Click);
            // 
            // csvExporterButton
            // 
            this.csvExporterButton.Location = new System.Drawing.Point(8, 68);
            this.csvExporterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.csvExporterButton.Name = "csvExporterButton";
            this.csvExporterButton.Size = new System.Drawing.Size(210, 31);
            this.csvExporterButton.TabIndex = 0;
            this.csvExporterButton.Text = "CSV Exporter";
            this.csvExporterButton.UseVisualStyleBackColor = true;
            this.csvExporterButton.Click += new System.EventHandler(this.csvExporterButton_Click);
            // 
            // csvImporterButton
            // 
            this.csvImporterButton.Location = new System.Drawing.Point(7, 29);
            this.csvImporterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.csvImporterButton.Name = "csvImporterButton";
            this.csvImporterButton.Size = new System.Drawing.Size(210, 31);
            this.csvImporterButton.TabIndex = 0;
            this.csvImporterButton.Text = "CSV Importer";
            this.csvImporterButton.UseVisualStyleBackColor = true;
            this.csvImporterButton.Click += new System.EventHandler(this.csvImporterButton_Click);
            // 
            // propertyGroupBox
            // 
            this.propertyGroupBox.Controls.Add(this.executeButton);
            this.propertyGroupBox.Location = new System.Drawing.Point(480, 16);
            this.propertyGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.propertyGroupBox.Name = "propertyGroupBox";
            this.propertyGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.propertyGroupBox.Size = new System.Drawing.Size(588, 594);
            this.propertyGroupBox.TabIndex = 8;
            this.propertyGroupBox.TabStop = false;
            this.propertyGroupBox.Text = "Property";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(496, 555);
            this.executeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(86, 31);
            this.executeButton.TabIndex = 0;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 628);
            this.Controls.Add(this.propertyGroupBox);
            this.Controls.Add(this.buttonGroupBox);
            this.Controls.Add(this.workflowGroupBox);
            this.Name = "Form1";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.activityContextMenuStrip.ResumeLayout(false);
            this.buttonGroupBox.ResumeLayout(false);
            this.propertyGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip activityContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.GroupBox workflowGroupBox;
        private System.Windows.Forms.GroupBox buttonGroupBox;
        private System.Windows.Forms.Button csvExporterButton;
        private System.Windows.Forms.Button csvImporterButton;
        private System.Windows.Forms.GroupBox propertyGroupBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OrdinalEncoder;
        private System.Windows.Forms.Button logisticRegressorButton;
        private System.Windows.Forms.Button decisionTreeButton;
        private System.Windows.Forms.Button ordinalEncoderButton;
        private System.Windows.Forms.Button gradientBoostingClassifierButton;
    }
}

