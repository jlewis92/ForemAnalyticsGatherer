using CommandLine;

namespace ForemAnalyticsGathererConsole
{
    public class CommandLineOptions
    {
        [Option('a', "articleGatherer", Default = true, HelpText = "Whether the article gatherer is enabled")]
        public bool ArticleGatherer { get; set; }

        [Option('f', "followerGatherer", Default = true, HelpText = "Whether the follower gatherer is enabled")]
        public bool FollowerGatherer { get; set; }

        [Option('f', "GatherData", HelpText = "(Default: once per day) How often to gather data in TimeSpan format")]
        public TimeSpan GatherDataTimeSpan { get; set; } = TimeSpan.FromDays(1);

        [Option('k', "ApiKey", HelpText = "The API key used to connect to the Forem API")]
        public string ApiKey { get; set; } = string.Empty;

        [Option('n', "NodeList", HelpText = "A list of opensearch nodes")]
        public List<Uri> NodeList { get; set; } = new List<Uri>();

        [Option('b', "BasePath", HelpText = "(Default: https://dev.to) The base path of the Forem site")]
        public string BasePath { get; set; } = "https://dev.to";
    }
}
