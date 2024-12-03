using CoolApp.MVVM.Models;
using SQLite;

namespace CoolApp.Data
{
    public class DiseasesRepository : IDiseasesRepository
    {
        SQLiteConnection connection;
        public string StatusMessage { get; set; } = string.Empty;
        public DiseasesRepository()
        {
            connection = new SQLiteConnection(Constants.DBPath, Constants.Flags);

            connection.CreateTable<Disease>();
        }


        public void Add(Disease disease)
        {
            int result = 0;
            try
            {
                result = connection.Insert(disease);
                StatusMessage = $"{result} record(s) added [Name: {disease.Name})";
            }
            catch (SQLiteException ex)
            {
                StatusMessage = $"Failed to add {disease.Name}. Error: {ex.Message}";
            }
        }

        public void Update(Disease disease)
        {
            int result = 0;
            try
            {
                result = connection.Update(disease);
                StatusMessage = $"{result} record(s) updated [Name: {disease.Name})";
            }
            catch (SQLiteException ex)
            {
                StatusMessage = $"Failed to update {disease.Name}. Error: {ex.Message}";
            }
        }

        public void Delete(Disease disease)
        {
            int result = 0;
            try
            {
                result = connection.Delete(disease);
                StatusMessage = $"{result} record(s) deleted [Name: {disease.Name})";
            }
            catch (SQLiteException ex)
            {
                StatusMessage = $"Failed to delete {disease.Name}. Error: {ex.Message}";
            }
        }

        public Disease GetDisease(int id)
        {
            try
            {
                return connection.Table<Disease>().FirstOrDefault(d => d.Id == id);
            }
            catch (SQLiteException ex)
            {
                StatusMessage = $"Failed to retrieve record. Error: {ex.Message}";
            }
            return null;
        }

        public List<Disease> GetAllDiseases()
        {
            try
            {
                return connection.Table<Disease>().ToList();
            }
            catch (SQLiteException ex)
            {
                StatusMessage = $"Failed to retrieve records. Error: {ex.Message}";
            }
            return null;
        }
    }
}