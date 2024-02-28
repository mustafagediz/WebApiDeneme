using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class ClientManager:IClientService
{
    private readonly IClientDal _clientDal;
    public ClientManager(IClientDal clientDal)
    {
        _clientDal = clientDal;
    }


    public CreatedClientResponse Add(CreateClientRequest createdClientRequest)
    {
        Client client = new();
        client.FirstName=createdClientRequest.FirstName;
        client.LastName=createdClientRequest.LastName;

        _clientDal.Add(client);

        CreatedClientResponse createdClientResponse = new CreatedClientResponse();
        createdClientResponse.FirstName= client.FirstName;
        createdClientResponse.LastName= client.LastName;
        createdClientResponse.MembershipDate = client.MembershipDate;

        return createdClientResponse;
    }

    public List<GetAllClientResponse> GetAll()
    {
        List<Client> clients = _clientDal.GetAll();
        List<GetAllClientResponse> getAllClientResponses = new List<GetAllClientResponse>();
        foreach (var client in clients)
        {
            GetAllClientResponse getAllClientResponse= new GetAllClientResponse();
            getAllClientResponse.FirstName= client.FirstName;
            getAllClientResponse.LastName= client.LastName;
            getAllClientResponse.MembershipDate = client.MembershipDate;

            getAllClientResponses.Add(getAllClientResponse);

        }

        return getAllClientResponses;
    }
}