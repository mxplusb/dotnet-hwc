using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Helpers {
    internal static class ParsingHelpers {

        public static Stream ToStream(this string @this) {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(@this);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        /// <summary>
        /// Parser for the Application Pool configs.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <returns></returns>
        private static T ParseXML<T>(this string @this) where T : class {
            var reader = XmlReader.Create(@this.Trim().ToStream(), new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document });
            return new XmlSerializer(typeof(T)).Deserialize(reader) as T;
        }
    }
}
