// muratONUR murat ONUR karadeniz
// Tuba Logging  Log4netXmlLayout.cs
// 201312214:54 PM
// 201312214:54 PM
using System;
using System.Xml;
using log4net.Core;
using log4net.Layout;
namespace Logging
{
    public class Log4netXmlLayout : XmlLayoutBase
    {
        protected override void FormatXml(XmlWriter writer, LoggingEvent loggingEvent)
        {
            writer.WriteStartElement("LogEntry");

            writer.WriteStartElement("Level");
            writer.WriteString(loggingEvent.Level.DisplayName);
            writer.WriteEndElement();

            writer.WriteStartElement("Message");
            writer.WriteString(loggingEvent.RenderedMessage);
            writer.WriteEndElement();

            writer.WriteStartElement("Details");
            if (loggingEvent.ExceptionObject != null)
                writer.WriteString(loggingEvent.ExceptionObject.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("StackTrace");
            if (loggingEvent.ExceptionObject != null)
                writer.WriteString(string.IsNullOrEmpty(loggingEvent.ExceptionObject.StackTrace) ? string.Empty : loggingEvent.ExceptionObject.StackTrace);
            writer.WriteEndElement();

            writer.WriteStartElement("TimeStamp");
            writer.WriteString(loggingEvent.TimeStamp.ToString("dd/MM/yyyy HH:mm:ss"));
            writer.WriteEndElement();

            writer.WriteEndElement();
        }
    }
}