using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Data.Stub
{
    public class StubCinemaDataService : ICinemaDataService
    {
        public void CloseDataGateway(ICinemaDataGateway cinemaDataGateway)
        {
           // Do nothing.
        }

        public ICinemaDataGateway OpenDataGateway()
        {
            return new StubCinemaDataGateway();
        }
    }
}
