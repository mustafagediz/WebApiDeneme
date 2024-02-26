using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class BrandManager:IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal= brandDal;
    }

    public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
    {
        //ekledikten sonra bizim burada iş kurallarını çalıştırmamız lazım. business rules
        //mapping:, mapping, bir tür veri dönüştürme işlemidir ve genellikle bir sınıfın özelliklerini başka bir sınıfın özelliklerine kopyalama sürecini ifade eder.
        //CreateBrandRequest sınıfından Brand sınıfına olan mapping işlemi

        Brand brand = new();
        brand.Name=createBrandRequest.Name;
        brand.CreatedDate= DateTime.Now;
        //Burada, createBrandRequest nesnesinin özellikleri Brand nesnesine kopyalanıyor.
        //Yani, createBrandRequest nesnesindeki Name özelliği, yeni oluşturulan brand nesnesindeki Name özelliğine kopyalanıyor.
        //Bu işlem, bir tür veri transferini sağlar.



        _brandDal.Add(brand);//burada bizden brand nesnesi istediği için bizde yukarıdaki kodu yazıyoruz
        //nesneyi oluşturduk veri tabanına ekledik. ancak bizim oluşturduğumuz nesneyi son kullanıcıya vermem lazım. ozman aşağıdaki kodu yazıyoruz


        //mapping.Brand sınıfından CreatedBrandResponse sınıfına olan mapping işlemi

        CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
        createdBrandResponse.Name=brand.Name;
        createdBrandResponse.Id = 4;
        createdBrandResponse.CreatedDate=brand.CreatedDate;

        //Burada, brand nesnesinin özellikleri CreatedBrandResponse sınıfındaki özelliklere kopyalanıyor.
        //Yani, brand nesnesindeki Name özelliği, yeni oluşturulan createdBrandResponse nesnesindeki Name özelliğine kopyalanıyor.
        //Aynı şekilde diğer özellikler de kopyalanıyor.

        return createdBrandResponse;

        //özeti genel request'i veri tabanı nesneme çeviriyorum ona ekliyorum. veritabanımdan gelenide response çevirip ona döndürüyorum.
        // bu yapmış olduğumuza da mapping deniyor.


    }

    public List<GetAllBrandResponse> GetAll()
    {
        List<Brand> brands = _brandDal.GetAll();
        List<GetAllBrandResponse> getAllBrandResponses= new List<GetAllBrandResponse>();

        foreach (var brand in brands)
        {
            GetAllBrandResponse getAllbrandResponse = new GetAllBrandResponse();
            getAllbrandResponse.Name=brand.Name;
            getAllbrandResponse.Id = brand.Id;
            getAllbrandResponse.CreatedDate=brand.CreatedDate;

            getAllBrandResponses.Add(getAllbrandResponse);

        }

        return getAllBrandResponses;
    }
}