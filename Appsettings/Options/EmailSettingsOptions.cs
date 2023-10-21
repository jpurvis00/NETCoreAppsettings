namespace Appsettings.Options
{
    public class EmailSettingsOptions
    {
        public bool EnableMailSystem { get; set; }
        public int EmailTimeOutInSeconds { get; set; }
        public List<string> EmailServers { get; set; } = new List<string>();
        public EmailAdminOptions EmailAdmin { get; set; } = new EmailAdminOptions();
    }
}
