using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///SiteFun 的摘要说明
/// </summary>
public class SiteFun
{
	public SiteFun()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public static string cutechar(string parStr)
    {
        string strReturn = parStr.ToLower().Replace("--", "").Replace("'", "").Replace("&", "").Replace(";", "").Replace("'", "").Replace("\"", "").Replace(":", "").Replace("(", "").Replace(")", "").Replace(",", "").Replace("exec", "").Replace("%", "").Replace("char", "").Replace("=", "");
        return strReturn;
    }
}