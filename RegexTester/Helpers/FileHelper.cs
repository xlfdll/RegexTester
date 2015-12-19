using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Xml;

using RegexTester.Data;

namespace RegexTester.Helpers
{
    public static class FileHelper
    {
        public static RegexInput LoadRegexInput(String path)
        {
            RegexInput input = new RegexInput();

            using (XmlReader reader = XmlReader.Create(path))
            {
                reader.ReadToFollowing("Input");

                reader.Read(); // First child node for input data

                input.RegexPattern = reader.ReadElementContentAsString();
                input.ReplacePattern = reader.ReadElementContentAsString();
                input.Text = reader.ReadElementContentAsString();
                input.Options = (RegexOptions)Enum.Parse(typeof(RegexOptions), reader.ReadElementContentAsString());
            }

            return input;
        }

        public static void SaveRegexInput(String path, RegexInput input)
        {
            using (XmlWriter writer = XmlWriter.Create(path))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement(Path.GetFileNameWithoutExtension(Application.ResourceAssembly.Location), FileHelper.Namespace);

                writer.WriteStartElement("Input");

                writer.WriteElementString("RegexPattern", input.RegexPattern);
                writer.WriteElementString("ReplacePattern", input.ReplacePattern);
                writer.WriteElementString("Text", input.Text);
                writer.WriteElementString("Options", input.Options.ToString());

                writer.WriteEndElement(); // </Input>

                writer.WriteEndElement(); // </RegexTester>
                writer.WriteEndDocument();
            }
        }

        public static readonly String Namespace = "http://www.xlfdll.org/xmlns/RegexTester";
    }
}