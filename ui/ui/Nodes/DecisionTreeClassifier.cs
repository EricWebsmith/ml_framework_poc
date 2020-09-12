using System.ComponentModel;

namespace ui
{
    public enum DecisionTreeCriterion
    {
        gini,
        entropy
    }

    public class DecisionTreeClassifier : Node
    {
        [CategoryAttribute("Machine Learning")]
        public string Features { get; set; }

        [CategoryAttribute("Machine Learning")]
        public string Label { get; set; }

        [CategoryAttribute("Machine Learning")]
        public int Max_Depth { get; set; }

        [CategoryAttribute("Machine Learning")]
        public string Model_Path { get; set; }

        [CategoryAttribute("Machine Learning")]
        public DecisionTreeCriterion Criterion { get; set; }

        public override string ClassName { get { return "ml_nodes.DecisionTreeClassifier"; } }
    }
}
