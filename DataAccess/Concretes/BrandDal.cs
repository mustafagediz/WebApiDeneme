using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class BrandDal : IBrandDal
    {
        // Listesi, sınıfın tüm metotları tarafından erişilebilecek bir özel alan olarak tanımlanır.
        private readonly List<Brand> _brands;

        // Sınıfın kurucu metodu
        public BrandDal()
        {
            // _brands alanına yeni bir List<Brand> örneği atanır.
            _brands = new List<Brand>();

            // Örnek veriler eklenir. Bu kısmın amacı, uygulamanın geliştirme ve test aşamasında
            // bazı örnek verilere sahip olmasını sağlamaktır.
            _brands.Add(new Brand { Id = 1, Name = "NewHolland", CreatedDate = DateTime.Now });
            _brands.Add(new Brand { Id = 2, Name = "Case", CreatedDate = DateTime.Now });
            _brands.Add(new Brand { Id = 3, Name = "Deutz", CreatedDate = DateTime.Now });
        }

        // Brand eklemek için kullanılan metot
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        // Tüm Brand'leri getirmek için kullanılan metot
        public List<Brand> GetAll()
        {
            return _brands;
        }
    }
}
//public class BrandDal : IBrandDal: Bu ifade, BrandDal sınıfının IBrandDal arayüzünden türediğini belirtir.
//Yani, IBrandDal arayüzünü uygulayan bir sınıftır.
// 
// private readonly List<Brand> _brands;: Bu ifade, BrandDal sınıfının özel bir alanı olan _brands adlı bir List<Brand> koleksiyonu tanımlar.
// Bu koleksiyon, Brand sınıfından nesneleri içerecektir. readonly ifadesi, bu alanın sadece kurucu metod içinde başlatılabileceğini belirtir.
// 
// public BrandDal(): Bu ifade, BrandDal sınıfının kurucu metodunu tanımlar.
// Kurucu metot, sınıf bir örneği oluşturulduğunda otomatik olarak çalışan bir metottur.
// 
// _brands = new List<Brand>();: Bu ifade, _brands koleksiyonunu yeni bir List<Brand> örneğiyle başlatır.
// Yani, BrandDal sınıfı oluşturulduğunda, bu koleksiyon boş bir listeyle başlar.
// 
// _brands.Add(new Brand { Id = 1, Name = "NewHolland", CreatedDate = DateTime.Now });: Bu ifade, _brands koleksiyonuna bir örnek Brand nesnesi ekler.
// Bu, uygulamanın geliştirme ve test aşamasında bazı örnek verilere sahip olmayı sağlar.
// 
// public void Add(Brand brand): Bu ifade, BrandDal sınıfının IBrandDal arayüzünden implemente ettiği Add metodunu tanımlar.
// Bu metod, _brands koleksiyonuna bir Brand nesnesi eklemek içindir.
// 
// public List<Brand> GetAll(): Bu ifade, BrandDal sınıfının IBrandDal arayüzünden implemente ettiği GetAll metodunu tanımlar.
// Bu metod, _brands koleksiyonunu geri döndürerek tüm Brand nesnelerini getirir.


//Add Metodu:

//Bu metot, _brands koleksiyonuna yeni bir Brand nesnesi ekler. Yani, geçici veritabanına yeni bir marka eklemek için kullanılır.
//    Bu metodun amacı, _brands koleksiyonuna veri eklemek ve bu koleksiyonu güncellemektir.

//GetAll Metodu:

//Bu metot, _brands koleksiyonundaki tüm Brand nesnelerini geri döndürür. Yani, geçici veritabanındaki tüm markaları getirmek için kullanılır.
//    Bu metodun amacı, _brands koleksiyonunu çağırarak tüm markaların bir listesini elde etmektir.
//    Bu metodlar, geçici veritabanında markalarla ilgili temel işlemleri gerçekleştirmek için kullanılan basit metotlardır.