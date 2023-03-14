# ForemAnalyticsGatherer
Retrieves analytics for forem

The command line arguments supported are as follows:

```powershell
 -a, --articleGatherer     (Default: true) Whether the article gatherer is enabled

  -f, --followerGatherer    (Default: true) Whether the follower gatherer is enabled

  -f, --GatherData          (Default: once per day) How often to gather data in TimeSpan format

  -k, --ApiKey              The API key used to connect to the Forem API

  -n, --NodeList            A list of opensearch nodes

  -b, --BasePath            (Default: https://dev.to) The base path of the Forem site

  --help                    Display this help screen.

  --version                 Display version information.
```