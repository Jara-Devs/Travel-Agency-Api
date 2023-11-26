using Travel_Agency_Core.Enums;
using Travel_Agency_Domain.Services;

namespace Travel_Agency_Domain.Offers;

public class FlightOffer : Offer
{
    public int FlightId { get; set; }

    public Flight Flight { get; set; } = null!;

    public List<FlightFacility> Facilities { get; set; }

    public FlightOffer(string name, int availability, string description, double price, long startDate,
        long endDate, int agencyId, int flightId, List<FlightFacility> facilities, int imageId)
        : base(description, price, name, availability, startDate, endDate, agencyId, imageId, OfferType.Flight)
    {
        this.FlightId = flightId;
        this.Facilities = facilities;
    }
}