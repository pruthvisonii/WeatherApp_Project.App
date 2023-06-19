using System.Collections.Generic;

namespace YourAppName.Services
{
    public class LocationService
    {
        private List<Location> savedLocations;

        public LocationService()
        {
            savedLocations = new List<Location>();
        }

        public List<Location> GetSavedLocations()
        {
            return savedLocations;
        }

        public void SaveLocation(Location location)
        {
            savedLocations.Add(location);
        }

        public void RemoveLocation(Location location)
        {
            savedLocations.Remove(location);
        }
    }
}
