using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Data
{
    public interface ICinemaDataService
    {
        ICinemaDataGateway OpenDataGateway();
        void CloseDataGateway(ICinemaDataGateway cinemaDataGateway);
    }
}
