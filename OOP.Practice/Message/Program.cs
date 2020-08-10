using System;
using System.Collections.Generic;

namespace MessagingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var msg = new MailBox();

            Person p1 = new Person("Shohag");
            Person p2 = new Person("Safwan");
            Person p3 = new Person("xyz");

            msg.Send(p1, p2, "hello messaage");
            msg.Send(p2, p1, "reply back");
            msg.Send(p3, p2, "another message");

            PrintMessage(p1);
            PrintMessage(p2);
        }

        private static void PrintMessage( Person p)
        {
            Console.WriteLine($"{p.Name}: Inbox ({p.InboxCount})");

            foreach (var item in p.GetInbox())
            {
                Console.WriteLine($"Sent by: {item.Receipient} on {item.DeliveredOn} | {item.Body}");
            }
            Console.WriteLine();
           
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var person = new Person("Shohag");
    //        var msg = new MailBox();

    //        Person p1 = new Person("Shohag");
    //        Person p2 = new Person("Safwan");
    //        Person p3 = new Person("xyz");

    //        msg.Send(p1, p2, "hello messaage");
    //        msg.Send(p2, p1, "reply back");
    //        msg.Send(p3, p2, "another message");

    //        var p1InboxCount = p1.GetInboxCount();
    //        var p2InboxCount = p2.GetInboxCount();

    //        Console.WriteLine($"{p1.Name}: Inbox ({p1InboxCount})");

    //        foreach (var item in p1.Inbox)
    //        {
    //            Console.WriteLine(item);
    //        }
    //        Console.WriteLine();
    //        Console.WriteLine($"{p2.Name}: Inbox ({p2InboxCount})");

    //        foreach (var item in p2.Inbox)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
}
