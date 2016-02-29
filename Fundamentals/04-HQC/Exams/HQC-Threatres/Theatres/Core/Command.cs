namespace Theatres.Core
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Interfaces;

    public class Command
    {
        public static string ExecuteAddTheatreCommand(string[] parameters, IPerformanceDatabase database)
        {
            string theatreName = parameters[0];
            database.AddTheatre(theatreName);
            return "Theatre added";
        }

        public static string ExecutePrintAllTheatresCommand(IPerformanceDatabase database)
        {
            var theatresCount = database.ListTheatres().Count();
            if (theatresCount > 0)
            {
                //var resultTheatres = new LinkedList<string>();
                //for (int i = 0; i < theatresCount; i++)
                //{
                //    database.ListTheatres().Skip(i).ToList().ForEach(t => resultTheatres.AddLast(t));
                //    foreach (var t in database.ListTheatres().Skip(i + 1))
                //    {
                //        resultTheatres.Remove(t);
                //    }
                //}
                return String.Join(", ", database.ListTheatres());
            }

            return "No theatres";
        }

        public static string ExecutePrintAllPerformancesCommand(IPerformanceDatabase database)
        {
            var performances = database.ListAllPerformances().ToList();
            if (!performances.Any())
            {
                return "No performances";
            }

            var sb = new StringBuilder();

            //sb.AppendFormat("({0}, {1}, {2}), ",
            //        performances[0].PerformanceTitle,
            //        performances[0].TheatreName,
            //        performances[0].StartDateTime.ToString("dd.MM.yyyy HH:mm"));

            for (int i = 0; i < performances.Count; i++)
            {
                sb.AppendFormat("({0}, {1}, {2}), ",
                    performances[i].PerformanceTitle,
                    performances[i].TheatreName,
                    performances[i].StartDateTime.ToString("dd.MM.yyyy HH:mm"));
            }

            return sb.ToString().Trim(' ', ',');
        }

        public static string ExecuteAddPerformanceCommand(string[] commandParams, IPerformanceDatabase database)
        {
            string theatreName = commandParams[0];
            string performanceTitle = commandParams[1];
            DateTime startDateTime = DateTime.ParseExact(commandParams[2],
                "dd.MM.yyyy HH:mm",
                CultureInfo.InvariantCulture);
            TimeSpan duration = TimeSpan.Parse(commandParams[3]);
            decimal price = decimal.Parse(commandParams[4], NumberStyles.Float);

            database.AddPerformance(theatreName,
                performanceTitle,
                startDateTime,
                duration,
                price);

            return "Performance added";
        }

        public static string ExecutePrintPerformanceCommand(string[] commandParams, IPerformanceDatabase database)
        {
            string theatre = commandParams[0];
            var performances = database.ListOfPerformances(theatre)
                .Select(p => string.Format(
                    "({0}, {1})",
                    p.PerformanceTitle,
                    p.StartDateTime.ToString("dd.MM.yyyy HH:mm")))
                .ToList();

            if (performances.Any())
            {
                var result = string.Join(", ", performances);
                return result;
            }

            return "No performances";
        }
    }
}