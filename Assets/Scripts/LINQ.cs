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

    private void Start()
    {
        var people = new List<Person>()
        {
            new Person("Tom", 23),
            new Person("Bob", 27),
            new Person("Sam", 29),
            new Person("Alice", 24)
        };

        var names = from p in people select p.Name;
        var ages = from p in people select p.Age;

        foreach (string n in names)
            Debug.Log(n);

        foreach (int age in ages)
            Debug.Log(age);
    }
}
