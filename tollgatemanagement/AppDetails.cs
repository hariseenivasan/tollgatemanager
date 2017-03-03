/**
 * Author: Sri Hari Haran Seenivasan
 * Class: AppDetails
 * Description: Singletonclass holds the application context.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace tollgatemanagement
{
    public sealed class AppDetails
    {
        private static int _empId { get; set; }
        private static int _postalCode { get; set; }
        private static bool _isAdmin { get; set; }

        private static AppDetails instance = null;

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static AppDetails()
        {
        }

        private AppDetails()
        {
        }
        private AppDetails(int empId, int postalCode, bool isAdmin)
        {
            _empId = empId;
            _postalCode = postalCode;
            _isAdmin = isAdmin;
        }
        public static void Create(int empId, int postalCode, bool isAdmin)
        {
            if (instance != null)
            {
                throw new Exception("Object already created");
            }
            instance = new AppDetails(empId,postalCode,isAdmin);
        }
        public static void Clear()
        {
            instance = null;
        }
        public static AppDetails Instance
            {
                get
                {
                    return instance;
                }
            }

        public static int empId
        {
            get
            {
                return _empId;
            }
        }
        public static int postalCode
        {
            get
            {
                return _postalCode;
            }
        }
        public static bool isAdmin
        {
            get
            {
                return _isAdmin;
            }
        }

    }
}
