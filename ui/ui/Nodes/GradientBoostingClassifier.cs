using System.ComponentModel;

namespace ui
{
    public class GradientBoostingClassifier : Node
    {
        [CategoryAttribute("Machine Learning")]
        public string Features { get; set; }

        [CategoryAttribute("Machine Learning")]
        public string Label { get; set; }

        [CategoryAttribute("Machine Learning")]
        public int N_Estimators { get; set; }

        [CategoryAttribute("Machine Learning")]
        public int Max_Depth { get; set; }

        [CategoryAttribute("Machine Learning")]
        public string Model_Path { get; set; }


        public override string ClassName { get { return "ml_nodes.DecisionTreeClassifier"; } }
    }
}
