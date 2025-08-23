using Microsoft.EntityFrameworkCore;

namespace NeGlovo.Entities.Owned;

[Owned]
public class Coordinates
{
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }

    public Coordinates(decimal latitude, decimal longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }
    
    /// <summary>
    /// Вычисляет расстояние (в километрах) до других координат.
    /// </summary>
    public double DistanceTo(Coordinates other)
    {
        const double earthRadiusKm = 6371.0;

        var lat1Rad = DegreesToRadians((double)Latitude);
        var lon1Rad = DegreesToRadians((double)Longitude);
        var lat2Rad = DegreesToRadians((double)other.Latitude);
        var lon2Rad = DegreesToRadians((double)other.Longitude);

        var dLat = lat2Rad - lat1Rad;
        var dLon = lon2Rad - lon1Rad;

        var a = Math.Pow(Math.Sin(dLat / 2), 2) +
                Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                Math.Pow(Math.Sin(dLon / 2), 2);

        var c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));

        return earthRadiusKm * c;
    }

    private static double DegreesToRadians(double degrees)
    {
        return degrees * Math.PI / 180.0;
    }
}