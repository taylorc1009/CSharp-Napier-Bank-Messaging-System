
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class SignificantIncidentReport : Email
    {
        public SignificantIncidentReport() { }

        public DateTime date { get; set; }

        public String sortCode { get; set; }

        public String nature { get; set; }

        public SignificantIncidentReport(String sender, DateTime date, String sortCode, String nature, String text, DateTime sentAt)
        {
            this.sender = sender;
            this.date = date;
            this.sortCode = sortCode;
            this.nature = nature;
            this.sentAt = sentAt;

            String s = "SIR " + this.date.ToString("dd/MM/yy");
            this.subject = s;

            String t = "Sort Code: " + this.sortCode + Environment.NewLine
                    + "Nature of Incident: " + this.nature + Environment.NewLine + Environment.NewLine
                    + text;
            this.text = t;

            this.decorate(4);
        }
    }
}