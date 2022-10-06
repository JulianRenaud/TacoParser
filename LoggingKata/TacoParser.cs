using System;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // ~DONE~ Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // ~DONE~ If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                logger.LogError("Invalid Information");
                // ~DONE~ Log that and return null
                // ~DONE~ Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // ~DONE~ grab the latitude from your array at index 0
            var lat = cells[0];
            // ~DONE~ grab the longitude from your array at index 1
            var lng = cells[1];
            // ~DONE~ grab the name from your array at index 2
            var name = cells[2];

            // ~DONE~ Your going to need to parse your string as a `double`
            // ~DONE~ which is similar to parsing a string as an `int`
            var latitude = double.Parse(lat);
            var longitude = double.Parse(lng);
            // ~DONE~ You'll need to create a TacoBell class
            // ~DONE~ that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            Point point = new Point();
            point.Latitude = latitude;
            point.Longitude = longitude;
            
            
            TacoBell tacoBell = new TacoBell();
            tacoBell.Name = name;

            tacoBell.Location = point;

            // DONE Then, return the instance of your TacoBell class
            // DONE Since it conforms to ITrackable
            //TESTS PASSED

            return tacoBell;
        }
    }
}