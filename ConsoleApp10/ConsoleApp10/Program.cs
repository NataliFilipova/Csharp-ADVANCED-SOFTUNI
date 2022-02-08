using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                var commands = Console.ReadLine().Split(':').ToArray();
                var firstCmd = commands[0];
                if(firstCmd == "Add")
                {
                    if (!lessons.Contains(commands[1]))
                    {
                        lessons.Add(commands[1]);
                    }
                }
                else if(firstCmd == "Insert")
                {
                    if (!lessons.Contains(commands[1]))
                    {
                        int givineIndexFromCmd = int.Parse(commands[2]);
                        if (givineIndexFromCmd < lessons.Count && givineIndexFromCmd >= 0)
                        {
                            lessons.Insert(givineIndexFromCmd, commands[1]);
                        }
                    }
                }
                else if (firstCmd == "Remove")
                {
                    lessons.Remove(commands[1]);
                    lessons.Remove($"{commands[1]} - Exercise");
                }
                else if(firstCmd == "Swap")
                {
                    string lessonOneTitle = commands[1];
                    string lessonTwoTitle = commands[2];
                    int indexOfLessonsOne = lessons.IndexOf(lessonOneTitle);
                    int indextOflessonTwo = lessons.IndexOf(lessonTwoTitle);
                    if(indexOfLessonsOne != -1 && indextOflessonTwo != -1)
                    {
                        lessons[indexOfLessonsOne] = lessonTwoTitle;
                        lessons[indextOflessonTwo] = lessonOneTitle;
                        if (indexOfLessonsOne + 1 < lessons.Count && lessons[indexOfLessonsOne + 1] == $"{lessonOneTitle} -Exercise")
                        {
                            lessons.RemoveAt(indexOfLessonsOne + 1);
                            indexOfLessonsOne = lessons.IndexOf(lessonOneTitle);
                            lessons.Insert(indexOfLessonsOne + 1, $"{lessonOneTitle}-Exercise");
                        }
                        if (indextOflessonTwo   + 1 < lessons.Count && lessons[indextOflessonTwo + 1] == $"{lessonTwoTitle} -Exercise")
                        {
                            lessons.RemoveAt(indextOflessonTwo + 1);
                            indextOflessonTwo = lessons.IndexOf(lessonTwoTitle);
                            lessons.Insert(indexOfLessonsOne + 1, $"{lessonOneTitle}-Exercise");
                        }
                    }
                   

                }
            }
        }
    }
}
