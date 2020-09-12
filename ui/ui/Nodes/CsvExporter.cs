﻿using System.ComponentModel;

namespace ui
{
    public class CsvExporter : Node
    {
        [CategoryAttribute("Machine Learning")]
        public string FilePath { get; set; }

        public override string ClassName { get { return "ml_nodes.CsvExporter"; } }
    }
}
