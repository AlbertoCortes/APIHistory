using ApiHistory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiHistory.Controllers
{
    public class ApiHistoryController : ApiController
    {
        public List<VideoHist> Get()
        {
            List<VideoHist> hist = new List<VideoHist>();
            hist.AddRange(Data.ListHistorial());
            return hist;
        }

        public void Post([FromBody] VideoHist vid)
        {
            Data.InsertData(vid);
        }
    }
}
