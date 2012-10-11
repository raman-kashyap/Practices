using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace TestProject.Network
{
    public static class ServerCollection
    {
        private static readonly string FileName = Path.Combine(Environment.CurrentDirectory, "Servers.xml");
        private static readonly XDocument Document;
        static ServerCollection()
        {
            if (!File.Exists(FileName))
                throw new FileNotFoundException(string.Format("File '{0}' not found.", FileName));

            Document = XDocument.Load(FileName);
        }

        public static IEnumerable<ServerInfo> GetAll()
        {
            return Document.Descendants("Server").Select(s => new ServerInfo
                                                                  {
                                                                      Name = s.Value,
                                                                      Credential = (s.Attribute("Username") != null && s.Attribute("Password") != null)
                                                                      ? new Credential
                                                                      {
                                                                          Username = s.Attribute("Username").Value,
                                                                          Password = s.Attribute("Password").Value
                                                                      }
                                                                      : null
                                                                  });
        }

        public static void Add(string item)
        {
            Add(new ServerInfo {Name = item});
        }

        public static void Add(ServerInfo serverInfo)
        {
            var servers = GetAll();

            if (servers.Any(s => s.Name == serverInfo.Name &&
                ((serverInfo.Credential != null)
                    ? (s.Credential != null &&
                        s.Credential.Username == serverInfo.Credential.Username &&
                        s.Credential.Password == serverInfo.Credential.Password)
                    : s.Credential == null)))
                throw new DuplicateNameException(string.Format("Server '{0}' already exists.", serverInfo.Name));

            var rootElement = Document.Element("Servers");
            if (rootElement == null)
                throw new NullReferenceException("Root element 'Servers' does not exist.");

            if (serverInfo.Credential == null)
                rootElement.Add(new XElement("Server", serverInfo.Name));
            else
                rootElement.Add(new XElement("Server", serverInfo.Name, new XAttribute("Username", serverInfo.Credential.Username),
                                             new XAttribute("Password", serverInfo.Credential.Password)));

            Document.Save(FileName);
        }
    }
}
