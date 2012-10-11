using System;
using Microsoft.SqlServer.Management.Smo;

namespace TestProject.Network
{
    public class DatabaseInfo
    {
        public DatabaseInfo(Database db)
        {
            Id = db.ID;
            Name = db.Name;
            Size = Math.Round(db.Size);
            LastBackupDate = db.LastBackupDate;
            LastLogBackupDate = db.LastLogBackupDate;
            DefaultSchema = db.DefaultSchema;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }
        public DateTime LastBackupDate { get; set; }
        public DateTime LastLogBackupDate { get; set; }
        public string DefaultSchema { get; set; }
        public string InstanceName { get; set; }
    }
}