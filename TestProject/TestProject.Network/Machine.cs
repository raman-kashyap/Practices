using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace TestProject.Network
{
    public class Machine
    {
        private readonly ServerInfo _serverInfo;
        public Machine(ServerInfo serverInfo)
        {
            _serverInfo = serverInfo;
        }

        public string GetConnectionString()
        {
            var connection = _serverInfo.Credential != null
                                 ? new ServerConnection(new SqlConnectionInfo(_serverInfo.Name,
                                                                              _serverInfo.Credential.Username,
                                                                              _serverInfo.Credential.Password))
                                 : new ServerConnection(new SqlConnectionInfo(_serverInfo.Name));

            return connection.ConnectionString;
        }

        public IEnumerable<DatabaseInfo> GetDatabases()
        {
            var connection = _serverInfo.Credential != null
                                 ? new ServerConnection(new SqlConnectionInfo(_serverInfo.Name, _serverInfo.Credential.Username,
                                                                              _serverInfo.Credential.Password))
                                 : new ServerConnection(new SqlConnectionInfo(_serverInfo.Name));

            var server = new Server(connection);

            if (server == null)
                throw new Exception(string.Format("Not able to locate machine '{0}'.", _serverInfo.Name));

            return server.Databases.Cast<Database>().Where(db => db.IsAccessible && !db.IsSystemObject).Select(db => new DatabaseInfo(db)
                                                                                                   {
                                                                                                       InstanceName = server.InstanceName
                                                                                                   });
        }
    }
}
