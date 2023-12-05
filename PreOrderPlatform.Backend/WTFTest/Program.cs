using System.Collections;
using System.Collections.Generic;
using System.Linq;

void test()
{
    IEnumerable<string> testIE = ["a", "b", "c"];
    IEnumerable<User> testUser = new List<User>()
    {
        new()
        {
            Name = "Test4",
            Age = 3,
        },
        new()
        {
            Name = "Test2",
            Age = 2,
        },
        new()
        {
            Name = "Test2",
            Age = 4,
        },
        new()
        {
            Name = "Test2",
            Age = 1,
        }
    };
    Console.WriteLine(testIE.Take(2).Skip(2));
    var a = testUser.OrderBy(u => u.Name).ThenBy(u => u.Age);
    var s = a.Skip(1).Take(2);
    foreach (User u in s)
    {
        Console.WriteLine(u.Name + u.Age);
    }
}

//test();

for (int a = 0; a<10; ++a) Console.Write(a);
for(int a = 0; ++a<10;) Console.Write(a);
for(int a = 0; a++<10;) Console.Write(a);
public class User
{
    public required string Name { get; set; }
    public int Age { get; set; }
}
