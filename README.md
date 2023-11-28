# Real Houzing Emlak Yönetimi Projesi

🏡🚀 **Real Houzing**, modern emlak yönetimi için geliştirilmiş bir projedir. Bu projenin amacı, .NET Core 5.0 teknolojisi ve MsSQL veritabanı kullanarak, emlak yönetimini daha etkili ve kullanıcı dostu hale getirmektir. Proje, Vitrin ve Admin temaları aracılığıyla kullanıcı deneyimini zenginleştirir.

## Proje Katmanları

- **EntityLayer:** Temel veri varlıklarının bulunduğu katmandır. MsSQL veritabanı ile entegre çalışacak şekilde tasarlanmıştır.

- **DataAccessLayer:** Veritabanı işlemlerinin yönetildiği katmandır. MsSQL ile etkileşim sağlayarak veri tabanını yönetir.

- **DtoLayer:** Veri transfer nesnelerinin (DTO) tanımlandığı katmandır. Veri tabanından alınan verilerin API'ler arasında güvenli ve etkili bir şekilde taşınmasını sağlar.

- **ApiLayer:** .NET Core 5.0 API katmanıdır. Bu katman, gerekli işlemleri gerçekleştirerek istemcilere hizmet verir. AutoMapper kullanılarak Entity'ler arasında veri eşleştirmesi sağlanır.

- **ApiConsume:** API'yi tüketen istemci tarafındaki katmandır. Real Houzing'in Vitrin ve Admin temaları, bu katman aracılığıyla API üzerinden etkileşimde bulunur.

## Öne Çıkan Özellikler

- MsSQL kullanarak güçlü ve ölçeklenebilir bir veritabanı altyapısı.
- .NET Core 5.0 teknolojisi ile modern ve performanslı API'ler.
- Temalar arası etkileşimde bulunmak için APIConsume katmanıyla entegrasyon.
- Veri transferi için DTO'lar aracılığıyla güvenli ve etkili veri iletimi.

## Rol ve Sorumluluklar

- Projede, Entity'ler arasındaki veri eşleştirmesi için AutoMapper kullanımını yönettim.
- MsSQL veritabanı entegrasyonunu gerçekleştirerek güçlü bir veritabanı altyapısı oluşturdum.
- .NET Core 5.0 API'leri geliştirerek performanslı ve modern bir iletişim katmanı tasarladım.
- Temalar arası etkileşimi sağlamak için APIConsume katmanını entegre ettim.
- Veri transferi için güvenli ve etkili DTO'lar tasarlayarak API'ler arasında sorunsuz veri iletimini sağladım. 🛠️💻

---

