using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using adressNamespace;

namespace studentNamespace
{
  public class Student
  {
    private string name;
    private string surname;
    private string patronim;
    private DateTime birth;
    private Adress adress;
    private string phoneNumber;
    private List<int> tests;
    private List<int> homeTasks;
    private List<int> exams;
    public Student() : this("Ivan", "Ivanov", "Ivanovich", 2000, 5, 7, "Pushkina", 28, "Odessa", 2141, "+380-800-735-35-35", new List<int>(), new List<int>(), new List<int>())
    {
      Console.WriteLine("Default c-tor");
    }
    public Student(string name, string surname, string patronim, int year, int month, int day, string street, int streetN, string city, int postalCode, string number) : this(name, surname, patronim, year, month, day, street, streetN, city, postalCode, number, new List<int>(),new List<int>(),new List<int>())
    {
      Console.WriteLine("Param c-tor");
    }
    public Student(string name, string surname, string patronim, int year, int month, int day, string street, int streetN, string city, int postalCode, string number, List<int> tests, List<int> homeTasks, List<int> exams)
    {
      setName(name);
      setSurname(surname);
      setPatronim(patronim);
      setBirth(year, month, day);
      setAdress(street, streetN, city, postalCode);
      setNumber(number);
      setTests(tests);
      setHomeTasks(homeTasks);
      setExams(exams);
      Console.WriteLine("Main c-tor");
    }
    public string getName()
    {
      return name;
    }
    public string getSurname()
    {
      return surname;
    }
    public string getPatronim()
    {
      return patronim;
    }
    public DateTime getBirth()
    {
      return birth;
    }
    public Adress getAdress()
    {
      return adress;
    }
    public string getPhone()
    {
      return phoneNumber;
    }
    public List<int> getTests()
    {
      return tests;
    }
    public List<int> getHometasks()
    {
      return homeTasks;
    }
    public List<int> getExams()
    {
      return exams;
    }
    public void setName(string name)
    {
      if(name.Length>0)
      {
        this.name = name;
      }
      else
      {
        surname = "None";
      }
    }
    public void setSurname(string surname)
    {
      if(surname.Length>0)
      {
        this.surname = surname;
      }
      else
      {
        this.surname = "None";
      }
    }
    public void setPatronim(string patronim)
    {
      if(patronim.Length>0)
      {
        this.patronim = patronim;
      }
      else
      {
        this.patronim = "None";
      }
    }
    public void setBirth(int year, int month, int day)
    {
      if((year>0)&&(month>0)&&(month<13)&&(day>0)&&(day<32))
      {
        this.birth = new DateTime(year,month,day);
      }
      else
      {
        this.birth = new DateTime(2022,1,1);
      }
    }
    public void setNumber(string phoneNumber)
    {
      if(Regex.IsMatch(phoneNumber, @"((380|\+380)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}"))
      {
        this.phoneNumber = phoneNumber;
      }
      else
      {
        this.phoneNumber = "+380-800-735-35-35";
      }
    }
    public void setAdress(string street, int streetN, string city, int postalCode)
    {
      adress = new Adress(street, streetN, city, postalCode);
    }
    public void setTests(List<int> tests)
    {
      this.tests = tests;
    }
    public void setHomeTasks(List<int> homeTasks)
    {
      this.homeTasks = homeTasks;
    }
    public void setExams(List<int> exams)
    {
      this.exams = exams;
    }
    public override string ToString()
    {
      string testStr="\n", taskStr="", examStr="";
      if(tests != null)
      {
        foreach(var test in tests)
        {
          testStr = test + "\n";
        }
      }
      if(homeTasks != null)
      {
        foreach(var task in homeTasks)
        {
          taskStr = task + "\n";
        }
      }
      if(exams != null)
      {
        foreach(var exam in exams)
        {
          examStr = exam + "\n";
        }
      }
      return getName() + "\n" + getSurname() + "\n" + getPatronim() + "\n" + getBirth() + "\n" + getAdress() + "\n" + getPhone() + testStr + taskStr + examStr;
    }
  }
}