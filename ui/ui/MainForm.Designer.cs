namespace ui
{
    partial class MainForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.elasticNetButton = new System.Windows.Forms.Button();
            this.linearRegressorButton = new System.Windows.Forms.Button();
            this.gradientBoostingClassifierButton = new System.Windows.Forms.Button();
            this.logisticRegressorButton = new System.Windows.Forms.Button();
            this.decisionTreeButton = new System.Windows.Forms.Button();
            this.ordinalEncoderButton = new System.Windows.Forms.Button();
            this.csvExporterButton = new System.Windows.Forms.Button();
            this.csvImporterButton = new System.Windows.Forms.Button();
            this.propertyGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
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
            this.buttonGroupBox.Controls.Add(this.label4);
            this.buttonGroupBox.Controls.Add(this.label3);
            this.buttonGroupBox.Controls.Add(this.label2);
            this.buttonGroupBox.Controls.Add(this.label1);
            this.buttonGroupBox.Controls.Add(this.elasticNetButton);
            this.buttonGroupBox.Controls.Add(this.linearRegressorButton);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Regression";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Classification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preprocessing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // elasticNetButton
            // 
            this.elasticNetButton.Location = new System.Drawing.Point(7, 385);
            this.elasticNetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elasticNetButton.Name = "elasticNetButton";
            this.elasticNetButton.Size = new System.Drawing.Size(210, 31);
            this.elasticNetButton.TabIndex = 0;
            this.elasticNetButton.Text = "Elastic Net";
            this.elasticNetButton.UseVisualStyleBackColor = true;
            this.elasticNetButton.Click += new System.EventHandler(this.elasticNetButton_Click);
            // 
            // linearRegressorButton
            // 
            this.linearRegressorButton.Location = new System.Drawing.Point(6, 346);
            this.linearRegressorButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.linearRegressorButton.Name = "linearRegressorButton";
            this.linearRegressorButton.Size = new System.Drawing.Size(210, 31);
            this.linearRegressorButton.TabIndex = 0;
            this.linearRegressorButton.Text = "Linear Regressor";
            this.linearRegressorButton.UseVisualStyleBackColor = true;
            this.linearRegressorButton.Click += new System.EventHandler(this.linearRegressorButton_Click);
            // 
            // gradientBoostingClassifierButton
            // 
            this.gradientBoostingClassifierButton.Location = new System.Drawing.Point(8, 287);
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
            this.logisticRegressorButton.Location = new System.Drawing.Point(8, 248);
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
            this.decisionTreeButton.Location = new System.Drawing.Point(8, 209);
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
            this.csvExporterButton.Location = new System.Drawing.Point(8, 87);
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
            this.csvImporterButton.Location = new System.Drawing.Point(8, 48);
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
            this.propertyGroupBox.Controls.Add(this.saveButton);
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
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(345, 555);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 31);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save Config";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(487, 555);
            this.executeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(86, 31);
            this.executeButton.TabIndex = 0;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 628);
            this.Controls.Add(this.propertyGroupBox);
            this.Controls.Add(this.buttonGroupBox);
            this.Controls.Add(this.workflowGroupBox);
            this.Name = "MainForm";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.activityContextMenuStrip.ResumeLayout(false);
            this.buttonGroupBox.ResumeLayout(false);
            this.buttonGroupBox.PerformLayout();
            this.propertyGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip activityContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.GroupBox workflowGroupBox;
        private System.Windows.Forms.GroupBox buttonGroupBox;
        private System.Windows.Forms.Button csvExporterButton;
        private System.Windows.Forms.Button csvImporterButton;
        private System.Windows.Forms.GroupBox propertyGroupBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button logisticRegressorButton;
        private System.Windows.Forms.Button decisionTreeButton;
        private System.Windows.Forms.Button ordinalEncoderButton;
        private System.Windows.Forms.Button gradientBoostingClassifierButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button elasticNetButton;
        private System.Windows.Forms.Button linearRegressorButton;
        private System.Windows.Forms.Button saveButton;
    }
}

