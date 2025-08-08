# Kişiye Özel Spor Antrenman Plan Uygulaması
Bir müşteri, birlikte çalıştığı yazılım firmasından kişiye özel bir spor antrenman planı uygulaması
geliştirmesini istemektedir.
Uygulama, kullanıcıların adı, soyadı, doğum tarihi, cinsiyeti ve spor seviyesi (başlangıç, orta, ileri)
bilgilerini almaktadır.
Spor planında, baylar için haftada 7 gün, bayanlar için ise haftada 6 gün program uygulanacaktır.
Kullanıcının yaşına bağlı olarak:
30 yaş altı kullanıcılar için haftada 4 antrenman günü,
30 yaş ve üzerindekiler için haftada 3 antrenman günü önerilecektir.

Kullanıcı, dinamik olarak x gün sonra belirli bir antrenman talebinde bulunacaktır. İlgili yazılım,
kullanıcının bilgilerine göre aşağıdaki formatta bilgi vermelidir:
“Sayın[isim][soyisim], [cinsiyet bilgisine göre bey/hanım][yaş] yaşındasınız. [x]gün
sonrası için planlanan antrenman:[antrenman türü](Kardiyo, Güç Antrenmanı, Esneme veya Dinlenme)olacaktır.”
Antrenman türleri, kullanıcının spor seviyesine göre otomatik olarak önerilecek ve kullanıcı tercihine göre
ayarlanacaktır.
Programda, antrenman günlerinin isimleri 1.gün, 2.gün, 3.gün, ... formatında gösterilecektir.
