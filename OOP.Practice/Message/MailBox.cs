namespace MessagingSystem

{
    public class MailBox
    {
        public void Send(Person personFrom, Person personTo, string message)
        {
            personFrom.SetSentItems(message, personTo.Name);
            personTo.SetInbox(message, personFrom.Name);
        }

    }

    //public class MailBox 
    //{
    //    public void Send(Person personFrom, Person personTo, string message)
    //    {
    //        personFrom.SentItems.Add(message);
    //        personFrom.sentItemCount++;
    //        personTo.Inbox.Add(message);
    //        personTo.inboxCount++;
    //    }

    //}
}
