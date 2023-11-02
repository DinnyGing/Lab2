using Lab2.Db;
using Lab2.DTO;
using Lab2.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Lab2.Repositories
{
    public class ClientRepository
    {
        public List<Client> GetAll()
        {
            List<Client> clients;
            using (ApplicationContext db = new ApplicationContext())
            {
                clients = db.Clients.ToList();
            }
            return clients;
        }
        public List<ClientDTO> GetAllWithOutAppointment()
        {
            List<ClientDTO> clients;
            using (ApplicationContext db = new ApplicationContext())
            {
                var query = from client in db.Clients
                            select new ClientDTO()
                            {
                                ClientId = client.ClientId,
                                FirstName = client.FirstName,
                                LastName = client.LastName,
                                Gender = client.Gender,
                                Age = client.Age,
                                Phone = client.Phone,
                                Email = client.Email
                            };
                clients = query.ToList();
            }
            return clients;
        }
        public Client GetById(int id)
        {
            Client client;
            using (ApplicationContext db = new ApplicationContext())
            {
                client = db.Clients.FirstOrDefault(p => p.ClientId == id);
            }
            return client;
        }
        public void Create(Client client)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (client != null)
                {
                    db.Clients.Add(client);
                    db.SaveChanges();
                }
            }
        }
        public void Update(Client client)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (client != null)
                {
                    db.Clients.Update(client);
                    db.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var client = db.Clients.Find(id);
                if (client != null)
                {
                    db.Clients.Remove(client);
                    db.SaveChanges();
                }
            }
        }
    }
}
