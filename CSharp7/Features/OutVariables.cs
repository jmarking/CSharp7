
namespace CSharp7.NewFeatures
{
    public class OutVariables
    {
        /// <summary>
        /// out variable had to be explicitly declared outside of the out usage
        /// </summary>
        public string OldoutVariableUsage(string value)
        {
            int intValue; // Explicitly declared (int)
            if (int.TryParse(value, out intValue))
            {
                return $"Successfully parsed int value {intValue}";
            }
			else
            {
                return $"Unable to parse \"{value}\" to an int";
            }
        }

        /// <summary>
        /// out variable can be implicitly declared inline of the out usage.
        /// Can access out variable anywhere in local block after it's initialized.
        /// </summary>
        public string NewoutVariableUsage(string value)
        {
            var isInt = false;

            if (int.TryParse(value, out var intValue)) // implicitly declared (var)
            {
                isInt = true;
            }

            if (isInt)
            {
                return $"Successfully parsed int value {intValue}"; // Access out variable anywhere in local block
            }
			else
            {
                return $"Unable to parse \"{value}\" to an int";
            }
        }
    }
}
