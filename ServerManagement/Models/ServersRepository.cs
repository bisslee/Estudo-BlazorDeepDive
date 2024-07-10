using ServerManagement.Components.Pages;

namespace ServerManagement.Models
{
    public static  class ServersRepository
    {
        private  static List<Server> servers = new List<Server>()
        {
            new Server(){Id = 1, Name = "Karnak Server",City = "São Paulo"},
            new Server(){Id = 2,Name = "Vulcano Server",City = "Osasco"},
            new Server(){Id = 3, Name = "Apolo Server",City = "Guarulhos"},
            new Server(){Id = 4, Name = "Zeus Server",City = "Rio de Janeiro"},
            new Server(){Id = 5, Name = "Hermes Server",City = "São Bernardo"},
            new Server(){Id = 6, Name = "Ares Server",City = "São Paulo"},
            new Server(){Id = 7, Name = "Hades Server",City = "Rio de Janeiro"},
            new Server(){Id = 8, Name = "Poseidon Server",City = "BH"},
            new Server(){Id = 9, Name = "Hera Server",City = "Porto Alegre"},
            new Server(){Id = 10, Name = "Demeter Server",City = "Curitiba"},
            new Server(){Id = 11, Name = "Afrodite Server",City = "BH"},
            new Server(){Id = 12, Name = "Hefesto Server",City = "Manaus"},
            new Server(){Id = 13, Name = "Artemis Server",City = "Recife"},
            new Server(){Id = 14, Name = "Atena Server",City = "Fortaleza"},
            new Server(){Id = 15, Name = "Hestia Server",City = "Salvador"},
        };

        public static void AddServer(Server server)
        {
            var maxId = servers.Max(s => s.Id);
            server.Id = maxId + 1;
            servers.Add(server);
        }
        public static List<Server> GetServers() => servers;

        public static List<Server> GetServersByCity(string cityName)
        {
            return servers.Where(s => s.City.Equals(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static Server? GetServerById(int id)
        {
            var server = servers.FirstOrDefault(s => s.Id == id);
            if (server != null)
            {
                return new Server
                {
                    Id = server.Id,
                    Name = server.Name,
                    City = server.City,
                    IsOnline = server.IsOnline
                };
            }

            return null;
        }

        public static void UpdateServer(int serverId, Server server)
        {
            if (serverId != server.Id) return;

            var serverToUpdate = servers.FirstOrDefault(s => s.Id == serverId);
            if (serverToUpdate != null)
            {
                serverToUpdate.IsOnline = server.IsOnline;
                serverToUpdate.Name = server.Name;
                serverToUpdate.City = server.City;
            }
        }

        public static void DeleteServer(int serverId)
        {
            var server = servers.FirstOrDefault(s => s.Id == serverId);
            if (server != null)
            {
                servers.Remove(server);
            }
        }

        public static List<Server> SearchServers(string serverFilter)
        {
            return servers.Where(s => s.Name.Contains(serverFilter, StringComparison.OrdinalIgnoreCase)).ToList();
        }

    }
}
