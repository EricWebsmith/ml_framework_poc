using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ui
{
    public class CsvExporterActivity : Activity
    {
        [CategoryAttribute("Machine Learning")]
        public string FilePath { get; set; }

        public override string ClassName { get { return "ml_modules.CsvExporter"; } }
    }
}
