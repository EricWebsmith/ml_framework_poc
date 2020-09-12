using System.ComponentModel;

namespace ui
{
    public abstract class Node
    {
        [CategoryAttribute("Machine Learning")]
        public string Name { get; set; }

        public abstract string ClassName { get;}

    }
}
