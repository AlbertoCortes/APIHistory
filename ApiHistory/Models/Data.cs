using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiHistory.Models
{
    public class Data
    {
        static DataProductsEntities model = new DataProductsEntities();
        public static void InsertData(VideoHist vid)
        {
            model.ACOB_InsertHistory(
                vid.videoName,
                vid.videoId

                );
        }
        public static List<VideoHist>ListHistorial(){
            var obj = model.ACOB_SelectHistory();
            return SerializeJson<IEnumerable<ACOB_SelectHistory_Result>, List<VideoHist>>(obj);
            }

        public static Out SerializeJson<In, Out>(In obj)
        {
            string output = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<Out>(output);
        }

    }

}