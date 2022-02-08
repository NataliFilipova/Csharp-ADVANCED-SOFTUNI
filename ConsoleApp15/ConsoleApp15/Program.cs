using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<string>chat = new List<string>();

            string[] cmd = Console.ReadLine().Split(" ");

            while (cmd[0] != "end")
            {
                if (cmd[0] == "Chat")
                {
                    chat.Add(cmd[1]);
                }
                else if (cmd[0] == "Delete")
                {
                    chat.Remove(cmd[1]);

                }
                else if (cmd[0] == "Edit")
                {
                    int i = chat.IndexOf(cmd[1]);
                    chat.Remove(cmd[1]);
                    chat.Insert(i, cmd[2]);
                }
                else if (cmd[0] == "Pin")
                {
                    if (chat.Contains(cmd[1]))
                    {
                        chat.Remove(cmd[1]);
                        chat.Add(cmd[1]);
                    }
                }
                else if (cmd[0] == "Spam")
                {
                    for(int i = 1; i < cmd.Length;i++)
                    {
                        chat.Add(cmd[i]);
                    }
                }

                cmd = Console.ReadLine().Split(" ");
            }

            //while end

            for(int i = 0; i < chat.Count; i++)
            {
                Console.WriteLine(chat[i]);
            }
        }

    }
}