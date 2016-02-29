namespace BangaloreUniversityLearningSystem.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using Interfaces;

    public class Route : IRoute
    {
        public Route(string routeUrl)
        {
            this.Parse(routeUrl);
        }

       public IDictionary<string, string> Parameters { get; private set; }

        private void Parse(string routeUrl)
        {
            string[] urlParts = routeUrl.Split(
                new[] { "/", "?" }, 
                StringSplitOptions.RemoveEmptyEntries);
            if (urlParts.Length < 2)
            {
                throw new InvalidOperationException("The provided route is invalid.");
            }

            this.ControllerName = urlParts[0] + "Controller";
            this.ActionName = urlParts[1];
            if (urlParts.Length >= 3)
            {
                this.Parameters = new Dictionary<string, string>();
                string[] parameterPairs = urlParts[2].Split('&');
                foreach (var pair in parameterPairs)
                {
                    string[] name_value = pair.Split('=');
                    this.Parameters.Add(WebUtility.UrlDecode(name_value[0]), WebUtility.UrlDecode(name_value[1]));
                }
            }
        }

        public string ActionName { get; private set; }

        public string ControllerName { get; private set; }
    }
}