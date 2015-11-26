using System;

namespace RPSM.Utilities
{
    internal class Utils
    {
        internal WebFormsHelpers WebFormsHelpers { get; set; }
        public decimal ConvertToDecimal(object value)
        {
            if (value == null) return 0;

            return Convert.ToDecimal(value);
        }
    }
}
