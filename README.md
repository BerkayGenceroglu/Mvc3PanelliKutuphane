# 📚 MvcKutuphane - ASP.NET MVC Tabalı Panelli Kütüphane Yönetim Sistemi
MvcKutuphane, ASP.NET MVC ile geliştirilmiş bir kütüphane yönetim sistemi uygulamasıdır. Uygulama, admin paneli aracılığıyla kitaplar, kategoriler ve kullanıcıları yönetmeyi sağlar. Ayrıca, misafir paneli üzerinden kullanıcılar sisteme giriş yapmadan kütüphanedeki 
kitaplara göz atabilir, kitapları arayabilir ve kategorilere göz atabilirler. Kullanıcı paneli ise giriş yapan kullanıcıların kitaplara yorum yapmasına veya favorilere eklemesine olanak tanır.
Aşağıda, her bir sayfayı ve fonksiyonalitesini detaylı bir şekilde açıklayarak proje hakkında daha fazla bilgi bulabilirsiniz.
A)ADMİN PANELİ
1.Admin Yönetim Paneli Girişi
![image](https://github.com/user-attachments/assets/1fc08681-21ad-4eab-a4fa-15c250f1de14)
Bu sayfa, uygulamanın yönetim paneline erişim sağlamak için kullanılır. Yetkili kullanıcılar, bu form aracılığıyla kullanıcı adı ve şifrelerini girerek sistemin yönetim arayüzüne giriş yapabilirler.
2.Ana Sayfa
![image](https://github.com/user-attachments/assets/eae67ebe-f807-4429-9b05-8f96ca5ac7bf)
Bu sayfa, Kütüphane Yönetim Sistemi'nin kullanıcı girişinden sonra karşılaşılan ilk ekranıdır. Sistem hakkında genel bir bakış sunar ve kullanıcılara temel işlevlere hızlı erişim imkanı tanır.
3.Kategori Listesi
![image](https://github.com/user-attachments/assets/6a753f7b-617d-4055-8010-a535bd923b5b)
Bu sayfa aracılığıyla yöneticiler aşağıdaki işlemleri gerçekleştirebilir:
-Yeni Kategori Ekleme: Sisteme yeni kitap kategorileri tanımlayabilirler.
-Kategori Silme: Mevcut kategorileri sistemden silebilirler (dikkatli olunmalıdır, çünkü bu kategoriye bağlı kitaplar da etkilenebilir).
-Kategori Güncelleme: Mevcut kategorilerin adlarını veya diğer ilgili bilgilerini düzenleyebilirler.
4.Kitap Listesi
![image](https://github.com/user-attachments/assets/b5d2d92d-b47d-4bd6-9e83-5c54de736de6)
Bu sayfa, kütüphanedeki tüm kayıtlı kitapların bir listesini sunar ve bu kitapların yönetilmesine olanak tanır. Kullanıcılar bu sayfa üzerinden kitap bilgilerini görüntüleyebilir, yeni kitap ekleyebilir, mevcut kitapları silebilir veya güncelleyebilirler. Ayrıca, her bir kitabın kütüphanedeki mevcut durumu hakkında da bilgi sahibi olabilirler.
5.Yazar Listesi
![image](https://github.com/user-attachments/assets/912db8fe-7444-490b-b2a3-2044f308d87f)
![image](https://github.com/user-attachments/assets/503a3801-65ad-45e2-aeb7-e5f90fbb13cd)
Bu sayfa, sistemde kayıtlı olan tüm yazarların bir listesini görüntüler ve yazarların yönetilmesine olanak tanır. Listelenen yazarların her birinin yanında bulunan "Kitaplar" bağlantısına tıklayarak, o yazara ait kütüphanede bulunan tüm kitaplara kolayca erişilebilir. Kütüphanedeki kitapların yazarlarına göre düzenlenmesi ve yönetilmesi için önemli bir araçtır.
6.Üye Listesi
![image](https://github.com/user-attachments/assets/68467aa7-b15e-40b5-bef4-e98df5bf0121)
![image](https://github.com/user-attachments/assets/c40e7e57-4b5d-4b7e-9bb2-66b520fe5815)
Bu sayfa, kütüphaneye kayıtlı olan tüm üyelerin bir listesini görüntüler ve üye kayıtlarının yönetilmesine olanak tanır. Kütüphane kullanıcılarının bilgilerinin takip edilmesi ve yönetilmesi için temel bir araçtır.Ayrıca Kullanıcılar Kitap Geçmişi 
butonuna tıklayarak,listedeki her bir üyenin kütüphanedeki ödünç alma ve iade geçmişine ulaşabilirler.
7.Personel Listesi
![image](https://github.com/user-attachments/assets/e935a8f0-392a-4f73-abb2-f0163a972eea)
Bu sayfa, Kütüphane Yönetim Sistemi'nde kayıtlı personellerin ID ve ad gibi temel bilgilerini listeleyen, her bir kayıt için silme ve güncelleme işlemlerini mümkün kılan, aynı zamanda yeni personel ekleme işlevselliğini sağlayan temel bir personel yönetim ekranıdır.
8.Kitap Ödünç Verme
![image](https://github.com/user-attachments/assets/1c8a783b-20d6-430d-9419-3d280e96cf59)
Bu sayfa, Kütüphane Yönetim Sistemi'nde kitap ödünç verme işleminin gerçekleştirildiği arayüzdür. Üye Adı, Kitap Adı, Personel Adı, Alış Tarihi ve İade Tarihi gibi ödünç verme işlemine ait bilgilerin girildiği alanları içerir ve "İşlemi Gerçekleştir" butonu aracılığıyla ödünç verme işlemini tamamlar.
9.Ödünç Verilmiş Kitap Listesi
![image](https://github.com/user-attachments/assets/df5fb0a1-9caf-4c52-abe1-66e808bf92ed)
Bu sayfa, Kütüphane Yönetim Sistemi'nde ödünç verilmiş kitapların listesini sunmaktadır. Tabloda İşlem ID, Kitap Adı, Üye Adı, Personel Adı, Alış Tarihi, İade Tarihi ve "Kitabı İade Al" butonu gibi ödünç verme işlemlerine ait detaylar yer almaktadır. "Kitabı İade Al" butonu aracılığıyla ödünçteki kitapların sisteme iade kaydı gerçekleştirilebilir.
10.Duyuru Listesi
![image](https://github.com/user-attachments/assets/f9f81994-b3c9-423d-b3e6-fc5c68c3511b)
Bu sayfa, Kütüphane Yönetim Sistemi'nde yayınlanan duyuruların özetini tablo halinde sunar; duyuru numarası, kategorisi, içeriği ve tarihi gibi bilgileri gösterir. Ayrıca, mevcut duyuruları silme ve güncelleme işlevlerinin yanı sıra, yeni duyurular oluşturma imkanı da sağlar.
11.İadesi Alınan Kitap Listesi
![image](https://github.com/user-attachments/assets/dbd15969-f65f-44c3-9dae-18dad8977455)
![image](https://github.com/user-attachments/assets/84e07a95-de01-474f-bdb3-c738724c0037)
Bu sayfa, Kütüphane Yönetim Sistemi'nde iadesi gerçekleşmiş kitapların kayıtlarını özet olarak sunar. Her bir kitap iadesine ait temel bilgilerin yanı sıra, "Detaylar" butonu aracılığıyla kitabın ödünç alınma ve iade süreçlerine dair daha fazla bilgiye erişilebilir, 
bu sayede kitabın zamanında iade edilip edilmediği ve iade edilmediyse kaç gün geciktiği kontrol edilebilir .
12.İstatistik Bilgileri 
![image](https://github.com/user-attachments/assets/b8b1e3d4-b04f-4bc0-89cc-5f8575da2888)
Bu sayfa, Kütüphane Yönetim Sistemi'nin genel istatistiklerini ve bazı temel yönetim araçlarını bir arada sunan bir gösterge panosudur. En üst kısımda dört adet temel istatistik kartı yer almaktadır:
$ 7,00 TL yazan yeşil kart, sistemdeki toplam ceza tutarını göstermektedir.
11 yazan pembe kart, sistemdeki toplam üye sayısını ifade etmektedir.
27 yazan mavi kart, kütüphanedeki toplam kitap sayısını belirtmektedir.
2 yazan lacivert kart ise, şu anda emanet verilmiş olan kitap sayısını göstermektedir.
Sayfanın geri kalanında yer alan çeşitli grafikler, dünya haritası ve listeler gibi istatistiksel gösterimler ise, bu temel bilgileri görsel olarak desteklemek ve sayfaya estetik bir görünüm katmak amacıyla eklenmiştir
13.Linq Kartlar 
![image](https://github.com/user-attachments/assets/ee6cf362-7308-44ab-9161-db4dde93ffd0)
Bu sayfa, Kütüphane Yönetim Sistemi'nin çeşitli önemli istatistiklerini ve temel performans göstergelerini kolayca takip edilebilmesi için kartlar aracılığıyla görselleştirmektedir. Kullanıcılara toplam kitap sayısı, kayıtlı üye sayısı, tahsil edilen ceza tutarı, şu anda ödünçte olan kitap sayısı gibi temel bilgilerin yanı sıra, en aktif kullanıcı, en çok okunan kitap ve en başarılı personel gibi daha detaylı analizleri hızlı bir şekilde sunarak sistem hakkında kapsamlı bir genel bakış sağlar.
14.Kütüphane Fotoğrafları
![image](https://github.com/user-attachments/assets/b6d8a903-bf5f-4d82-8917-6b89b5ffe44b)
Bu sayfa, Kütüphane Yönetim Sistemi'nin fotoğraf bölümüdür. Kütüphane fotoğrafı gösterilir ve yeni fotoğraf yüklemek için "Dosya Seç" butonu bulunur.
15.Hava Durumu
![image](https://github.com/user-attachments/assets/6b7957eb-c301-44f9-a058-766588ced898)
Bu sayfa, Kütüphane Yönetim Sistemi'nin "Hava Durumu" bölümüdür. İstanbul için 6 Mayıs 2025 tarihli örnek hava durumu bilgilerini görsel bir kartta sunmaktadır. Bu bilgiler gerçeği yansıtmayıp, sayfanın görünümünü zenginleştirmek için kullanılmıştır.
16.Hava Kartları
![image](https://github.com/user-attachments/assets/bbe031b4-c486-46a3-96a1-536b15767086)
Bu sayfa, Kütüphane Yönetim Sistemi kullanıcılarına Türkiye'nin farklı şehirlerindeki (İstanbul, Ankara, İzmir, Antalya, Sinop, Elazığ, Van) doğru ve güncel hava durumu bilgilerini detaylı bir şekilde sunmaktadır. Her bir şehir için mevcut hava durumu ikonu, sıcaklık değeri ve kısa bir açıklama yer alırken, takip eden günlere ait sıcaklık tahminleri de ayrı ayrı gösterilmektedir. 
17.Grafik
![image](https://github.com/user-attachments/assets/038170c3-fb19-4304-9c5b-18fb462dc6e0)
Bu sayfa, Kütüphane Yönetim Sistemi'ndeki kitapların yayınevlerine göre yüzdesel dağılımını gösteren bir daire grafiğidir. Her renk bir yayınevini temsil eder ve dilimin büyüklüğü o yayınevinin kitap oranını ifade eder.
18.Yardım
![image](https://github.com/user-attachments/assets/63678e78-b282-4fbf-8210-e6eed714c7b5)
Bu sayfa, Kütüphane Yönetim Sistemi'nin "Yardım Sayfası"dır. Kullanıcılara üye kaydı, kitap arama, kitap ödünç alma ve iade süresi gibi sıkça sorulan soruların kısa cevaplarını sunar. Ayrıca, daha fazla destek için "Bize Ulaşın" butonu içerir.
Bu sayfa, Kütüphane Yönetim Sistemi'nin "Yardım Sayfası"dır. Kullanıcılara üye kaydı, kitap arama, kitap ödünç alma ve iade süresi gibi sıkça sorulan soruların kısa cevaplarını sunar. Ayrıca, daha fazla destek için "Bize Ulaşın" butonu içerir.
B)MİSAFİR(VİTRİN) PANELİ
1.Kütüphane Anasasayfa
![image](https://github.com/user-attachments/assets/73d3a0e7-b011-4cf0-a656-8666b3bb2cb1)
Bu sayfa, "MVC 5 İLE KÜTÜPHANE SİSTEMİ" adlı uygulamanın kullanıcıları karşılayan ilk sayfadır. Sayfanın üst kısmında temel navigasyon bağlantıları bulunmaktadır. Ekranda kullanıcıyı karşılayan ana mesaj ve görsel öğeler yer almaktadır
2.Kitaplar
![image](https://github.com/user-attachments/assets/ed5c4014-485b-496d-9553-bef1a21d343e)
![image](https://github.com/user-attachments/assets/5b1734a3-5549-4e05-b8bf-7197e38c1bbc)
![image](https://github.com/user-attachments/assets/a53278df-efa1-4afa-a334-9c7e211fb0af)
Bu sayfa, "MVC 5 İLE KÜTÜPHANE SİSTEMİ" projemize ait kitapların sergilendiği "KİTAPLARIMIZ" bölümünü göstermektedir. Bu bölümde, kütüphanemizde bulunan çeşitli kitapların kapak görselleri listelenmektedir. Her bir kitap görseli, 
kullanıcılara kütüphanemizin zengin içeriği hakkında bir fikir vermeyi amaçlamaktadır. Bu listeleme sayesinde kullanıcılar, kütüphanemizde bulunan farklı tür ve yazarlara ait kitapları kolayca keşfedebilirler.
3.Hakkımızda
![image](https://github.com/user-attachments/assets/1f07aad1-24c1-45ba-8c2d-72c5b7a6684b)
Bu bölüm, "MVC 5 İLE KÜTÜPHANE SİSTEMİ" projesinin "Hakkımızda" kısmını sunmaktadır. Burada, projenin geliştirilmesinde kullanılan teknolojiler, temel amaçları ve sunduğu ana özellikler anlatılmaktadır. Hem kullanıcı hem de yönetici tarafına yönelik modüllerin işlevleri ve projenin genel yapısı hakkında bilgi verilmektedir.
4.İletişim
![image](https://github.com/user-attachments/assets/07de3f4b-d20c-41f8-a01d-4a1249916cc5)
Bu ekran, "MVC 5 İLE KÜTÜPHANE SİSTEMİ" uygulamasının iletişim sayfasıdır. Kullanıcıların ad, soyad, e-posta, konu ve mesajlarını girerek sistem yöneticileriyle iletişim kurmasını sağlayan bir form içerir. "Gönder" butonu ile mesaj iletilir.
5.Uygulama Footer Bilgisi
![image](https://github.com/user-attachments/assets/598167fe-825b-4bfb-8a1e-d841159ccd2c)
Bu kısım, "MVC 5 İLE KÜTÜPHANE SİSTEMİ" uygulamasının altındaki iletişim (adres, sosyal medya) ve teknik (MVC5, Bootstrap) bilgileri ile telif hakkını özetler.
C)ÜYE PANELİ 
1.Kayıt Paneli
![image](https://github.com/user-attachments/assets/be998568-9b11-4ccf-8053-8c45d30467bc)
Bu sayfa, "MVC5 KÜTÜPHANE YÖNETİM SİSTEMİ" için bir kayıt sayfasıdır. Sol tarafta hoş geldiniz mesajı ve kayıt olma talimatları ile oturum açma/siteye dönme butonları bulunur. Sağda ise ad, soyad, e-posta, kullanıcı adı, şifre, telefon ve okul bilgisi isteyen bir kayıt formu ile şartları kabul etme onay kutusu ve "Kayıt Ol" butonu yer alır ve bu butona tıklandığında üye kaydı oluşturulur.
2.Oturum Açma Paneli
![image](https://github.com/user-attachments/assets/a9d118ac-787f-4601-8676-47c810d0a3bc)
 bu sayfa bir web uygulamasının giriş yapma (login) sayfasıdır. Kütüphane sistemine erişmek için e-posta adresinizi ve şifrenizi ilgili alanlara girmeniz ve ardından "GİRİŞ YAP" butonuna tıklamanız gerekmektedir. Eğer hesabınız yoksa, "KAYIT OL" bağlantısını kullanarak yeni bir hesap oluşturabilirsiniz. Şifrenizi unuttuysanız, "Şifremi Unuttum?" bağlantısını kullanabilirsiniz.
3.Profil Bilgileri
![image](https://github.com/user-attachments/assets/6e9f040c-46a4-49a5-80ce-c6d726552297)
Bu sayfada, "Salih Demir" adlı kullanıcının üyelik bilgileri bulunmaktadır. Sol tarafta kullanıcının profil fotoğrafı, adı, soyadı ve üyelik durumu özetlenmiştir. Ayrıca kullanıcının okuduğu kitap sayısı, gelen kutusundaki mesaj sayısı ve duyuru sayısı gibi bilgilere de yer verilmiştir.
Sayfanın sağ tarafında ise kullanıcının kişisel bilgileri detaylı olarak listelenmektedir. Bu bilgiler arasında adı, soyadı, kullanıcı adı, şifresi, fotoğrafının bağlantısı, okuduğu okul ve e-posta adresi bulunmaktadır. Kullanıcı, bu bilgileri güncelleyebilir ve değişiklikleri kaydedebilir. Ayrıca, gelen kutusuna gitmek için bir buton da mevcuttur.
Özetle, bu sayfa kullanıcının profilini ve kişisel bilgilerini görüntülemesine ve güncellemesine olanak tanır.
4.Gelen Mesajlar
![image](https://github.com/user-attachments/assets/8a010169-b79e-471a-a990-c51ba13b2eb6)
Elbette, bu bölümü de benzer şekilde açıklayabilirim:
Bu sayfada kullanıcının "Gelen Kutusu" görüntülenmektedir. Sol tarafta, gelen kutusu, gönderilen mesajlar, taslaklar, spam ve çöp kutusu gibi farklı mesajlaşma klasörlerine erişim için bir menü bulunmaktadır. Ayrıca, kullanıcının mesajlarına etiketler atayabileceği bir bölüm de yer almaktadır.
Sayfanın ana bölümünde ise gelen mesajların bir listesi görülmektedir. Her bir mesaj için gönderenin e-posta adresi, mesajın konusu, kısa bir önizlemesi ve gönderilme tarihi gibi bilgiler listelenmiştir. Kullanıcı, mesajları okuyabilir, işaretleyebilir, silebilir veya farklı klasörlere taşıyabilir. Ayrıca, yeni bir mesaj oluşturmak için "Yeni Mesaj" butonu da bulunmaktadır.
5-Giden Mesajlar
Bu sayfada kullanıcının "Gönderilen Mesajlar" kutusu görüntülenmektedir. Sol taraftaki menüde, kullanıcının mesajlaşma klasörlerine erişim imkanı devam etmektedir. "Gönderilen Mesajlar" seçeneği aktif olduğu için, kullanıcının daha önce başarıyla gönderdiği tüm mesajlar bu alanda listelenmektedir.
Sayfanın ana bölümünde, gönderilen mesajların bir listesi yer almaktadır. Her bir mesaj için alıcının e-posta adresi, mesajın konusu, kısa bir önizlemesi ve gönderilme tarihi gibi bilgiler gösterilmektedir. Kullanıcı, bu listedeki mesajları görüntüleyebilir. Genellikle gönderilen mesajlar üzerinde düzenleme veya silme gibi işlemler yapılamaz, ancak bu sistemin özelliklerine göre değişebilir. Kullanıcı, yeni bir mesaj göndermek için sol üst köşedeki "Yeni Mesaj" butonunu kullanabilir.
6-Yeni Mesaj Gönder
![image](https://github.com/user-attachments/assets/35cd24ac-ff97-4756-8311-639d1bb14fc7)
Bu sayfa, yeni mesaj gönderme alanıdır. Alıcı e-posta adresi "Kime:" bölümüne, mesaj başlığı "Konu:" bölümüne yazılır. Geniş metin kutusuna mesaj içeriği girilir ve üstündeki araçlarla biçimlendirilebilir. Sağ alttaki "Gönder" butonu ile mesaj yollanır.
7-Kitap Geçmişi
![image](https://github.com/user-attachments/assets/56f1d126-f89b-4b51-b6c0-b94259fbdb68)
Bu sayfa, kullanıcının "Kitaplarım" bölümüdür. Burada, kullanıcının daha önce ödünç aldığı ve iade ettiği kitapların bir listesi bulunmaktadır. Her bir kitap için adı, alış tarihi ve iade tarihi bilgileri gösterilmektedir. Bu sayede kullanıcı, okuma geçmişini kolayca takip edebilir.
8-Duyuru Listesi
![image](https://github.com/user-attachments/assets/f9296625-33d4-4af8-bc44-f5389d5e1bc3)
Bu sayfa, kütüphanenin önemli duyurularının listesidir. Her duyuru başlık, kısa açıklama ve tarihle gösterilir. Kullanıcılar bu alandan güncel bilgilere ulaşabilir.



