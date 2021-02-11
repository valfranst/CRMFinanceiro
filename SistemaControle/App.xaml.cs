using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SistemaControle
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            //Register Syncfusion license
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk5NTcxQDMxMzgyZTMyMmUzMFZ1NU1ZbTREWTI0WlNYc21Vb0gyWFZIam1SMkhsTmdoL1ZwNDBMeDZrZ2M9");
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("@31382e332e30gP/jiNZNfuqY8dq9YPHYNGZHjvR4vmIHLbP292W7IN4=");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("@ 31382e342e30KrpZ1XY04TjLthxyFjz2DN8fROlfdNlnZavcRYAcHLg ="); //18.4.0.30


        }

    }
}
