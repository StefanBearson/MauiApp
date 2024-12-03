using System;
using CoolApp.MVVM.Models;

namespace CoolApp.Data;

public interface IDiseasesRepository
{
    string StatusMessage { get; set; }
    void Add(Disease disease);
    void Update(Disease disease);
    void Delete(Disease disease);
    Disease GetDisease(int id);
    List<Disease> GetAllDiseases();
}
