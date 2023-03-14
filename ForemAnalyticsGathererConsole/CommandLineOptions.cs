using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForemAnalyticsGathererConsole
{
    public class CommandLineOptions
    {
        [Option('a', "articleGatherer", Default = true, HelpText = "Whether the article gatherer is enabled")]
        public bool ArticleGatherer { get; set; }

        [Option('f', "followerGatherer", Default = true, HelpText = "Whether the follower gatherer is enabled")]
        public bool FollowerGatherer { get; set; }

        [Option('f', "GatherData", HelpText = "How often to gather data in TimeSpan format. Defaults to once per day")]
        public TimeSpan GatherDataTimeSpan { get; set; } = TimeSpan.FromDays(1);

        [Option('k', "ApiKey", HelpText = "How often to gather data in TimeSpan format. Defaults to once per day")]
        public string ApiKey { get; set; } = string.Empty;
    }
}
