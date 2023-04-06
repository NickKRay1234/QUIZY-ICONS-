using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LINQ : MonoBehaviour
{
    private class Person
    {
        public string Name;
        public int Age;

        public Person(string Name, int Age)
        {
            this.Age = Age;
            this.Name = Name;
        }
    }

    private void Awake()
    {
        IEnumerable<Person> people = new List<Person>
        {
            new("Tom", 23),
            new("Bob", 27)
        };

        var personel = 
            from p in people 
            select new
            {
                FirstName = p.Name,
                Year = DateTime.Now.Year - p.Age
            };

        // foreach (var p in personel)
        //     Debug.Log($"{p.FirstName} - {p.Year}");
    }

    private void Start()
    {
        var people = new List<Person>()
        {
            new("Tom", 23),
            new("Bob", 27),
            new("Sam", 29),
            new("Alice", 24)
        };

        var newPersonal = from p in people
            let name = $"Mr. {p.Name}"
            let year = DateTime.Now.Year - p.Age
            select new
            {
                Name = name,
                Year = year
            };

        var oldPersonal = from fired in people
            let name = $"Mr. {fired.Name} is fired"
            let year = DateTime.Now.Year - fired.Age
            select new
            {
                Name = name,
                Year = year
            };

        foreach (var personal in oldPersonal)
            Debug.Log($"{personal.Name} - {personal.Year}");

        var names = from p in people select p.Name;
        var ages = from p in people select p.Age;

        // foreach (string n in names)
        //     Debug.Log(n);
        //
        // foreach (int age in ages)
        //     Debug.Log(age);
    }
}
