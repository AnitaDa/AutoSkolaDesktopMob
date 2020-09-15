using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class RecommenderSearchRequest
    {
        public int InstruktorId { get; set; }
        public override string ToString()
        {
            return $"InstruktorId={InstruktorId}";
        }
    }
}
