💻🔏Asp.Net Identity Notları🔏💻
![aspnet-core-core-identity](https://github.com/muhammetkilinc15/AspNetCoreIdentity/assets/108901980/adeb3d7c-dcf1-43cf-ba55-fb8400de8789)

* ASP.NET Core Identity, kullanıcıların kimlik doğrulama ve yetkilendirme işlemlerini yöneten bir üyelik sistemi sağlar. Bu API ile kullanıcılar ve roller oluşturabilir, kullanıcı giriş ve çıkışlarını yönetebilir, rol ve yetki ilişkilerini belirleyebilir ve dış OAuth 2.0 sağlayıcıları aracılığıyla (Facebook, Twitter, Google gibi) kullanıcıları sisteme entegre edebiliriz.
* ➡️**Authentication** :  kullanıcının kimlik bilgilerini doğrulama sürecidir.
* ➡️**Authorization**  :  kimlik doğrulaması yapılmış kullanıcının sistem içindeki erişim izinlerinin kontrol edilmesidir; bu izinler, hangi kaynaklara erişebileceğini belirler.

------------------------------------------------------------------------------------------------

* <mark>Identity Kurulumu için</mark>
* Öncelikle ASP.NET Core Identity‘i kullanmak istediğimiz projeye altyapıyı sağlayacak gerekli Microsoft.AspNetCore.Identity.EntityFrameworkCore ve Microsoft.EntityFrameworkCore.SqlServer NuGet paketlerini kuralım.


--> Şimdi Entity Layer Katmanında kendi AppUser sınıfımızı oluşturuyoruz(bu zorunlu değil ancak kendimiz ekstra özellikler eklemek isteyebilirz)

![Screenshot 2024-05-06 121058](https://github.com/muhammetkilinc15/AspNetCoreIdentity/assets/108901980/548aeef2-cc70-46a7-872a-711e8458f045)

--> Sonrasında DbContext sınıfımızı IdentityDbContext<TUser, TRole, TKey> generic sınıfından inherit alacak şekilde oluşturalım.

![Screenshot 2024-05-06 121355](https://github.com/muhammetkilinc15/AspNetCoreIdentity/assets/108901980/d5740a76-ad71-49bb-8798-c3ce1cb874bd)

--> Oluşturduğumuz DbContext ve Identity API ile ilgili servis ayarlarını Program.cs içerisinden ayarlayalım.
![Screenshot 2024-05-06 121834](https://github.com/muhammetkilinc15/AspNetCoreIdentity/assets/108901980/76517187-b8be-4779-ba7c-905d9ea1861d)

-- Identity Tabloları --
<ul>
    <li> Id : Her bir kullanıcıya denk düşen primary key kolonudur. </li>
        <li> UserName : Her bir kullanıcıya denk düşen primary key kolonudur. </li>
        <li> NormalizedUserName : Her bir kullanıcıya denk düşen primary key kolonudur. </li>
        <li> Email : Her bir kullanıcıya denk düşen primary key kolonudur. </li>
</ul>


