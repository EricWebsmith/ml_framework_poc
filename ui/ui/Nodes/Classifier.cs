using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ui
{
    public abstract class Classifier: Node
    {
        [Category("Classification"), DefaultValue(0.8)]
        public float TrainTestSplit { get; set; }

        [Category("Classification")]
        public string Features { get; set; }

        [Category("Classification")]
        public string Label { get; set; }

        public Classifier()
        {
            TrainTestSplit = 0.8f;
        }
    }
}
