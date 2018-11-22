using System;
using System.Net;
namespace Idolwars
{
    class Program
    {
        delegate void Del();
        static void Main(string[] args)
        {
            int un = 0;
            string basic = "http://api-x.idolwars.jp/audio/title_call/";
            string us = ".m4a";
            int cnt = 1;
            string file = @"C:temp\";
            //basic=元のURLのベース
            //un=URLの数列
            //us=.jpgを入れる
            //cnt=カウント確認

            int udon = 0;
           
            while (true)
            {
                cnt = cnt + 1;
                un = un + 1;

                if (true)
                {
                    string con = "0" + cnt;
                    string URL = basic + con + us;
                    string dls = file + un + us;

                    try
                    {
                        Console.WriteLine("downloading...  " + un + us);
                        WebClient client = new WebClient();
                        client.DownloadFile(URL, dls);
                        Console.WriteLine("downloaded" + un + us);
                    }

                     catch (WebException sya)
                     {

                        //わざと開けてる
                        Console.WriteLine("Download Error!");

                        
                        
                        
                        if (udon > 10)
                        {
                            goto LOOP_END;
                        }

                        udon = udon + 1;
                     }

                }
                /*
                else
                {
                    string URL = basic + un + us;
                    string dls = file + un + us;

                    try
                    {
                        WebClient client = new WebClient();
                        client.DownloadFile(URL, dls);
                        Console.WriteLine("downloading...  " + un + us);
                    }

                     catch (WebException ex)
                     {
                        //わざと開けてる
                     }
                    
                }

            */

               

                /*

                //WebRequestの作成
                HttpWebRequest webreq =
                    (HttpWebRequest)WebRequest.Create(url);

                HttpWebResponse webres = null;
                try
                {
                    //サーバーからの応答を受信するためのWebResponseを取得
                    webres = (HttpWebResponse)webreq.GetResponse();

                    //応答したURIを表示する
                    Console.WriteLine(webres.ResponseUri);
                    //応答ステータスコードを表示する
                    Console.WriteLine("{0}:{1}",
                        webres.StatusCode, webres.StatusDescription);
                }*/
                
                    /*//HTTPプロトコルエラーかどうか調べる
                    if (ex.Status == WebExceptionStatus.ProtocolError)
                    {
                        //HttpWebResponseを取得
                        HttpWebResponse errres =
                            (HttpWebResponse)ex.Response;
                        {
                            Environment.Exit(0);
                            //404で停止

                            cnt = cnt - 1;

                        }
                    } */
                
            }
            LOOP_END: ;
        }
    }
}