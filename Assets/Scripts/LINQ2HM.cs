using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LINQ2HM : MonoBehaviour
{
    private int[] values = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    private int[] newValues = new[] { 2, 4, 6, 8, 10};
    private string[] words = new[] { "apple", "banana", "cherry", "date", "elderberry" };
    private void Start()
    {
        var OddNumbers = values.Where(value => value % 2 != 0);
        foreach (var number in OddNumbers) Debug.Log(number);

        var FirstA = words.Where(word => word.Substring(0,1) == "a");
        foreach (var word in FirstA) Debug.Log(word);

        var DivideBy3 = values.Where(value => value % 3 == 0);
        foreach (var number in DivideBy3) Debug.Log(number);

        var LessThen6 = words.Where(word => word.Length < 6);
        foreach (var word in LessThen6) Debug.Log(word);
        
        var people = new List<Person>
        {
            new Person ("Tom", 23, new List<string> {"english", "german"}),
            new Person ("Bob", 27, new List<string> {"english", "french" }),
            new Person ("Sam", 29, new List<string>  { "english", "spanish" }),
            new Person ("Alice", 24, new List<string> {"spanish", "german" })
        };

        var OlderThan25 = from person in people
            where person.Age > 26
            select person;
        
        foreach (var word in OlderThan25) Debug.Log(word.Name);

        var FirstASecond = words.Where(word => word.Substring(0,1) == "a");
        foreach (var word in FirstASecond) Debug.Log(word);
        
        var DivideBy3Or2 = values.Where(value => value % 3 == 0 || value % 2 == 0);
        foreach (var number in DivideBy3Or2) Debug.Log(number);

        var OlderThan25AllLanguages = from person in people
            from lang in person.Languages
            where person.Age > 26
            select lang;
        
        foreach (var word in OlderThan25AllLanguages) 
            Debug.Log(word);

    }
}
