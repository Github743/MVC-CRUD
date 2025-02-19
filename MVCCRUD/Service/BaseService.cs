using System;
using System.Configuration;

namespace MVCCRUD.Service
{
    public  class BaseService
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["EmpConnection"].ConnectionString.ToString();

        public String ConnectionString
        {
            get
            {
                if (_connectionString == null)
                {
                    _connectionString = ConfigurationManager.ConnectionStrings["EmpConnection"].ConnectionString.ToString();
                    return _connectionString;
                }
                else
                {
                    return _connectionString;
                }
            }
        }

        public static string GetDBString(object obj)
        {
            if (!(obj is DBNull) && obj != null)
            {
                return Convert.ToString(obj);
            }
            else
            {
                return string.Empty;
            }
        }

        public static int GetDBInt(object obj)
        {
            if (!(obj is DBNull) && obj != null)
            {
                return Convert.ToInt32(obj);
            }
            else
            {
                return 0;
            }
        }
    }
}