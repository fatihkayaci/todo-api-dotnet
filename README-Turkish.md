# 📋 Todo API - ASP.NET Core

**ASP.NET Core 8** ile geliştirilmiş, **Temiz Mimari**, **Repository Deseni** ve endüstri standartlarını sergileyen modern bir RESTful Web API.

## 🚀 Özellikler

- ✅ **Temiz Mimari** ile uygun katman ayrımı
- ✅ **Repository Deseni** ile veri erişim soyutlaması
- ✅ **Servis Katmanı** ile iş mantığı yönetimi
- ✅ **DTO Deseni** ile API veri transferi
- ✅ **Entity Framework Core** ile SQL Server entegrasyonu
- ✅ **Dependency Injection** ile gevşek bağlılık
- ✅ **Async/Await** ile optimal performans
- ✅ **RESTful API** tasarım prensipleri
- ✅ **Swagger Dokümantasyonu** ile API testi
- ✅ **Uygun HTTP Durum Kodları** ve hata yönetimi

## 🏗️ Mimari

```
┌─────────────────┐
│   Controllers   │ ← HTTP Katmanı (API Endpoint'leri)
└─────────────────┘
         │
┌─────────────────┐
│    Services     │ ← İş Mantığı + DTO Dönüşümü
└─────────────────┘
         │
┌─────────────────┐
│  Repositories   │ ← Veri Erişim Katmanı
└─────────────────┘
         │
┌─────────────────┐
│   Entity EF     │ ← Veritabanı Bağlamı
└─────────────────┘
```

## 🛠️ Teknoloji Yığını

- **Framework:** ASP.NET Core 8
- **Veritabanı:** SQL Server (LocalDB)
- **ORM:** Entity Framework Core
- **Dokümantasyon:** Swagger/OpenAPI
- **Mimari:** Temiz Mimari (Clean Architecture)
- **Desenler:** Repository, Servis Katmanı, DTO

## 📁 Proje Yapısı

```
TodoAPI/
├── Controllers/          # API Controller'lar
├── Services/            # İş Mantığı Katmanı
├── Repositories/        # Veri Erişim Katmanı
├── DTOs/               # Veri Transfer Nesneleri
├── Models/             # Varlık Modelleri
├── Data/               # Veritabanı Bağlamı
├── Interfaces/         # Servis ve Repository Sözleşmeleri
└── Migrations/         # EF Core Migrasyonları
```

## 🚀 Başlarken

### Ön Gereksinimler

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb) (Visual Studio ile birlikte gelir)

### Kurulum

1. **Depoyu klonlayın**
   ```bash
   git clone https://github.com/fatihkayaci/todo-api-dotnet.git
   cd todo-api-dotnet
   ```

2. **Paketleri geri yükleyin**
   ```bash
   dotnet restore
   ```

3. **Veritabanını güncelleyin**
   ```bash
   dotnet ef database update
   ```

4. **Uygulamayı çalıştırın**
   ```bash
   dotnet run
   ```

5. **Swagger UI'ı açın**
   ```
   https://localhost:7148/swagger
   ```

## 📚 API Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| `GET` | `/api/todo` | Tüm todo'ları getir |
| `GET` | `/api/todo/{id}` | ID'ye göre todo getir |
| `POST` | `/api/todo` | Yeni todo oluştur |
| `PUT` | `/api/todo/{id}` | Mevcut todo'yu güncelle |
| `DELETE` | `/api/todo/{id}` | Todo'yu sil |

### Örnek İstekler

**Todo Oluşturma**
```json
POST /api/todo
{
  "title": "ASP.NET Core Öğren",
  "description": "Temiz Mimari desenlerini çalış"
}
```

**Todo Güncelleme**
```json
PUT /api/todo/1
{
  "title": "ASP.NET Core'da Uzmanlaş",
  "isCompleted": true
}
```

## 🧪 Test Etme

Tüm endpoint'leri interaktif olarak test etmek için `/swagger` adresindeki entegre **Swagger UI**'ı kullanın.

Alternatif olarak cURL ile test edin:
```bash
# Tüm todo'ları getir
curl -X GET "https://localhost:7148/api/todo"

# Yeni todo oluştur
curl -X POST "https://localhost:7148/api/todo" \
  -H "Content-Type: application/json" \
  -d '{"title":"Test Todo","description":"API Testi"}'
```

## 💾 Veritabanı

Uygulama, Entity Framework Core ile **SQL Server LocalDB** kullanır. Veritabanı ilk çalıştırmada otomatik olarak oluşturulur.

**Bağlantı Dizesi:** `Server=(localdb)\\mssqllocaldb;Database=TodoDB;Trusted_Connection=true`

## 🏛️ Kullanılan Tasarım Desenleri

- **Repository Deseni** - Veri erişim mantığını soyutlar
- **Servis Katmanı Deseni** - İş mantığını kapsüller
- **DTO Deseni** - İç modelleri API sözleşmelerinden ayırır
- **Dependency Injection** - Gevşek bağlılığı teşvik eder
- **Async/Await Deseni** - Engelleyici olmayan işlemler

## 📝 Temel Öğrenme Noktaları

Bu proje şunları gösterir:
- **Ölçeklenebilir Web API** nasıl yapılandırılır
- Temiz Mimaride **endişelerin ayrılması**
- Uygun DTO'larla **profesyonel API tasarımı**
- **Entity Framework** en iyi uygulamaları
- **Dependency Injection** implementasyonu
- **RESTful API** konvansiyonları

## 🔍 Proje Hakkında

Bu Todo API projesi, modern .NET geliştirme pratiklerini ve enterprise seviyede kod yazma standartlarını öğrenmek için geliştirilmiştir. Katmanlı mimari yaklaşımı ile ölçeklenebilir ve sürdürülebilir bir API tasarımı sunmaktadır.

### Öne Çıkan Teknik Özellikler

- **Async Programming** ile yüksek performans
- **Clean Code** prensipleri ile okunabilir kod
- **SOLID** prensiplerine uygun tasarım
- **Enterprise** seviyede hata yönetimi
- **Scalable** architecture ile gelecek odaklı yaklaşım

## 🤝 Katkıda Bulunma

1. Projeyi fork edin
2. Feature branch'i oluşturun (`git checkout -b feature/HarikaOzellik`)
3. Değişikliklerinizi commit edin (`git commit -m 'Harika özellik eklendi'`)
4. Branch'inizi push edin (`git push origin feature/HarikaOzellik`)
5. Pull Request açın

## 📧 İletişim

**Fatih Kayacı** 
- [GitHub](https://github.com/fatihkayaci)
- LinkedIn: [Fatih Kayacı](https://www.linkedin.com/in/fatih-kayaci-79180a28a/)
- Email: fatihkayaci@yahoo.com

Proje Linki: [https://github.com/fatihkayaci/todo-api-dotnet](https://github.com/fatihkayaci/todo-api-dotnet)

---

⭐ **Bu projeyi beğendiyseniz, lütfen yıldız verin!**