# StokTakipProgrami
# 🛍️ E-Ticaret Butik Yönetimi - Stok Takip Programı

Bu proje, aktif olarak satış yapan bir e-ticaret butik sayfasının dinamik ihtiyaçları (ürün çeşitliliği, anlık stok takibi, kritik stok sınırları ve finansal raporlama) göz önünde bulundurularak geliştirilmiş bir masaüstü uygulamasıdır.

## 🚀 Proje Tanıtım Videosu
Uygulamanın nasıl çalıştığına dair detaylı videosunu Releases kısmından izleyebilirsiniz.

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
---

## ⚙️ Projeyi İndirme ve Çalıştırma Kılavuzu

Projenin yerel bilgisayarınızda sorunsuz bir şekilde test edilebilmesi için aşağıdaki adımları sırasıyla uygulamanız yeterlidir:

### 1. Adım: Projeyi İndirmek
1. Bu GitHub sayfasının üst kısmında yer alan yeşil renkli **`<> Code`** butonuna tıklayın.
2. Açılan menüden **`Download ZIP`** seçeneğine basarak tüm proje dosyalarını bilgisayarınıza indirin.

### 2. Adım: Klasöre Ayıklamak
1. Bilgisayarınıza inen sıkıştırılmış `.zip` dosyasına sağ tıklayın.
2. **"Klasöre Ayıkla"** (Extract) diyerek dosyaları normal bir klasör haline getirin.

### 3. Adım: Visual Studio ile Açmak
1. Ayıkladığınız klasörün içerisine girin.
2. Klasörün içinde yer alan ve projenin çalıştırıcı anahtarı olan **`Stok_Program.csproj`** uzantılı dosyaya çift tıklayın.

### 4. Adım: Çalıştırma
* Dosyaya çift tıkladığınızda proje tüm formları, tasarımları ve kod mimarisiyle birlikte otomatik olarak *Visual Studio* üzerinde açılacaktır. 
* Üst panelde bulunan **`Start` (Başlat)** butonuna basarak programı test etmeye başlayabilirsiniz.
