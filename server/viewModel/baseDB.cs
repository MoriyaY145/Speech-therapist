using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using model;

namespace viewModel
{
    public abstract class baseDB
    {

        protected string connectionString;
        protected OleDbConnection connection;
        protected OleDbCommand command;
        protected OleDbDataReader reader;
        protected List<baseEntity> list;
        protected List<baseEntity> inserted = new List<baseEntity>();
        protected List<baseEntity> changed = new List<baseEntity>();
        protected List<baseEntity> deleted = new List<baseEntity>();
        public baseDB(string class_name)
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + GetCurrentPath() + "Data\\project_moriya.accdb");
            command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from " + class_name;
            list = new List<baseEntity>();
        }
        public string GetCurrentPath()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            string[] arr = path.Split('\\');
            path = "";
            for (int i = 0; i < arr.Length - 3; i++)
            {
                path += arr[i] + "\\";
            }
            return path;
        }
        protected abstract baseEntity CreateModel();
        protected void Select()
        {
            //List<baseEntity> lst = new List<baseEntity>();
            try
            {
                //פותחות את הקישור
                connection.Open();
                //יוצרות אוביקט שלתוכו נכנסים הנתונים מהמסד
                reader = command.ExecuteReader();
                //עוברות על מה שהגיע
                while (reader.Read())
                {
                    list.Add(CreateModel());
                }
            }
            catch (Exception ex) { }
            finally
            {
                //סגירת החיבור כדי לשחרר משאבים מהזיכרון
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        public void Add(baseEntity item)
        {
            if (item != null)
                inserted.Add(item);
        }
        public void Update(baseEntity item)
        {
            if (item != null)
                changed.Add(item);
        }
        public void Deleted(baseEntity item)
        {
            if (item != null)
                deleted.Add(item);
        }
        public int SaveChanges()
        {
            int records = 0;
            try
            {
                command.Connection = connection;
                connection.Open();
                foreach (var item in inserted)
                {
                    try
                    {
                        command.CommandText = SQLBuilder.InsertSQL(item);
                        records += command.ExecuteNonQuery();
                    }
                    catch
                    {
                        inserted.Remove(item);
                    }
                }
                inserted.Clear();
                foreach (var item in changed)
                {
                    try
                    {
                        command.CommandText = SQLBuilder.UpdateSQL(item);
                        records += command.ExecuteNonQuery();
                    }
                    catch
                    {
                        changed.Remove(item);
                    }
                }
                changed.Clear();
                foreach (var item in deleted)
                {
                    try
                    {
                        command.CommandText = SQLBuilder.DeleteSQL(item);
                        records += command.ExecuteNonQuery();
                        list.Remove(item);
                    }
                    catch
                    {
                        deleted.Remove(item);
                    }
                }
                deleted.Clear();
            }

            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message + "\nDataBase:" + command.CommandText);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return records;
        }
        protected abstract string CreateInsertCommand(baseEntity item);
        protected abstract string CreateUpdateCommand(baseEntity item);
        protected abstract string CreateDeletedCommand(baseEntity item);
    }
}
