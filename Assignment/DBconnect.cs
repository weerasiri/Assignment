using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    internal class DBconnect
    {
        Mysqlconeection connect = new Msqlconnection("datasource=localhost;port=;username=root;password=root;database=studentdb");

        public Mysqlconnection get connection
            {
                get
             {
                   return connect;
             }
            }

        public void openconnect()
        {
            if (connect().state == System.Data.ConnectionState.closed)
             connect.open();
    
         }
        public void closeconnect()
        {
            if (connect().state == System.Data.ConnectionState.open)
                connect.close();

           }

    }
}
