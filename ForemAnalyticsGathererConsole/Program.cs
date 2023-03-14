using System;
using System.Timers;
using CommandLine;
using ForemAnalyticsGatherer.DataGatherers;
using Microsoft.Extensions.Configuration;

namespace ForemAnalyticsGathererConsole
{
    public class Program
    {
        private static ArticleData? _foremArticlesGatherer;
        private static FollowerData? _foremFollowersGatherer;
        private static CommandLineOptions _commandLineOptions = new CommandLineOptions();
        private static ManualResetEvent _quitEvent = new ManualResetEvent(false);

        static void Main(string[] args)
        {
            Console.CancelKeyPress += (sender, eArgs) => {
                _quitEvent.Set();
                eArgs.Cancel = true;
            };

            var options = Parser.Default.ParseArguments<CommandLineOptions>(args)
                .WithParsed(RunOptions)
                .WithNotParsed(HandleParseError);

            var environment = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                       .AddJsonFile("appsettings.json")
                       .AddJsonFile($"appsettings.{environment}.json", optional: true)
                       .AddUserSecrets<Program>()
                       .AddEnvironmentVariables();

            IConfiguration config = builder.Build();

            var appSettings = config.GetSection("AppSettings").Get<ForemAnalyticsGatherer.Settings.AppSettings>();

            if (_commandLineOptions.ApiKey != string.Empty)
            {
                appSettings.ApiKey = _commandLineOptions.ApiKey;
            }
            else
            {
                Console.WriteLine("API key not passed in.  Attempting to use API key from app settings");
            }

            if (_commandLineOptions.ArticleGatherer)
            {
                _foremArticlesGatherer = new ArticleData(appSettings);
            }

            if (_commandLineOptions.FollowerGatherer)
            {
                _foremFollowersGatherer = new FollowerData(appSettings);
            }

            var foremTimer = new System.Timers.Timer(_commandLineOptions.GatherDataTimeSpan.TotalMilliseconds);
            foremTimer.Elapsed += OnTimedEvent;
            foremTimer.AutoReset = true;
            foremTimer.Enabled = true;

            // Call the article gatherer just to get it to run immediately
            RunArticleGatherer();

            // make sure the only way to stop this is to press ctrl + c
            _quitEvent.WaitOne();
        }

        private static void RunOptions(CommandLineOptions opts)
        {
            _commandLineOptions = opts;
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
            Console.Error.WriteLine(errs);
        }

        private static void OnTimedEvent(object? source, ElapsedEventArgs e)
        {
            RunArticleGatherer();
        }

        private static void RunArticleGatherer()
        {
            try
            {
                if (_foremArticlesGatherer != null)
                {
                    var articles = _foremArticlesGatherer.GatherData().Result;
                }

                if (_foremFollowersGatherer != null)
                {
                    var followers = _foremFollowersGatherer.GatherData().Result;
                }
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine(exception);
            }
        }
    }
}