using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IClientDal
{
    void Add(Client client);

    List<Client> GetAll();
}