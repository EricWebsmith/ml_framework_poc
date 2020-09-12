using System.ComponentModel;

namespace ui
{
    public class CsvImporter : Node
    {
        [CategoryAttribute("Machine Learning")]
        public string FilePath { get; set; }

        public override string ClassName { get { return "ml_nodes.CsvImporter"; } }
    }
}
