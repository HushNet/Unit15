

using System.Collections;
using System.Diagnostics.CodeAnalysis;




var classes = new []
{
    new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
    new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
    new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
};
var allStudents = GetAllStudents(classes);
         
Console.WriteLine(string.Join(" ", allStudents));

 
static string [] GetAllStudents( Classroom [] classes )
{
    var result = classes.SelectMany(x => x.Students).ToArray();
    return result;
}
      
public class Classroom
{
    public List<string> Students = new List<string>();
}