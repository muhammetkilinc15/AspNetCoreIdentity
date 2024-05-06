💻🔏Asp.Net Identity Notları🔏💻
![aspnet-core-core-identity](https://github.com/muhammetkilinc15/AspNetCoreIdentity/assets/108901980/adeb3d7c-dcf1-43cf-ba55-fb8400de8789)

* ASP.NET Core Identity, kullanıcıların kimlik doğrulama ve yetkilendirme işlemlerini yöneten bir üyelik sistemi sağlar. Bu API ile kullanıcılar ve roller oluşturabilir, kullanıcı giriş ve çıkışlarını yönetebilir, rol ve yetki ilişkilerini belirleyebilir ve dış OAuth 2.0 sağlayıcıları aracılığıyla (Facebook, Twitter, Google gibi) kullanıcıları sisteme entegre edebiliriz.
* ➡️**Authentication** :  kullanıcının kimlik bilgilerini doğrulama sürecidir.
* ➡️**Authorization**  :  kimlik doğrulaması yapılmış kullanıcının sistem içindeki erişim izinlerinin kontrol edilmesidir; bu izinler, hangi kaynaklara erişebileceğini belirler.

------------------------------------------------------------------------------------------------

* <mark>Identity Kurulumu için</mark>
* --> Öncelikle ASP.NET Core Identity‘i kullanmak istediğimiz projeye altyapıyı sağlayacak gerekli Microsoft.AspNetCore.Identity.EntityFrameworkCore ve Microsoft.EntityFrameworkCore.SqlServer NuGet paketlerini kuralım.

** Öncellikle IdentityUser Sınıfında hangi propert ' ler var inceleyelim
<code>
public class IdentityUser
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string NormalizedUserName { get; set; }
    public string Email { get; set; }
    public string NormalizedEmail { get; set; }
    public bool EmailConfirmed { get; set; }
    public string PasswordHash { get; set; }
    public string SecurityStamp { get; set; }
    public string ConcurrencyStamp { get; set; }
    public DateTimeOffset? LockoutEnd { get; set; }
    public bool LockoutEnabled { get; set; }
    public int AccessFailedCount { get; set; }
    // Diğer özellikler
}
</code>

