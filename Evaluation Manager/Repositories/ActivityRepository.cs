using DBLayer;
using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Repositories
{
    public class ActivityRepository
    {
        public static Activity GetActivity(int id)
        {
            Activity activity = null;
            string sql = $"SELECT * FROM Activities WHERE Id= {id}"; //reader za podatke SQL UPIT
            DB.OpenConnection(); //otvara se konekcija s bazom
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                //provjeravamo ima li reasder redova uopce
                reader.Read();
                activity = CreateObject(reader);
                reader.Close(); //zatvaramko reader            }
            }
            DB.CloseConnection();
            return activity;
        }
        public static List<Activity> GetActivities()
        {
            List<Activity> activities = new List<Activity>(); //inicijalizacija liste
            string sql = "SELECT * FROM ACTIVITIES";   //upit koji vraća aktivnosti iz sql upita i sprema ih u tu varijablu
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql); //dinamičko alociranje varijable reader popunjava s onim čim vraća metoda u ovom slučaju to su upiti iz sql tablice
            while (reader.Read()) //proazi po tome readeru
            {
                Activity activity = CreateObject(reader); //spremi jedan po jedan rezultat u varijablu aktivnost
                activities.Add(activity); // aktivnost jednu po jednu spremamo u listu 
            }
            reader.Close();
            DB.CloseConnection(); //zatvara se reader i close
            return activities; // vraćaju se aktivnosti
        } // PROVJERIT STA OVO RADI
        private static Activity CreateObject(SqlDataReader reader)
        {
            // u bazi imam stupac koji se nazive id,name,description. Sve vrijednosti tog stupca pospremiti
            // u varijable koje cemo imati u kodu pomocu int.parse
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Name"].ToString();
            string description = reader["Description"].ToString();
            int maxPoints = int.Parse(reader["MaxPoints"].ToString());
            int minPointsForGrade = int.Parse(reader["MinPointsForGrade"].ToString());
            int minPointsForSignature = int.Parse(reader["MinPointsForSignature"].ToString());
            var activity = new Activity()
            {
                Id = id,
                Name = name, //presklikavamo name koji smo izvadili iz tablice i spremili varijablu u ime klase activity
                Description = description,
                MaxPoints = maxPoints,
                MinPointsForGrade = minPointsForGrade,
                MinPointsForSignature = minPointsForSignature
            };
            return activity;
            }
        }
    }


