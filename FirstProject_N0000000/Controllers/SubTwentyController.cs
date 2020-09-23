using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstProject_N0000000.Controllers
{
    public class SubTwentyController : ApiController
    {

        // POST /api/SubTwenty/30 -> 10
        /// <summary>
        /// Subtracts 20 from the input
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Get(int id)
        {
            int difference = id - 20;
            return difference;
        }

    }
}
