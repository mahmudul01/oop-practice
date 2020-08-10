using System.Collections.Generic;
using System;

namespace MessagingSystem
{
    public class Person
    {
        public string Name { get; set; }
        public int InboxCount { get; private set; }
        public int SentItemCount { get; private set; }

        private List<Message> inbox;
        private List<Message> sentItems;

        public Person(string name)
        {
            Name = name;
            inbox = new List<Message>();
            sentItems = new List<Message>();
        }

        public List<Message> GetInbox()
        {
            return inbox;
        }

        public void SetInbox(string message, string sentBy)
        {
            var messageObj = new Message { Body = message, DeliveredOn = DateTime.Now, Receipient=sentBy };
            //var messageObj = new Message();
            //messageObj.Body = message;
            //messageObj.DeliveredOn = DateTime.Now;
            //messageObj.SentBy = sentBy;

            inbox.Add(messageObj);
            InboxCount++;
        }

        public List<Message> GetSentItems()
        {
            return sentItems;
        }

        public void SetSentItems(string message, string sentTo)
        {
            var messageObj = new Message { Body = message, DeliveredOn = DateTime.Now, Receipient = sentTo };
            //var messageObj = new Message();
            //messageObj.Body = message;
            //messageObj.DeliveredOn = DateTime.Now;
            //messageObj.Receipient = sentTo;

            sentItems.Add(messageObj);
            SentItemCount++;
        }

    }

    //public class Person
    //{
    //    public string Name;
    //    public int InboxCount { get; private set; }
    //    public int SentItemCount { get; private set; }

    //    private List<string> inbox;
    //    private List<string> sentItems;
    //    public Person(string name)
    //    {
    //        Name = name;
    //        inbox = new List<string>();
    //        sentItems = new List<string>();
    //    }

    //    public List<string> GetInbox()
    //    {
    //        return inbox;
    //    }

    //    public void SetInbox(string message)
    //    {
    //        inbox.Add(message);
    //        InboxCount++;
    //    }

    //    public List<string> GetSentItems()
    //    {
    //        return sentItems;
    //    }

    //    public void SetSentItems(string message)
    //    {
    //        sentItems.Add(message);
    //        SentItemCount++;
    //    }

    //}

    //public class Person
    //{
    //    public string Name;
    //    public int inboxCount = 0;
    //    public int sentItemCount = 0;

    //    public List<string> Inbox { get; set; }
    //    public List<string> SentItems { get; set; }
    //    public Person(string name)
    //    {
    //        Name = name;
    //        Inbox = new List<string>();
    //        SentItems = new List<string>();
    //    }
    //    public int GetInboxCount()
    //    {
    //        return inboxCount;
    //    }
    //    public int SentItemsCount()
    //    {
    //        return sentItemCount;
    //    }
    //}
}
