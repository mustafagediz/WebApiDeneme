using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Concretes;

public class ClientDal:IClientDal
{
    private readonly List<Client> _clients;

    public ClientDal()
    {
        _clients=new List<Client>();

        _clients.Add(new Client{IdentityNumber = 25458598741, FirstName = "Elif",LastName = "Şafak",DateBirth = 1987});
        _clients.Add(new Client { IdentityNumber = 20241589658, FirstName = "Ahmet", LastName = "Ümit", DateBirth = 1982 });
        _clients.Add(new Client { IdentityNumber = 12345678901, FirstName = "Mehmet", LastName = "Can", DateBirth = 1995 });
        _clients.Add(new Client { IdentityNumber = 98765432109, FirstName = "Ayşe", LastName = "Yılmaz", DateBirth = 2000 });
    }

    public void Add(Client client)
    {
        _clients.Add(client);
    }

    public List<Client> GetAll()
    {
        return _clients;
    }
}