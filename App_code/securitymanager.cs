using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Permissions;
using System.Security.Principal;
using System.Net.Sockets;
using System.Net;

/// <summary>
/// Summary description for securitymanager
/// </summary>
public class securitymanager 
{
    public securitymanager()
    {
       
    }

    public string authentication() {
        string rs = "";

        return rs ;
    }

    public string checkip() {
        string rs = "";

        return rs;
    }

    public objbrowser checkbrowser(){
        System.Web.HttpBrowserCapabilities browser = HttpContext.Current.Request.Browser ;
        objbrowser objbrowser = new objbrowser();
            objbrowser.Id = browser.Id;
            objbrowser.Type = browser.Type;
            objbrowser.Version = browser.Version;
            objbrowser.Platform = browser.Platform;
            objbrowser.Ecma = browser.EcmaScriptVersion.ToString();
            objbrowser.IsMobileDevice = browser.IsMobileDevice;
            objbrowser.IsBeta = browser.Beta;
            objbrowser.IsWin16 = browser.Win16;
            objbrowser.IsWin32 = browser.Win32;
            objbrowser.Sp_Tables = browser.Tables;
            objbrowser.Sp_Cookies = browser.Cookies;
            objbrowser.Sp_CSS = browser.SupportsCss;
            objbrowser.Sp_JavaScript = browser.JavaScript;
            objbrowser.Sp_CallBack = browser.SupportsCallback;
            objbrowser.Sp_XMLHttp = browser.SupportsXmlHttp;
            objbrowser.CanSendMail = browser.CanSendMail;
        return objbrowser;
    }

    public  string GetLocalIPAddress()
    {
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }
        throw new Exception("Local IP Address Not Found!");
    }

    public void log(string detail , string createBy , string ip) {
        
    }
}