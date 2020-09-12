using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ui
{
    public static class ActivityConfigGenerator
    {
        public static string Generate(IEnumerable<Node> activities)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{\"model_id\":\"13254654\",\"model_name\":\"my_model\",\"pipepline\":[");
            foreach(Node activity in activities)
            {
                sb.Append("{");
                var properties = activity.GetType().GetProperties();
                var p_classname = properties.Where(p => p.Name == "ClassName").First();
                sb.Append($"\"class\":\"{p_classname.GetValue(activity)}\",");

                var otherProperties = properties.Where(p => p.Name != "ClassName");
                for (int i = 0; i < properties.Length; i++)
                {
                    var pi = properties[i];
                    //if (pi.Name == "Name") { continue; }
                    //System.Nullable<int>
                    if(pi.PropertyType == typeof(System.Nullable<int>))
                    {
                        sb.Append($"\"{pi.Name.ToLower()}\":{pi.GetValue(activity)}");
                    }
                    else if (pi.PropertyType == typeof(int))
                    {
                        sb.Append($"\"{pi.Name.ToLower()}\":{pi.GetValue(activity)}");
                    }
                    else
                    {
                        sb.Append($"\"{pi.Name.ToLower()}\":\"{pi.GetValue(activity)}\"");
                    }

                    if (pi != properties.Last())
                    {
                        sb.Append(",");
                    }
                    
                }
                sb.Append("}");
                if(activity!=activities.Last())
                {
                    sb.Append(",");
                }
            }
            sb.Append("]}");
            return sb.ToString();
        }
    }
}
