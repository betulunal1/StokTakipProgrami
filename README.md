# StokTakipProgrami
# 🛍️ E-Ticaret Butik Yönetimi - Stok Takip Programı

Bu proje, aktif olarak satış yapan bir e-ticaret butik sayfasının dinamik ihtiyaçları (ürün çeşitliliği, anlık stok takibi, kritik stok sınırları ve finansal raporlama) göz önünde bulundurularak geliştirilmiş bir masaüstü uygulamasıdır.

## 🚀 Proje Tanıtım Videosu
Uygulamanın detaylı sunumunu, özelliklerini ve çalışma simülasyonunu izlemek için aşağıdaki bağlantıya tıklayabilirsiniz:

---

## 🛠️ Kullanılan Teknolojiler ve Mimariler
* **Geliştirme Ortamı:** C# Windows Form App (.NET Framework)
* **Veritabanı:** Microsoft SQL Server (Katmanlı yapıya uygun veri tabanı yönetimi)
* **Veritabanı Entegrasyonu:** ADO.NET (CRUD İşlemleri, Güvenli SQL Sorguları)

---

## ✨ Temel Özellikler
1. **Dinamik Stok Takibi:** Butik ürünlerinin (giyim, kozmetik vb.) barkod, alış/satış fiyatı ve kategori bazlı sisteme kaydedilmesi, güncellenmesi ve listelenmesi.
2. **Kritik Stok Uyarı Sistemi:** Stok miktarı belirlenen güvenli sınırın altına düşen popüler ürünler için sistemin otomatik olarak görsel uyarı tetiklemesi.
3. **Satış ve Stoktan Düşme:** Gerçekleşen siparişlerin tek tıkla stoktan düşülerek veritabanının anlık güncellenmesi.
4. **Ciro ve Finans Raporu:** Belirli tarih aralıklarına veya gün sonuna göre yapılan toplam satışların ve elde edilen net cironun SQL veritabanından filtrelenerek raporlanması.

---

## 💾 Kurulum ve Çalıştırma Notu
* Projenin tıkır tıkır çalışabilmesi için kaynak kodların yanında yer alan `stok_program_yedek.sql` veritabanı dosyasının SQL Server üzerinde yürütülmesi (Execute) gerekmektedir. 
* Proje içerisindeki `SqlConnection` bağlantı cümlesindeki (Connection String) veri kaynağı alanını kendi yerel SQL Server adınızla güncellemeniz yeterlidir.
