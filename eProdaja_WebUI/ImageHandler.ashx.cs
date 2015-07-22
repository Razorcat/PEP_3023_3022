using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using eProdaja_Service.Data;
using System.Data;

namespace eProdaja_WebUI
{
    /// <summary>
    /// Summary description for ImageHandler
    /// </summary>
    public class ImageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                int proizvodId = Convert.ToInt32(context.Request["id"]);
                DataRow row = DAProizvodi.SelectById2(proizvodId);

                context.Response.ContentType = "image/jpg";
                context.Response.BinaryWrite((byte[])row["SlikaThumb"]);
            }
            catch
            {
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}