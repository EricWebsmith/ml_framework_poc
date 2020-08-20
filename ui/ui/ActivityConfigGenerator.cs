using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace ui
{
   public static class ActivityConfigGenerator
    {
        public static string Generate(IEnumerable<Activity> activities)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{\"model_id\":\"13254654\",\"model_name\":\"rnn1\",\"pipepline\":[");
            foreach(Activity activity in activities)
            {
                sb.Append($"{{\"class\":\"{activity.ClassName}\",\"mod_config\":{{");
                var properties = activity.GetType().GetProperties();
                for(int i = 0; i < properties.Length; i++)
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
                sb.Append("}}");
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
