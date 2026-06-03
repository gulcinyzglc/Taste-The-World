# Taste The World 🌍🍽️

**Taste The World**, dünyanın farklı şehirlerindeki eşsiz lezzetleri keşfetmenizi, favori yemeklerinizi puanlamanızı ve kendi gastronomi "Ölmeden Önce Yenilecekler" (Bucket List) listenizi oluşturmanızı sağlayan bir ASP.NET Core MVC web uygulamasıdır.

## 🚀 Özellikler

- **Kullanıcı Kimlik Doğrulaması:** Kayıt olma ve giriş yapma işlemleri (Session tabanlı oturum yönetimi).
- **Şehir ve Yemek Keşfi:** Dünyanın farklı şehirlerine ait popüler yemeklerin listelenmesi ve detaylı incelenmesi.
- **Yemek Detayları:** Yemeklerin açıklaması, görseli, fiyat aralığı (₺₺₺), baharatlı/vejetaryen olma durumu ve kategorisi gibi detaylı bilgiler.
- **Değerlendirme Sistemi:** Yemeklere yorum yapma ve puan verme imkanı.
- **Kişisel Bucket List:** Kullanıcıların denemek istedikleri yemekleri kendi "Bucket List" (İstek Listesi) alanlarına eklemesi ve yönetmesi.

## 💻 Kullanılan Teknolojiler

- **Backend:** C#, ASP.NET Core MVC (.NET 10.0)
- **Veritabanı:** SQLite & Entity Framework Core (Code-First yaklaşımı)
- **Frontend:** HTML, CSS, JavaScript, Razor Views (Standart MVC yapısı)

## 📁 Proje Yapısı

- `Controllers/`: HTTP isteklerini işleyen ve yönlendiren denetleyiciler (`Account`, `City`, `Food`, `BucketList`, `Home`).
- `Models/`: Veritabanı tablolarını temsil eden sınıflar (`User`, `Food`, `City`, `BucketList`, `Review`).
- `Views/`: Kullanıcı arayüzünü (UI) oluşturan Razor sayfaları.
- `Data/`: Entity Framework `AppDbContext` ayarları ve veritabanı bağlantı yapılandırmaları.
- `wwwroot/`: Statik dosyalar (CSS, JS, Görseller).
- `tastetheworld.db`: Uygulamanın SQLite veritabanı dosyası.

## ⚙️ Kurulum ve Çalıştırma

Projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1. **Projeyi Klonlayın veya İndirin:**
   ```bash
   git clone <repo-url>
   cd TasteTheWorld
   ```

2. **Gerekli Bağımlılıkları Yükleyin:**
   ```bash
   dotnet restore
   ```

3. **Veritabanını Hazırlayın:**
   Proje çalıştırıldığında `Program.cs` içerisindeki `db.Database.EnsureCreated();` metodu sayesinde veritabanı (SQLite) otomatik olarak oluşturulacaktır. Herhangi bir migration komutu çalıştırmanıza gerek yoktur, ancak migration kullanmak isterseniz:
   ```bash
   dotnet ef database update
   ```

4. **Uygulamayı Çalıştırın:**
   ```bash
   dotnet run
   ```
   Uygulama varsayılan olarak `https://localhost:5001` veya `http://localhost:5000` portlarında çalışacaktır.

## 👥 Katkıda Bulunma

Bu proje geliştirilmeye açıktır. Katkıda bulunmak isterseniz bir `Pull Request` oluşturabilir veya karşılaştığınız sorunları `Issues` sekmesinden bildirebilirsiniz.

## 📄 Lisans

Bu proje eğitim ve kişisel gelişim amacıyla oluşturulmuştur. Özel bir lisansa sahip değildir.
