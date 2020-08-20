using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ui
{
    class CsvImporterActivity : Activity
    {
        [CategoryAttribute("Machine Learning")]
        public string FilePath { get; set; }

        public override string ClassName { get { return "tf_modules.CsvImporter"; } }
    }
}
