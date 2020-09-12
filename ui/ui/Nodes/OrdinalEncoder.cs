using System.ComponentModel;

namespace ui
{
    public class OrdinalEncoder : Node
    {
        [Category("Machine Learning")]
        public string Columns { get; set; }
        public override string ClassName { get { return "ml_nodes.OrdinalEncoder"; } }

    }
}
