using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JiongNote.Utility
{
    public class DownloadHelper
    {
        /// <summary>
        /// 下载网络文件
        /// </summary>
        /// <param name="webUrl"></param>
        /// <param name="localPath"></param>
        /// <returns></returns>
        public static bool DownloadAsync(string webUrl, string localPath)
        {
            string url = "http://www.mozilla.org/images/feature-back-cnet.png";
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFileAsync(new Uri(webUrl), localPath);
            return true;
        }
    }
}
