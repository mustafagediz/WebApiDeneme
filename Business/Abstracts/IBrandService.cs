using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IBrandService

{                                           //istekde bulunduğu data
    CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);
    List<GetAllBrandResponse> GetAll();
}

//veri tabanı nesnelerimizi api ye ya da son kullanıcıya taşımıyoruz. Engin Hoca 3. ders 44:32 dakika

//responses(yanıtlar)  and requests(istekler)
//sektördeki yoğun hatalardan bir tanesi aynı dto yu herşey için kullanmak