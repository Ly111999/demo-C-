using System;
using MySql.Data.MySqlClient;

namespace ConsoleApp3
{
    public class DBConnection
    {
        public void Insert(Student student)  
        {  
            try  
            {  
                
                string MyConnection2 = "datasource=localhost;port=3307;username=root;password=root";  
                string Query = "insert into mydata_demo.students (rollNumber, name, email) values('" +student.RollNumber+ "','" +student.Name+"','" +student.Email+ "');";  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);  
                MySqlDataReader MyReader2;  
                MyConn2.Open();  
                MyReader2 = MyCommand2.ExecuteReader();     
                //MessageBox.Show("Save Data");  
                while (MyReader2.Read())  
                {                     
                }  
                MyConn2.Close();  
            }  
            catch (Exception ex)  
            {   
               // MessageBox.Show(ex.Message);  
                Console.WriteLine(ex.Message);
            }  
        }  
    }
}