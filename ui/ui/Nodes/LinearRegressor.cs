using System.ComponentModel;

namespace ui
{
    public class LinearRegressor : Classifier
    {

        [Category("Model")]
        public string Model_Path { get; set; }

        [Category("Linear Regressor"), DefaultValue(true)]
        public bool Fit_Intercept { get; set; }

        public override string ClassName { get { return "ml_nodes.LinearRegressor"; } }
    }
}
