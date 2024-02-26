using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IBrandDal
{
    void Add(Brand brand); // marka ekleme

    List<Brand> GetAll(); //listeleme

}