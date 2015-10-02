namespace nancytest.Objects
{
  using System;
  using System.Collections.Generic;
  public class Task
  {
    public string Description {get; set;}

    public static List<string> ListOfTasks = new List<string> {};

    public static void Save(string NewTask)
    {
      ListOfTasks.Add(NewTask);
    }

    public static void ClearAll()
    {
      ListOfTasks.Clear();
    }
  }
}
