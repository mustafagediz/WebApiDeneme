using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IClientService
{
    CreatedClientResponse Add(CreateClientRequest createdClientRequest);

    List<GetAllClientResponse> GetAll();
}