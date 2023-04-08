using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LINQ2 : MonoBehaviour
{
    private string[] _people = { "Tom", "Alice", "Bob", "Sam", "Tim", "Tomas", "Bill" };
    private int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
    
    List<Person> people = new List<Person>
    {
        new Person ("Tom", 23, new List<string> {"english", "german"}),
        new Person ("Bob", 27, new List<string> {"english", "french" }),
        new Person ("Sam", 29, new List<string>  { "english", "spanish" }),
        new Person ("Alice", 24, new List<string> {"spanish", "german" })
    };
    private void Start()
    {
        var selectedPeople = _people.Where(p => p.Length == 3);
        foreach (var person in selectedPeople) 
            Debug.Log(person);

        var selectedPeopleLINQ = from p in _people
            where p.Length == 3
            select p;
        
        foreach (var person in selectedPeopleLINQ) 
            Debug.Log(person);

        var evens1 = numbers.Where(i => i % 2 == 0 && i > 10);
        var evens2 = from i in numbers
            where i % 2 == 0 && i > 10
            select i;

        foreach (var value in evens2) print(value);

        var selectedPeople2 = from person in people
            where person.Age > 25
            select person;
        
        foreach (var value in selectedPeople2) print($"{value.Name} -- {value.Age}");
        
    }
}

internal class Person
{
    public string Name;
    public int Age;
    public List<string> Languages;

    public Person(string name,int age,List<string> languages)
    {
        Name = name;
        Age = age;
        Languages = languages;
    }
}
