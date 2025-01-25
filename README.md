# :rocket:FinancialCRM

Bu repo, Murat Yücedağ'ın YouTube üzerinden hazırladığı [C# Eğitim Kampı](https://www.youtube.com/playlist?list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr) kapsamında oluşturulmuştur. Proje kampın son projesidir.

---

## :computer: Projede Kullanılan Teknolojiler
- **C#:** *Projenin geliştirildiği programlama dilidir.*
- **Windows Form:** *Uygulamanın arayüzünün tasarlanmasında kullanılmıştır.*
- **SQL Server:** *Veri tabanı işlemleri için Microsoft SQL Server kullanılmıştır.*
- **Entity Framework:** *ORM yapısı ile veritabanı etkileşimleri sağlanmıştır.*
- **LINQ:** *Çeşitli sorgular için Linq bileşeni kullanılmıştır.*
- **CRUD:** *Veritabanı üzerinden ekleme, okuma, silme ve güncelleme işlemleri gerçekleştirilmektedir.* 

---

### Giriş Paneli :camera:
FinancialCRM uygulamasına kullanıcı adı ve şifre ile giriş yapılabilir. Şifresini hatırlamayan kullanıcılar için şifre resetleme formuna bu formdan ulaşabilmektedir.

<div align = "center">
<img width="824" alt="FinancialCRM Login Panel" src="https://github.com/user-attachments/assets/63868321-67a4-462c-bede-e928c6c582e0">
</div>

---

### Şifre Sıfırlama Paneli :camera:
FinancialCRM uygulamasının şifresini hatırlamayan kullanıcılar için oluşturulan şifre sıfırlama formudur. Kullanıcı e-posta yardımıyla şifresini sıfırlayarak yeni bir şifre belirleyebilmektedir. Bu form üzerinden Giriş Yap linkine tıklayarak tekrar giriş paneline dönülebilir.

<div align = "center">
<img width="824" alt="FinancialCRM Password Reset Panel" src="https://github.com/user-attachments/assets/36f7ad18-6915-4c46-82bc-27922ba7f15c">
</div>

---

### Bankalar Paneli :camera:
Uygulamaya giriş yapıldıktan sonra bizi karşılayan paneldir. Bu formda banka hesap bakiyeleri ve son beş banka hareketi kullanıcıya gösterilmektedir.

<div align = "center">
<img width="824" alt="FinancialCRM Banks Panel" src="https://github.com/user-attachments/assets/28deea60-e92c-4cbf-9a23-505c8fc15e3e">
</div>

---

### Kategoriler Paneli :camera:
Bu panelde kullanıcının giderlerinin içinde olduğu belirli kategoriler gösterilmektedir. Kategorileri listeleme, yeni bir kategori ekleme ve mevuct bir kategoriyi silme ya da güncelleme gibi işlemler yapılabilmektedir.

<div align = "center">
<img width="824" alt="FinancialCRM Categories Panel" src="https://github.com/user-attachments/assets/835328cd-18bd-49fd-9a68-a139f55e86d9">
</div>

---

### Faturalar Paneli :camera:
Bu panelde kullanıcının fatura giderleri gösterilmektedir. Buna ek olarak, yeni fatura ekleme, mevcut faturayı silme ve güncelleme gibi işlemler de yapılabilmektedir.

<div align = "center">
<img width="824" alt="FinancialCRM Bills Panel" src="https://github.com/user-attachments/assets/fb42979b-8e2c-402c-8103-50887ea9848f">
</div>

---

### Harcamalar Paneli :camera:
Kullanıcının faturaların dışında kalan giderlerinin gösterildiği paneldir. Kullanıcılar bu panel üzerinden harcamalarını listeyebilir, yeni bir harcama ekleyebilir ve mevcut bir harcamayı silebilir veya kayıt üzerinde güncelleme işlemleri yapabilmektedir.

<div align = "center">
<img width="824" alt="FinancialCRM Spendings Panel" src="https://github.com/user-attachments/assets/b5b01612-9d6f-47b3-b146-231c660daa65">
</div>

---

### Banka Hareketleri Paneli :camera:
Bu panelde yapılan bankacılık işlemlerine dair verilerin gösterildiği paneldir. Kullanıcı bu panel üzerinden banka hareketlerini listeleyebilir, yeni bir banka hareketi ekleyebilir, mevcut banka hareketini silme ya da güncelleme işlemlerini gerçekleştirebilmektedir. 

<div align = "center">
<img width="824" alt="FinancialCRM Bank Processes Panel" src="https://github.com/user-attachments/assets/a1f95e5d-1937-469e-9fc3-7063013ad36a">
</div>

---

### Dashboard / Genel Bakış Paneli :camera:
Bu panelde kullanıcı verilerine genel olarak göz atabilmektedir. Kullanıcılar tüm banka hesaplarında bulunan mevcut bakiyenin toplamını ve fatura giderlerini grafiklerinde yardımıyla görebilmektedir. Buna ek olarak son gelen havale işlemide bu panelde görüntülenmektedir.

<div align = "center">
<img width="824" alt="FinancialCRM Dashboard Panel" src="https://github.com/user-attachments/assets/5d01f050-6e34-4080-a646-da99b81ed7fc">
</div>

---

### Ayarlar Paneli :camera:
Kullanıcının telefon, e-posta ve şifre bilgileri üzerinde değişiklik yapabildiği paneldir.

<div align = "center">
<img width="824" alt="FinancialCRM Settings Panel" src="https://github.com/user-attachments/assets/3cbcff92-cfe6-4c7f-92c5-17e11005461c">
</div>

---

#### Çıkış Yap Butonu
Bu buton ile kullanıcı ugulamadan çıkış yaparak giriş ekranına geri döner.
