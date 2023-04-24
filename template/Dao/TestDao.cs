using Seven_pay.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;


namespace Lomo_Template.Dao
{
    public class TestDao : BaseDao
    {
        public TestDao(string connectionString) : base(connectionString) { }

        public List<object> GetPerson()
        {
            var res = new List<object>();
            try
            {
                DBContext.OpenConnection();
                // Commented for test
                var sqlCommand = DBContext.CreateStoredProcedureCommand("dbo.GetPeople");
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int PeopleId = ReadInt(reader, 0);
                        string Name = ReadString(reader, 1);
                        string LastName = ReadString(reader, 2);
                        string Phone = ReadString(reader, 3);
                        res.Add(PeopleId);
                        res.Add(Name);
                        res.Add(LastName);
                        res.Add(Phone);
                    }
                }
                DBContext.CommitTransaction();
            }
            catch (Exception e)
            {
                DBContext.RollbackTransaction();
                throw e;
            }
            finally
            {
                DBContext.CloseConnection();
            }
            return res;
        }
        public List<object> GetAdress()
        {
            var res = new List<object>();
            try
            {
                DBContext.OpenConnection();
                var sqlCommand = DBContext.CreateStoredProcedureCommand("dbo.GetAdress");
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Id = ReadInt(reader, 0);
                        int PeopleId = ReadInt(reader, 1);
                        string Address = ReadString(reader, 2);
                        res.Add(Id);
                        res.Add(PeopleId);
                        res.Add(Address);
                    }
                }
                DBContext.CommitTransaction();
            }
            catch (Exception e)
            {
                DBContext.RollbackTransaction();
                throw e;
            }
            finally 
            {
                DBContext.CloseConnection();
            }
            return res;
        }

        public List<object> GetOnlyAddress()
        {
            var res = new List<object>();
            try
            {
                DBContext.OpenConnection();
                var sqlCommand = DBContext.CreateStoredProcedureCommand("dbo.GetOnlyAdress");
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Address = ReadString(reader, 0);
                        res.Add(Address);
                    }
                }
                DBContext.CommitTransaction();
            }
            catch (Exception e)
            {
                DBContext.RollbackTransaction();
                throw e;
            }
            finally
            {
                DBContext.CloseConnection();
            }
            return res;
        }

        public List <object> GetPeopleAdress()
        {
            var res = new List <object>();
            try
            {
                DBContext.OpenConnection();
                var sqlCommand = DBContext.CreateStoredProcedureCommand("dbo.GetPeopleAdress");
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int PeopleId = ReadInt(reader, 0);
                        string Name = ReadString(reader, 1);
                        string LastName = ReadString(reader, 2);
                        string Phone = ReadString(reader, 3);
                        string Adress = ReadString(reader, 4);
                        res.Add(PeopleId);
                        res.Add(Name);
                        res.Add(LastName);
                        res.Add(Phone);
                        res.Add(Adress);
                    }
                }
                DBContext.CommitTransaction();
            }
            catch(Exception e)
            {
                DBContext.RollbackTransaction();
                throw e;
            }
            finally { DBContext.CloseConnection(); }
            return res;
        }

        public List<object> GetAdressPeople()
        {
            var res = new List<object>();
            try
            {
                DBContext.OpenConnection();
                var sqlCommand = DBContext.CreateStoredProcedureCommand("dbo.GetAdressPeople");
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Address = ReadString(reader, 0);
                        string Name = ReadString(reader, 1);
                        string Lastname = ReadString(reader, 2);
                        res.Add(Address);
                        res.Add(Name);
                        res.Add(Lastname);
                    }
                }
                DBContext.CommitTransaction();
            }
            catch (Exception e)
            {
                DBContext.RollbackTransaction();
                throw e;
            }
            finally
            {
                DBContext.CloseConnection();
            }
            return res;
        }
        

        public int CreatePerson(object test)
        {

            int res = 0;
            try
            {
                DBContext.OpenConnection();
                // Commented for test
                var sqlCommand = DBContext.CreateStoredProcedureCommand("dbo.CreatePerson");

                //AddStringParameter(sqlCommand, "@Name", test.ToString()); 
                //AddStringParameter(sqlCommand, "@LastName", test.ToString());
                //AddStringParameter(sqlCommand, "@Phone", test.ToString()); 


                var Name = sqlCommand.Parameters.AddWithValue("@Name", test.ToString());
                var Lastname = sqlCommand.Parameters.AddWithValue("@Lastname", test.ToString());
                var Phone = sqlCommand.Parameters.AddWithValue("@Phone", test.ToString());

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                DBContext.CommitTransaction();
                
                //res = (int)sqlCommand.ExecuteScalar();
                
            }
            catch (Exception e)
            {
                DBContext.RollbackTransaction();
                throw e;
            }
            finally
            {
                DBContext.CloseConnection();
            }
            return res;
        }

        public int CreateAddress(object test)
        {
            int res = 0;
            //bool res;
            try
            {
                DBContext.OpenConnection();
                var sqlCommand = DBContext.CreateStoredProcedureCommand("dbo.CreateAdress");
                //sqlCommand.Parameters.AddWithValue("@PersonId", test);
                //sqlCommand.Parameters.AddWithValue("@Adress", test.ToString());

                var PersonId = sqlCommand.Parameters.AddWithValue("@PersonId", test);
                var Address = sqlCommand.Parameters.AddWithValue("@Address", test.ToString());
                

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                DBContext.CommitTransaction();
                //res = true;
            }
            catch (Exception e)
            {
                DBContext.RollbackTransaction(); 
                throw e;
            }
            finally { DBContext.CloseConnection();}
            return res;
        }


        public object GetTestById(int id)
        {
            return "Falta implementar";
        }
    }
}
