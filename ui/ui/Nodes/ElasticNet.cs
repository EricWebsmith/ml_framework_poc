using System.ComponentModel;

namespace ui
{
    public class ElasticNet : Node
    {
        [Category("Machine Learning")]
        public string Features { get; set; }

        [Category("Machine Learning")]
        public string Label { get; set; }

        [Category("Machine Learning")]
        public string Model_Path { get; set; }

        [Category("Machine Learning"), DefaultValue(true)]
        public bool Fit_Intercept { get; set; }

        public override string ClassName { get { return "ml_nodes.ElasticNet"; } }
    }
}
