using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for objbrowser
/// </summary>
public class objbrowser
{
    private string _id;
    private string _type;
    private string _version;
    private string _platform;
    private string _ecma;
    private bool _isMobileDevice;
    private bool _isBeta;
    private bool _isWin16;
    private bool _isWin32;
    private bool _sp_Tables;
    private bool _sp_Cookies;
    private bool _sp_CSS;
    private bool _sp_JavaScript;
    private bool _sp_CallBack;
    private bool _sp_XMLHttp;
    private bool _canSendMail;
   

    public objbrowser()
    {

    }

    public string Id
    {
        get
        {
            return _id;
        }

        set
        {
            _id = value;
        }
    }

    public string Type
    {
        get
        {
            return _type;
        }

        set
        {
            _type = value;
        }
    }

    public string Version
    {
        get
        {
            return _version;
        }

        set
        {
            _version = value;
        }
    }

    public string Platform
    {
        get
        {
            return _platform;
        }

        set
        {
            _platform = value;
        }
    }

    public string Ecma
    {
        get
        {
            return _ecma;
        }

        set
        {
            _ecma = value;
        }
    }

    public bool IsMobileDevice
    {
        get
        {
            return _isMobileDevice;
        }

        set
        {
            _isMobileDevice = value;
        }
    }

    public bool IsBeta
    {
        get
        {
            return _isBeta;
        }

        set
        {
            _isBeta = value;
        }
    }

    public bool IsWin16
    {
        get
        {
            return _isWin16;
        }

        set
        {
            _isWin16 = value;
        }
    }

    public bool IsWin32
    {
        get
        {
            return _isWin32;
        }

        set
        {
            _isWin32 = value;
        }
    }

    public bool Sp_Tables
    {
        get
        {
            return _sp_Tables;
        }

        set
        {
            _sp_Tables = value;
        }
    }

    public bool Sp_Cookies
    {
        get
        {
            return _sp_Cookies;
        }

        set
        {
            _sp_Cookies = value;
        }
    }

    public bool Sp_CSS
    {
        get
        {
            return _sp_CSS;
        }

        set
        {
            _sp_CSS = value;
        }
    }

    public bool Sp_JavaScript
    {
        get
        {
            return _sp_JavaScript;
        }

        set
        {
            _sp_JavaScript = value;
        }
    }

    public bool Sp_CallBack
    {
        get
        {
            return _sp_CallBack;
        }

        set
        {
            _sp_CallBack = value;
        }
    }

    public bool Sp_XMLHttp
    {
        get
        {
            return _sp_XMLHttp;
        }

        set
        {
            _sp_XMLHttp = value;
        }
    }

    public bool CanSendMail
    {
        get
        {
            return _canSendMail;
        }

        set
        {
            _canSendMail = value;
        }
    }
}