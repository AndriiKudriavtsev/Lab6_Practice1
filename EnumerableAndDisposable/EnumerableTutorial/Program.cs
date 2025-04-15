using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

//var bond = new PersonName("James", "Bond");

//foreach (var name in bond)
//{
//    Console.WriteLine(name);
//}

//var rock = new PersonName("Dwayne", "Johnson", "Rock");
//Console.WriteLine(rock.Skip(1).First());

var rock = new PersonName("Dwayne", "Johnson", "Rock");
Console.WriteLine(rock.Skip(1).First());

public class PersonName : IEnumerable<string>
{
    public string FirstName { get; }
    public string MiddleName { get; }
    public string LastName { get; }

    public PersonName(string firstName, string lastName, string middleName = null)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<string> GetEnumerator()
    {
        yield return FirstName;
        if (MiddleName != null)
            yield return MiddleName;

        yield return LastName;
    }
}