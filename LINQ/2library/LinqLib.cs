using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _2library {
    public class LinqLib {
        public static List<PeopleData> OrderByLastName(PeopleData[] people) {
            return people.OrderBy(x => x.LastName).ToList();
        }
        public static List<PeopleData> OrderByLanguage(PeopleData[] people) {
            return people.OrderBy(x => x.Language).ToList();
        }
        public static List<PeopleData> OrderByCompany(PeopleData[] people) {
            return people.OrderBy(x => x.Company).ToList();
        }
        public static string[] GetLanguages(PeopleData[] people) {
            return people.Select(person => person.Language).Distinct().OrderBy(lang => lang).ToArray();
        }
        public static List<PeopleData> FilterLanguages(PeopleData[] people, string language) {
            return people.Where(person => person.Language == language).ToList();
        }
        public static List<PeopleData> FilterLanguagesByText(PeopleData[] people, string language) {
            return people.Where(person => person.Language.ToLower().StartsWith(language)).ToList();
        }
        public static List<PeopleData> FindLastName(PeopleData[] people, string lastname) {
            return people.Where(person => person.LastName.ToLower().StartsWith(lastname)).ToList();
        }


        //public static void Main(string[] args) {
        //    var fileContent = File.ReadAllText("people.json");
        //    PeopleData[] people = JsonSerializer.Deserialize<PeopleData[]>(fileContent);

        //    var orderedByLastName = people.OrderBy(x => x.LastName);

        //    //foreach (var person in orderedByLastName) {
        //    //    Console.WriteLine(person.LastName + " " + person.FirstName);
        //    //}

        //    //foreach (var p in people) {
        //    //    Console.WriteLine($"| {p.Id, 3} | {p.FirstName,10} | {p.LastName,15} | {p.Email,30} | {p.Gender,10} | {p.Language,8} | {p.University, 16} | {p.DateOfBirth,16} | {p.Country,10} | {p.Company,10} | {p.JobTitle,10}");
        //    //}

        //    var czechs = people.Where(p => p.Language == "Czech");
        //    foreach (var czech in czechs) {
        //        Console.WriteLine($"{czech.FirstName,10} {czech.LastName,9} - {czech.Language}");
        //    }
        //    var english = people.Where(p => p.Language == "English");
        //    foreach (var eng in english) {
        //        Console.WriteLine($"{eng.FirstName,10} {eng.LastName,9} - {eng.Language}");
        //    }

        //}
    }
}
