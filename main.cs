using System;
using System.Collections.Generic;
using studentNamespace;

class Program {
  public static void Main (string[] args) {
    Student ivan = new Student();
    Student semen = new Student("Semen", "Semenovich", "Semenov", 2002, 5, 4, "Gogola", 11, "Kyiv", 2324, "+380-242-24-42");
    List<int> m1 = new List<int>(){2,42,3,2,2};
    List<int> m2 = new List<int>(){4,4652,2,5,1,7,8,5};
    List<int> m3 = new List<int>(){5,1,7,8,5};
    Student nikita = new Student("Nikita", "Nikitiev", "Nikitievich", 1999, 7, 21, "Cvetochnaya", 22, "Vinitsa", 2323, "+380-131-13-65", m1, m2, m3);
    Console.WriteLine($"Ivan:\n{ivan}Semen:\n{semen}Nikita:\n{nikita}");
  }
}