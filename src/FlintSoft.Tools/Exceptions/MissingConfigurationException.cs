namespace FlintSoft.Tools.Exceptions;

/// <summary>
/// Exception thrown when a configuration is missing
/// </summary>
public class MissingConfigurationException : Exception
{
    public string Section { get; set; } = "";

    public MissingConfigurationException(string section) : base(string.Format("Configuration section '{0}' is missing, configuration couldn't be loaded!", section))
    {
        Section = section;
    }

    public MissingConfigurationException(string section, string errorMessage) : base(errorMessage)
    {
        Section = section;
    }

    public MissingConfigurationException(string section, string errorMessage, Exception innerException) : base(errorMessage, innerException)
    {
        Section = section;
    }
}
