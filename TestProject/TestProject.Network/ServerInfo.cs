namespace TestProject.Network
{
    public class ServerInfo
    {
        public string Name { get; set; }
        public Credential Credential { get; set; }
    }

    public class Credential
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}