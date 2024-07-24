using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace fourth_week
{

    public static class Management
    {
        public static string GetDayOfWeek(int day)
        {
            switch (day)
            {
                case 1:
                    return "באחד בשבת";
                case 2:
                    return "בשני בשבת";
                case 3:
                    return "בשלישי בשבת";
                case 4:
                    return "ברביעי בשבת";
                case 5:
                    return "בחמישי בשבת";
                case 6:
                    return "בששי בשבת";
                default:
                    return null; // מצב ברירת מחדל
            }

        }


        public static string GetDayOfMonth(int day)
        {
            switch (day)
            {
                case 1:
                    return "יום אחד";
                case 2:
                    return "שני ימים";
                case 3:
                    return "שלשה ימים";
                case 4:
                    return "ארבעה ימים";
                case 5:
                    return "חמשה ימים";
                case 6:
                    return "ששה ימים";
                case 7:
                    return "שבעה ימים";
                case 8:
                    return "שמנה ימים";
                case 9:
                    return "תשעה ימים";
                case 10:
                    return "עשרה ימים";
                case 11:
                    return "אחד עשר יום";
                case 12:
                    return "שנים עשר יום";
                case 13:
                    return "שלשה עשר יום";
                case 14:
                    return "ארבעה עשר יום";
                case 15:
                    return "חמשה עשר יום";
                case 16:
                    return "ששה עשר יום";
                case 17:
                    return "שבעה עשר יום";
                case 18:
                    return "שמונה עשר יום";
                case 19:
                    return "תשעה עשר יום";
                case 20:
                    return "עשרים יום";
                case 21:
                    return "אחד ועשרים יום";
                case 22:
                    return "שנים ועשרים יום";
                case 23:
                    return "שלשה ועשרים יום";
                case 24:
                    return "ארבעה ועשרים יום";
                case 25:
                    return "חמשה ועשרים יום";
                case 26:
                    return "ששה ועשרים יום";
                case 27:
                    return "שבעה ועשרים יום";
                case 28:
                    return "שמנה ועשרים יום";
                case 29:
                    return "תשעה ועשרים יום";
                case 30:
                    return "יום שלושים";
                default:
                    return "יום לא חוקי";
            }
        }

        public static string GetMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    return " תשרי";
                case 2:
                    return "מרחשון";
                case 3:
                    return "כסלו";
                case 4:
                    return "טבת";
                case 5:
                    return "שבט";
                case 6:
                    return "אדר הראשון";
                case 7:
                    return "אדר השני";
                case 8:
                    return "ניסן";
                case 9:
                    return "אייר";
                case 10:
                    return "סיון";
                case 11:
                    return "תמוז";
                case 12:
                    return "אב";
                case 13:
                    return "אלול";
                default:
                    return "חודש לא חוקי";

            }
        }
        public static string GetNextMonth(int month)
        {
            return GetMonthName((month % 14) + 1); // מחזיר את החודש הבא לראשי חודשים
        }

        public static string GetYearInWords(int year)
        {
            switch (year)
            {
                case 1:
                    return "חמשת אלפים ושבע מאות ושמונים וארבע";
                case 2:
                    return "חמשת אלפים ושבע מאות ושמונים וחמש";
                case 3:
                    return "חמשת אלפים ושבע מאות ושמונים ושש";
                case 4:
                    return "חמשת אלפים ושבע מאות ושמונים ושבע";
                case 5:
                    return "חמשת אלפים ושבע מאות ושמונים ושמונה";
                case 6:
                    return "חמשת אלפים ושבע מאות ושמונים ותשע";
                case 7:
                    return "חמשת אלפים ושמונה מאות";
                case 8:
                    return "חמשת אלפים ושמונה מאות ואחת";
                case 9:
                    return "חמשת אלפים ושמונה מאות ושתיים";
                case 10:
                    return "חמשת אלפים ושמונה מאות ושלוש";
                default:
                    return "שנה לא חוקית";
            }
        }

        public static void SaveQueryToXml(string dayOfWeek, string dayOfMOnth, string month, string year, string fullDate)
        {
            XDocument doc;
            string filePath = Path.Combine(Environment.CurrentDirectory, "queries.xml");

            try
            {
                doc = XDocument.Load(filePath);
            }
            catch (Exception)
            {
                doc = new XDocument(new XElement("Queries"));
            }

            XElement newQuery = new XElement("Query",
                new XElement("Day", dayOfWeek),
                new XElement("DayOfWeek", dayOfMOnth),
                new XElement("Month", month),
                new XElement("Year", year),
                new XElement("FullDate", fullDate)
            );

            doc.Element("Queries").Add(newQuery);
            doc.Save(filePath);
        }
    }
}