

using System.Collections;
using System.Diagnostics.CodeAnalysis;


var phoneBook = new List<Contact>();
     
// добавляем контакты
phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
phoneBook.Add(new Contact("Сергей", "Довлатов",79990000010, "serge@example.com"));
phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
phoneBook.Add(new Contact("Валерий", "Леонтьев",79990000012, "valera@example.com"));
phoneBook.Add(new Contact("Сергей", "Брин",  799900000013, "serg@example.com"));
phoneBook.Add(new Contact("Иннокентий", "Смоктуновский",799900000013, "innokentii@example.com"));


var contacts = phoneBook.OrderBy(x => x.Name).ThenBy(x => x.LastName).ToList();
while (true)
{
    var ch = Convert.ToInt32(Console.ReadLine());
    int skipIndex = (ch - 1) * 2;
    var currentContacts = contacts.Skip(skipIndex).Take(2).ToList();


    for (int i = 0; i < currentContacts.Count(); i++)
    {
        Console.WriteLine(currentContacts[i].Name + " " + currentContacts[i].LastName);
    }

}

public class Contact // модель класса
{
    public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }
  
    public String Name {get;}
    public String LastName {get;}
    public long PhoneNumber {get;}
    public String Email {get;}
}