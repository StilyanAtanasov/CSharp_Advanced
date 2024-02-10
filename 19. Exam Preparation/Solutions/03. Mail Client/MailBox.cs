using System.Text;

namespace MailClient;

public class MailBox
{
    public MailBox(int capacity)
    {
        Capacity = capacity;
        Inbox = new();
        Archive = new();
    }

    public int Capacity { get; set; }
    public List<Mail> Inbox { get; set; }
    public List<Mail> Archive { get; set; }


    /// <summary>Adds an entry to the Inbox collection, if the Capacity allows it.</summary>
    /// <param name="mail"></param>
    public void IncomingMail(Mail mail)
    {
        if (Inbox.Count < Capacity) Inbox.Add(mail);
    }

    /// <summary>Finds and removes the first mail from the Inbox by a given sender, if such exists, returning boolean</summary>
    /// <param name="sender"></param>
    public bool DeleteMail(string sender)
    {
        Mail? unwantedMail = Inbox.FirstOrDefault(m => m.Sender == sender);
        if (unwantedMail != null)
        {
            Inbox.Remove(unwantedMail);
            return true;
        }

        return false;
    }

    /// <summary>Moves all inbox mails to the Archive. Returns the number of mails moved.</summary>
    public int ArchiveInboxMessages()
    {
        Archive.AddRange(Inbox);
        int elementsAdded = Inbox.Count;

        //reset inbox
        Inbox = new();

        return elementsAdded;
    }

    /// <summary>Returns the Mail with the longest Body.</summary>
    public string GetLongestMessage() => Inbox.OrderByDescending(m => m.Body).First().ToString();


    /// <summary>Returns a string in the following format: "Inbox: \n {Mail1} \n {Mail2} \n {…} \n {Mailn}"</summary>
    public string InboxView()
    {
        StringBuilder sb = new();
        sb.AppendLine("Inbox:");
        foreach (Mail mail in Inbox) sb.AppendLine(mail.ToString());

        return sb.ToString().TrimEnd();
    }
}