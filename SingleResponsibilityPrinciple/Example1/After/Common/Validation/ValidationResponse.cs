using System.Collections.Generic;

namespace SingleResponsibilityPrinciple.Example1.After.Common.Validation
{
    public class ValidationResponse
    {
        public bool IsValid { get; set; }
        public List<string> ErrorMessages { get; set; } = new List<string>();
    }
}
