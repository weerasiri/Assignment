using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Assignment
{
    internal class studentclass
    {
        DBconnect = new DBconnect();

        public bool insertstudent(string fname,string lname,string id,string degree,DateTime bdate,string gender,string phone,string address, byte[]img)
        {
            Mysqlcommand command = new Mysqlcommand("INSERT INTO 'student'('stdFirstName','stdLastName','stdID','Degree','Birthdate','Gender','phone','Address','photo') VALUES(@fn,@ln,@id,@de,@bd,@gd,@ph,@adr,@img;)"connect.getconnection)
                
            command.parametes.Add("@fn", MysqlDbType.Varchar).Value = fname;
            command.parametes.Add("@ln", MysqlDbType.Varchar).Value = lname;
            command.parametes.Add("@id", MysqlDbType.Varchar).Value = id;
            command.parametes.Add("@de", MysqlDbType.Varchar).Value = degree;
            command.parametes.Add("@bd", MysqlDbType.Date).Value = bdate;
            command.parametes.Add("@gd", MysqlDbType.Varchar).Value = gender;
            command.parametes.Add("@ph", MysqlDbType.Varchar).Value = phone;
            command.parametes.Add("@adr", MysqlDbType.Varchar).Value = address;
            command.parametes.Add("@img", MysqlDbType.Bold).Value = img;

            Connect.openconnect();
            if (command.ExecuteNonQuery() == 1 )
            {
                Connect.closeconnect();
                return true;

            }
            else
            {
                Connect.closeconnect();
                return false;
            }
            Public DataTable getstudentlist()
                {
                Mysqlcommand command = new Mysqlcommand("SELECT * FROM 'STUDENT' ",ConnectionState.getconnection);
                MysqlDataAdapter adapter = new MysqlDataAdapter(command);
                DataTabale table = new DataTabale();
                adapter.fill(table);
                return table;
            }
            Public string exCount(string qury)
            {
                Mysqlcommand command = new Mysqlcommand(Query, Connect.getconnection);
                Connect.openconnect();
                string count = command.ExecuteScalar().ToString();
                Connect.closeConnect();
                return Count;


            }
            Publi string totalstudent()
            {
                return exeCount("SELECT COUNT ("*") FROM student);
            }
            Publi string malestudent()
            {
                return exeCount("SELECT COUNT (" * ") FROM student WHERE 'Gender' = 'Male'");
            }
            Publi string femalestudent()
            {
                return exeCount("SELECT COUNT (" * ") FROM student WHERE 'Gender' = 'Female'");
            }
            Public DataTable serachstudent(string searchdata)
                {
                Mysqlcommand command = new Mysqlcommand("SELECT * FROM 'STUDENT' WHERE CONCAT('stdFirstName','stdLastName','Adsress" Like '"+searchdata+"' ", ConnectionState.getconnection); ;
                MysqlDataAdapter adapter = new MysqlDataAdapter(command);
                DataTabale table = new DataTabale();
                adapter.fill(table);
                return table;
            }


            public bool updatestudent(string fname, string lname, string id, string degree, DateTime bdate, string gender, string phone, string address, byte[] img)
            {
                Mysqlcommand command = new Mysqlcommand("INSERT INTO 'student'('stdFirstName','stdLastName','stdID','Degree','Birthdate','Gender','phone','Address','photo') VALUES(@fn,@ln,@id,@de,@bd,@gd,@ph,@adr,@img;)"connect.getconnection)


            command.parametes.Add("@fn", MysqlDbType.Varchar).Value = fname;
                command.parametes.Add("@ln", MysqlDbType.Varchar).Value = lname;
                command.parametes.Add("@id", MysqlDbType.Varchar).Value = id;
                command.parametes.Add("@de", MysqlDbType.Varchar).Value = degree;
                command.parametes.Add("@bd", MysqlDbType.Date).Value = bdate;
                command.parametes.Add("@gd", MysqlDbType.Varchar).Value = gender;
                command.parametes.Add("@ph", MysqlDbType.Varchar).Value = phone;
                command.parametes.Add("@adr", MysqlDbType.Varchar).Value = address;
                command.parametes.Add("@img", MysqlDbType.Bold).Value = img;

                Connect.openconnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    Connect.closeconnect();
                    return true;

                }
                else
                {
                    Connect.closeconnect();
                    return false;
                }
            }
}
