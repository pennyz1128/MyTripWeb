using MyTripWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTripWeb.Services
{
    public interface ITouristRouteRepository
    {
        IEnumerable<TouristRoute> GetTouristRoutes();
        TouristRoute GetTouristRoute(Guid touristRouteId);
    }
}
