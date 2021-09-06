using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ConnectAPI
{
    public interface ICovidConnectAPI
    {
        Task<List<APICoronavirusCountry>> GetAll();
        Task<List<LatLongCountry>> GetAllLG();
    }
}
