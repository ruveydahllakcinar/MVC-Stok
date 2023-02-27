# MVC-101

İlk MVC projem. Bu projede MVC mantığını anlamak için sadece temel CRUD işlemleri gerçekleştirdim. Örneğin bir ürün tablosu için listeleme-silme-güncelleme-ekleme ve id'ye göre getirme işlemleri gerçekleştirdim. Bu projemde Model-View-Controller yapısı kullanmamın nedeni MVC sayesinde daha hızlı, daha temiz kod yazmamı sağlamaktı.

## Use to Libraries 

- .NET Framework (4.6.1)
- Entity Framework (6.0.0)

## Use to Model 
- ADO.NET Entity Data Model


## Proje Kurulumu

* İlk olarak [Visual Studio](https://visualstudio.microsoft.com/tr/) kurulumu yapmanız gerekmektedir. 

* ASP.NET Web Application(.NET Framework) seçeneğini seçip sürümünü seçmeniz gerekektedir. 
*Bknz.* Ben 4.6.1 sürümü ile projeyi geliştirdim.

* Proje isminizi, sürümünüzü seçtikten sonra next diyip application'ı nasıl geliştireceğinizi seçmeniz için bir ekran geliyor. Biz MVC kullanacağımız için MVC seçeneğini seçiyoruz.

**İşte bu kadar projeniz kod yazmak için hazır.**  

## Proje Detayları
1. Models alanında Entity klasörü oluşturarak kurmuş olduğum Entity Framework kütüphanesini kullanarak MySql'de hazırlamış olduğum tabloyu ADO.NET Entity Data Model kullanarak projeme tablomu dahil ettim. 
[Model Çıktısı](/Views/assets/img/model.png) 
2. Proje içinde Controller alanında üç adet controller oluşturdum. Bu controller alanlarında temel crud işlemlerimi yazdım. Kategori controller, müşteri controller ve ürün controller alanlarını oluşturdum ve backend kodlarını yazdım.[müşteri controller sayfası ](/Views/assets/img/mustericontroller.png) 

3. Views alanım ise yazmış olduğum backend kodlarının çıktısını aldığım yani frontend alanım. Burada tablolarımı oluşturarak silme, güncelleme,ekleme gibi parametreli yaptığım, kullanıcının karşısına çıkardığım sayfaların kodlarını yazdığım alanım. [urun listeleme sayfası](/Views/assets/img/urunlisteleme.png) 


