# 📚 MvcKutuphane - ASP.NET MVC Tabalı Panelli Kütüphane Yönetim Sistemi
MvcKutuphane, kütüphane kaynaklarının etkin yönetimi için geliştirilmiş bir web uygulamasıdır. Üç farklı kullanıcı rolüne göre paneller sunar:
- 👦🏼 **Admin Paneli**: Kitap, kategori, yazar, personel ve üye işlemlerini yönetir. İstatistik, grafik ve hava durumu gibi modüller içerir.
- 👤  **Üye Paneli**: Üyelerin kitap arama, ödünç alma, iade ve mesajlaşma işlemlerini gerçekleştirdiği alandır.
- 👁️‍🗨️**Misafir Paneli (Vitrin)**: Siteyi ziyaret eden kullanıcılar için temel bilgilerin sunulduğu vitrindir.
## 👦🏼 A)ADMİN PANELİ
### 1.Admin Yönetim Paneli Girişi
![image](https://github.com/user-attachments/assets/1fc08681-21ad-4eab-a4fa-15c250f1de14)
Bu sayfa, uygulamanın yönetim paneline erişim sağlamak için kullanılır. Yetkili kullanıcılar, bu form aracılığıyla kullanıcı adı ve şifrelerini girerek sistemin yönetim arayüzüne giriş yapabilirler.
### 2.Ana Sayfa
![image](https://github.com/user-attachments/assets/71af6783-3a4d-4db0-b02f-2d5b874da4fc)
Bu sayfa, Kütüphane Yönetim Sistemi'nin kullanıcı girişinden sonra karşılaşılan ilk ekranıdır. Sistem hakkında genel bir bakış sunar ve kullanıcılara temel işlevlere hızlı erişim imkanı tanır.
### 3.Kategori Listesi
![kategori](https://github.com/user-attachments/assets/fc5ba602-6e98-483c-9dbf-6c9364488d7e)
Bu sayfa aracılığıyla yöneticiler aşağıdaki işlemleri gerçekleştirebilir:
-Yeni Kategori Ekleme: Sisteme yeni kitap kategorileri tanımlayabilirler.
-Kategori Silme: Mevcut kategorileri sistemden silebilirler (dikkatli olunmalıdır, çünkü bu kategoriye bağlı kitaplar da etkilenebilir).
-Kategori Güncelleme: Mevcut kategorilerin adlarını veya diğer ilgili bilgilerini düzenleyebilirler.
### 4.Kitap Listesi
![kitap](https://github.com/user-attachments/assets/419c3b88-38cc-45ba-8018-c8d3eef61fa8)
Bu sayfa, kütüphanedeki tüm kayıtlı kitapların bir listesini sunar ve bu kitapların yönetilmesine olanak tanır. Kullanıcılar bu sayfa üzerinden kitap bilgilerini görüntüleyebilir, yeni kitap ekleyebilir, mevcut kitapları silebilir veya güncelleyebilirler. Ayrıca, her bir kitabın kütüphanedeki mevcut durumu hakkında da bilgi sahibi olabilirler.
### 5.Yazar Listesi
![yazar](https://github.com/user-attachments/assets/7f0dfa09-8c3f-41e1-b2bd-2b48276bd4fc)
![yazardetay](https://github.com/user-attachments/assets/e9574f42-7f8a-48ef-b1e8-b79f48b5c62a)
Bu sayfa, sistemde kayıtlı olan tüm yazarların bir listesini görüntüler ve yazarların yönetilmesine olanak tanır. Listelenen yazarların her birinin yanında bulunan "Kitaplar" bağlantısına tıklayarak, o yazara ait kütüphanede bulunan tüm kitaplara kolayca erişilebilir. Kütüphanedeki kitapların yazarlarına göre düzenlenmesi ve yönetilmesi için önemli bir araçtır.
### 6.Üye Listesi
![üye](https://github.com/user-attachments/assets/7da4eb6a-24ad-415e-800e-082562b6a049)
![üyebilgi](https://github.com/user-attachments/assets/c59208c9-38e7-4b9a-9ca8-c41410d509b0)
Bu sayfa, kütüphaneye kayıtlı olan tüm üyelerin bir listesini görüntüler ve üye kayıtlarının yönetilmesine olanak tanır. Kütüphane kullanıcılarının bilgilerinin takip edilmesi ve yönetilmesi için temel bir araçtır.Ayrıca Kullanıcılar Kitap Geçmişi 
butonuna tıklayarak,listedeki her bir üyenin kütüphanedeki ödünç alma ve iade geçmişine ulaşabilirler.
### 7.Personel Listesi
![personel](https://github.com/user-attachments/assets/bc771933-36c4-438b-9bc9-343058c236ed)
Bu sayfa, Kütüphane Yönetim Sistemi'nde kayıtlı personellerin ID ve ad gibi temel bilgilerini listeleyen, her bir kayıt için silme ve güncelleme işlemlerini mümkün kılan, aynı zamanda yeni personel ekleme işlevselliğini sağlayan temel bir personel yönetim ekranıdır.
### 8.Kitap Ödünç Verme
![kitapödünç](https://github.com/user-attachments/assets/4ed9cac6-22d0-43c4-b5cb-a158fa627ed0)
Bu sayfa, Kütüphane Yönetim Sistemi'nde kitap ödünç verme işleminin gerçekleştirildiği arayüzdür. Üye Adı, Kitap Adı, Personel Adı, Alış Tarihi ve İade Tarihi gibi ödünç verme işlemine ait bilgilerin girildiği alanları içerir ve "İşlemi Gerçekleştir" butonu aracılığıyla ödünç verme işlemini tamamlar.
### 9.Ödünç Verilmiş Kitap Listesi
![ödünçliste](https://github.com/user-attachments/assets/0b1b068c-f6d2-4f0a-a41f-faa81c1e3742)
Bu sayfa, Kütüphane Yönetim Sistemi'nde ödünç verilmiş kitapların listesini sunmaktadır. Tabloda İşlem ID, Kitap Adı, Üye Adı, Personel Adı, Alış Tarihi, İade Tarihi ve "Kitabı İade Al" butonu gibi ödünç verme işlemlerine ait detaylar yer almaktadır. "Kitabı İade Al" butonu aracılığıyla ödünçteki kitapların sisteme iade kaydı gerçekleştirilebilir.
### 10.Duyuru Listesi
![duyurular](https://github.com/user-attachments/assets/b416333f-db3a-4a9f-bf05-5e2c691f0897)
Bu sayfa, Kütüphane Yönetim Sistemi'nde yayınlanan duyuruların özetini tablo halinde sunar; duyuru numarası, kategorisi, içeriği ve tarihi gibi bilgileri gösterir. Ayrıca, mevcut duyuruları silme ve güncelleme işlevlerinin yanı sıra, yeni duyurular oluşturma imkanı da sağlar.
### 11.İadesi Alınan Kitap Listesi
![iadealınanliste](https://github.com/user-attachments/assets/ce1a4f9b-204c-4eb5-8142-56df03b5de9f)
![iadedetaylar](https://github.com/user-attachments/assets/afdd3ae1-f7da-44fa-8b03-87a3d82b24bd)

Bu sayfa, Kütüphane Yönetim Sistemi'nde iadesi gerçekleşmiş kitapların kayıtlarını özet olarak sunar. Her bir kitap iadesine ait temel bilgilerin yanı sıra, "Detaylar" butonu aracılığıyla kitabın ödünç alınma ve iade süreçlerine dair daha fazla bilgiye erişilebilir, 
bu sayede kitabın zamanında iade edilip edilmediği ve iade edilmediyse kaç gün geciktiği kontrol edilebilir .
### 12.İstatistik Bilgileri 
![istatistikler](https://github.com/user-attachments/assets/1aa6ae6b-4dcf-43ff-a5eb-a52d98efc723)
Bu sayfa, Kütüphane Yönetim Sistemi'nin genel istatistiklerini ve bazı temel yönetim araçlarını bir arada sunan bir gösterge panosudur. En üst kısımda dört adet temel istatistik kartı yer almaktadır:
$ 7,00 TL yazan yeşil kart, sistemdeki toplam ceza tutarını göstermektedir.
11 yazan pembe kart, sistemdeki toplam üye sayısını ifade etmektedir.
27 yazan mavi kart, kütüphanedeki toplam kitap sayısını belirtmektedir.
2 yazan lacivert kart ise, şu anda emanet verilmiş olan kitap sayısını göstermektedir.
Sayfanın geri kalanında yer alan çeşitli grafikler, dünya haritası ve listeler gibi istatistiksel gösterimler ise, bu temel bilgileri görsel olarak desteklemek ve sayfaya estetik bir görünüm katmak amacıyla eklenmiştir
### 13.Linq Kartlar 
![linq](https://github.com/user-attachments/assets/2883f330-86ca-4883-9e89-c81c49143fa3)
Bu sayfa, Kütüphane Yönetim Sistemi'nin çeşitli önemli istatistiklerini ve temel performans göstergelerini kolayca takip edilebilmesi için kartlar aracılığıyla görselleştirmektedir. Kullanıcılara toplam kitap sayısı, kayıtlı üye sayısı, tahsil edilen ceza tutarı, şu anda ödünçte olan kitap sayısı gibi temel bilgilerin yanı sıra, en aktif kullanıcı, en çok okunan kitap ve en başarılı personel gibi daha detaylı analizleri hızlı bir şekilde sunarak sistem hakkında kapsamlı bir genel bakış sağlar.
### 14.Kütüphane Fotoğrafları
![image](https://github.com/user-attachments/assets/3bb5159b-abf0-41ad-b294-40f288ff0baa)
Bu sayfa, Kütüphane Yönetim Sistemi'nin fotoğraf bölümüdür. Kütüphane fotoğrafı gösterilir ve yeni fotoğraf yüklemek için "Dosya Seç" butonu bulunur.
### 15.Hava Durumu
![hava durumu](https://github.com/user-attachments/assets/8fb50298-a693-4cbd-b093-5cb4340989d5)
Bu sayfa, Kütüphane Yönetim Sistemi'nin "Hava Durumu" bölümüdür. İstanbul için 6 Mayıs 2025 tarihli örnek hava durumu bilgilerini görsel bir kartta sunmaktadır. Bu bilgiler gerçeği yansıtmayıp, sayfanın görünümünü zenginleştirmek için kullanılmıştır.
### 16.Hava Kartları
![hava kart](https://github.com/user-attachments/assets/0fa7ee5f-2977-4f00-b1e0-e2e824b006cc)
Bu sayfa, Kütüphane Yönetim Sistemi kullanıcılarına Türkiye'nin farklı şehirlerindeki (İstanbul, Ankara, İzmir, Antalya, Sinop, Elazığ, Van) doğru ve güncel hava durumu bilgilerini detaylı bir şekilde sunmaktadır. Her bir şehir için mevcut hava durumu ikonu, sıcaklık değeri ve kısa bir açıklama yer alırken, takip eden günlere ait sıcaklık tahminleri de ayrı ayrı gösterilmektedir. 
### 17.Grafik
![grafik](https://github.com/user-attachments/assets/d115225a-f1d2-4df6-8aa9-baa2d9f92233)
Bu sayfa, Kütüphane Yönetim Sistemi'ndeki kitapların yayınevlerine göre yüzdesel dağılımını gösteren bir daire grafiğidir. Her renk bir yayınevini temsil eder ve dilimin büyüklüğü o yayınevinin kitap oranını ifade eder.
### 18.Yardım
![yardım](https://github.com/user-attachments/assets/dd68f2ee-9f77-43a9-9a09-17c33abe82a8)
Bu sayfa, Kütüphane Yönetim Sistemi'nin "Yardım Sayfası"dır. Kullanıcılara üye kaydı, kitap arama, kitap ödünç alma ve iade süresi gibi sıkça sorulan soruların kısa cevaplarını sunar. Ayrıca, daha fazla destek için "Bize Ulaşın" butonu içerir.
## 👁️‍🗨️ B)MİSAFİR(VİTRİN) PANELİ
### 1.Kütüphane Anasasayfa
![image](https://github.com/user-attachments/assets/73d3a0e7-b011-4cf0-a656-8666b3bb2cb1)
Bu sayfa, "MVC 5 İLE KÜTÜPHANE SİSTEMİ" adlı uygulamanın kullanıcıları karşılayan ilk sayfadır. Sayfanın üst kısmında temel navigasyon bağlantıları bulunmaktadır. Ekranda kullanıcıyı karşılayan ana mesaj ve görsel öğeler yer almaktadır
### 2.Kitaplar
![image](https://github.com/user-attachments/assets/ed5c4014-485b-496d-9553-bef1a21d343e)
![image](https://github.com/user-attachments/assets/5b1734a3-5549-4e05-b8bf-7197e38c1bbc)
![image](https://github.com/user-attachments/assets/a53278df-efa1-4afa-a334-9c7e211fb0af)
Bu sayfa, "MVC 5 İLE KÜTÜPHANE SİSTEMİ" projemize ait kitapların sergilendiği "KİTAPLARIMIZ" bölümünü göstermektedir. Bu bölümde, kütüphanemizde bulunan çeşitli kitapların kapak görselleri listelenmektedir. Her bir kitap görseli, 
kullanıcılara kütüphanemizin zengin içeriği hakkında bir fikir vermeyi amaçlamaktadır. Bu listeleme sayesinde kullanıcılar, kütüphanemizde bulunan farklı tür ve yazarlara ait kitapları kolayca keşfedebilirler.
### 3.Hakkımızda
![image](https://github.com/user-attachments/assets/1f07aad1-24c1-45ba-8c2d-72c5b7a6684b)
Bu bölüm, "MVC 5 İLE KÜTÜPHANE SİSTEMİ" projesinin "Hakkımızda" kısmını sunmaktadır. Burada, projenin geliştirilmesinde kullanılan teknolojiler, temel amaçları ve sunduğu ana özellikler anlatılmaktadır. Hem kullanıcı hem de yönetici tarafına yönelik modüllerin işlevleri ve projenin genel yapısı hakkında bilgi verilmektedir.
### 4.İletişim
![image](https://github.com/user-attachments/assets/07de3f4b-d20c-41f8-a01d-4a1249916cc5)
Bu ekran, "MVC 5 İLE KÜTÜPHANE SİSTEMİ" uygulamasının iletişim sayfasıdır. Kullanıcıların ad, soyad, e-posta, konu ve mesajlarını girerek sistem yöneticileriyle iletişim kurmasını sağlayan bir form içerir. "Gönder" butonu ile mesaj iletilir.
### 5.Uygulama Footer Bilgisi
![image](https://github.com/user-attachments/assets/598167fe-825b-4bfb-8a1e-d841159ccd2c)
Bu kısım, "MVC 5 İLE KÜTÜPHANE SİSTEMİ" uygulamasının altındaki iletişim (adres, sosyal medya) ve teknik (MVC5, Bootstrap) bilgileri ile telif hakkını özetler.
## 👤C)ÜYE PANELİ 
### 1.Kayıt Paneli
![kayıtol](https://github.com/user-attachments/assets/2d077094-de3a-452c-8d29-def76b27a453)
Bu sayfa, "MVC5 KÜTÜPHANE YÖNETİM SİSTEMİ" için bir kayıt sayfasıdır. Sol tarafta hoş geldiniz mesajı ve kayıt olma talimatları ile oturum açma/siteye dönme butonları bulunur. Sağda ise ad, soyad, e-posta, kullanıcı adı, şifre, telefon ve okul bilgisi isteyen bir kayıt formu ile şartları kabul etme onay kutusu ve "Kayıt Ol" butonu yer alır ve bu butona tıklandığında üye kaydı oluşturulur.
### 2.Oturum Açma Paneli
![login](https://github.com/user-attachments/assets/e2639970-a68f-4d55-ac9e-071f7eb3b2cb)
 bu sayfa bir web uygulamasının giriş yapma (login) sayfasıdır. Kütüphane sistemine erişmek için e-posta adresinizi ve şifrenizi ilgili alanlara girmeniz ve ardından "GİRİŞ YAP" butonuna tıklamanız gerekmektedir. Eğer hesabınız yoksa, "KAYIT OL" bağlantısını kullanarak yeni bir hesap oluşturabilirsiniz. Şifrenizi unuttuysanız, "Şifremi Unuttum?" bağlantısını kullanabilirsiniz.
### 3.Profil Bilgileri
![image](https://github.com/user-attachments/assets/6e9f040c-46a4-49a5-80ce-c6d726552297)
Bu sayfada, "Salih Demir" adlı kullanıcının üyelik bilgileri bulunmaktadır. Sol tarafta kullanıcının profil fotoğrafı, adı, soyadı ve üyelik durumu özetlenmiştir. Ayrıca kullanıcının okuduğu kitap sayısı, gelen kutusundaki mesaj sayısı ve duyuru sayısı gibi bilgilere de yer verilmiştir.
Sayfanın sağ tarafında ise kullanıcının kişisel bilgileri detaylı olarak listelenmektedir. Bu bilgiler arasında adı, soyadı, kullanıcı adı, şifresi, fotoğrafının bağlantısı, okuduğu okul ve e-posta adresi bulunmaktadır. Kullanıcı, bu bilgileri güncelleyebilir ve değişiklikleri kaydedebilir. Ayrıca, gelen kutusuna gitmek için bir buton da mevcuttur.
Özetle, bu sayfa kullanıcının profilini ve kişisel bilgilerini görüntülemesine ve güncellemesine olanak tanır.
### 4.Gelen Mesajlar
![image](https://github.com/user-attachments/assets/8a010169-b79e-471a-a990-c51ba13b2eb6)
Elbette, bu bölümü de benzer şekilde açıklayabilirim:
Bu sayfada kullanıcının "Gelen Kutusu" görüntülenmektedir. Sol tarafta, gelen kutusu, gönderilen mesajlar, taslaklar, spam ve çöp kutusu gibi farklı mesajlaşma klasörlerine erişim için bir menü bulunmaktadır. Ayrıca, kullanıcının mesajlarına etiketler atayabileceği bir bölüm de yer almaktadır.
Sayfanın ana bölümünde ise gelen mesajların bir listesi görülmektedir. Her bir mesaj için gönderenin e-posta adresi, mesajın konusu, kısa bir önizlemesi ve gönderilme tarihi gibi bilgiler listelenmiştir. Kullanıcı, mesajları okuyabilir, işaretleyebilir, silebilir veya farklı klasörlere taşıyabilir. Ayrıca, yeni bir mesaj oluşturmak için "Yeni Mesaj" butonu da bulunmaktadır.
### 5-Giden Mesajlar
![image](https://github.com/user-attachments/assets/bb6c9dc8-6f5a-4156-8acf-1087a418d184)
Bu sayfada kullanıcının "Gönderilen Mesajlar" kutusu görüntülenmektedir. Sol taraftaki menüde, kullanıcının mesajlaşma klasörlerine erişim imkanı devam etmektedir. "Gönderilen Mesajlar" seçeneği aktif olduğu için, kullanıcının daha önce başarıyla gönderdiği tüm mesajlar bu alanda listelenmektedir.
Sayfanın ana bölümünde, gönderilen mesajların bir listesi yer almaktadır. Her bir mesaj için alıcının e-posta adresi, mesajın konusu, kısa bir önizlemesi ve gönderilme tarihi gibi bilgiler gösterilmektedir. Kullanıcı, bu listedeki mesajları görüntüleyebilir. Genellikle gönderilen mesajlar üzerinde düzenleme veya silme gibi işlemler yapılamaz, ancak bu sistemin özelliklerine göre değişebilir. Kullanıcı, yeni bir mesaj göndermek için sol üst köşedeki "Yeni Mesaj" butonunu kullanabilir.
### 6-Yeni Mesaj Gönder
![image](https://github.com/user-attachments/assets/35cd24ac-ff97-4756-8311-639d1bb14fc7)
Bu sayfa, yeni mesaj gönderme alanıdır. Alıcı e-posta adresi "Kime:" bölümüne, mesaj başlığı "Konu:" bölümüne yazılır. Geniş metin kutusuna mesaj içeriği girilir ve üstündeki araçlarla biçimlendirilebilir. Sağ alttaki "Gönder" butonu ile mesaj yollanır.
### 7-Kitap Geçmişi
![image](https://github.com/user-attachments/assets/56f1d126-f89b-4b51-b6c0-b94259fbdb68)
Bu sayfa, kullanıcının "Kitaplarım" bölümüdür. Burada, kullanıcının daha önce ödünç aldığı ve iade ettiği kitapların bir listesi bulunmaktadır. Her bir kitap için adı, alış tarihi ve iade tarihi bilgileri gösterilmektedir. Bu sayede kullanıcı, okuma geçmişini kolayca takip edebilir.
### 8-Duyuru Listesi
![image](https://github.com/user-attachments/assets/f9296625-33d4-4af8-bc44-f5389d5e1bc3)
Bu sayfa, kütüphanenin önemli duyurularının listesidir. Her duyuru başlık, kısa açıklama ve tarihle gösterilir. Kullanıcılar bu alandan güncel bilgilere ulaşabilir.

