using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public class DBConnection
    {
        public static OleDbConnection GetConnection()
        {
            string conStr =
                @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data Source=" + Application.StartupPath +
                @"\OMC.accdb;";

            return new OleDbConnection(conStr);
        }
    }
    internal class Class1
    {
    }
}
