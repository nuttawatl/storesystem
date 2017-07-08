using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for objlog
/// </summary>
public class objlog
{
    private string _detail;
    private string _createBy;
    private string _createDate;
    private string _ip;

    public objlog()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Detail
    {
        get
        {
            return _detail;
        }

        set
        {
            _detail = value;
        }
    }

    public string CreateBy
    {
        get
        {
            return _createBy;
        }

        set
        {
            _createBy = value;
        }
    }

    public string CreateDate
    {
        get
        {
            return _createDate;
        }

        set
        {
            _createDate = value;
        }
    }

    public string Ip
    {
        get
        {
            return _ip;
        }

        set
        {
            _ip = value;
        }
    }
}