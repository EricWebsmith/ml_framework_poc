using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ui
{
    public class LogisticRegressor : Classifier
    {
        [CategoryAttribute("Machine Learning")]
        public string Features { get; set; }

        [CategoryAttribute("Machine Learning")]
        public string Label { get; set; }

        [CategoryAttribute("Machine Learning")]
        public string Model_Path { get; set; }

        [Display(Description ="逻辑回归")]
        public override string ClassName { get { return "ml_nodes.LogisticRegressor"; } }
    }
}
