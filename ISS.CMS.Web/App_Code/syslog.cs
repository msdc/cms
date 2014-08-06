using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Text;
using System.IO;

/// <summary>
///syslog 的摘要说明
/// </summary>
public class syslog
{
	public syslog()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public static void login(string tempstr)
    {
        string line, text = "";
        IPHostEntry ip = Dns.GetHostEntry(Dns.GetHostName());
        IPAddress myip = new IPAddress(ip.AddressList[0].GetAddressBytes());
        string filename = System.Web.HttpContext.Current.Server.MapPath("~/manage") + "/syslog.txt";
        StringBuilder htmltext = new StringBuilder();
        try
        {
            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.GetEncoding("utf-8")))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    htmltext.Append(line);
                    text += line + "\r\n";
                }
                sr.Close();

            }
        }
        catch
        {
            // Response.Write( "<Script>alert( )</Script>" );
        }
        if (tempstr == "登陆成功")
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.GetEncoding("utf-8")))
                {
                    sw.WriteLine(text + DateTime.Now.ToString() + " " + System.Web.HttpContext.Current.Session["admin"].ToString() + myip.ToString() + tempstr);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch
            {
                // Response.Write ( "The file could not be wirte:" );
            }
        }
        else
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.GetEncoding("utf-8")))
                {
                    sw.WriteLine(text + DateTime.Now.ToString() + " " + myip.ToString() + tempstr);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch
            {
                // Response.Write ( "The file could not be wirte:" );
            }
        }
    }
}