using System.Net;

namespace ForemAnalyticsGatherer.Utilities
{
    internal static class HttpUtilities
    {
        private static List<HttpStatusCode> _succcessCodes = new List<HttpStatusCode> {
                 HttpStatusCode.OK,
                 HttpStatusCode.Created,
                 HttpStatusCode.Accepted,
                 HttpStatusCode.NonAuthoritativeInformation,
                 HttpStatusCode.NoContent,
                 HttpStatusCode.ResetContent,
                 HttpStatusCode.PartialContent
            };

        public static bool IsSuccessStatusCode(HttpStatusCode statusCode)
        {
            return _succcessCodes.Contains(statusCode);
        }
    }
}
