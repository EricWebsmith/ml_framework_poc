using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ui.Activities
{
    public class DecisionTreeClassifier : Activity
    {
        [CategoryAttribute("Machine Learning")]
        public string Features { get; set; }

        [CategoryAttribute("Machine Learning")]
        public string Label { get; set; }

        [CategoryAttribute("Machine Learning")]
        public int Max_Depth { get; set; }

        [CategoryAttribute("Machine Learning")]
        public string Model_Path { get; set; }


        public override string ClassName { get { return "tf_modules.DecisionTreeClassifier"; } }
    }
}
