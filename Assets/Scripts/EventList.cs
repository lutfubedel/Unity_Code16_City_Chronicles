using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventList : MonoBehaviour
{
    public List<List<string>> events = new List<List<string>>()
    {
        new List<string>()
        {
            "Yeni vergiler koymak akýllýca olur. Buradan gelecek para ile acil durum fonu oluþturabiliriz.",
            "Evet oluþtur.",
            "Hayýr, gerek yok",
            "Money",
            "People",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir teknoloji þirketi, þehirdeki park alanlarýndan birinde yeni bir araþtýrma merkezi kurmak istiyor.",
            "Ýzin ver, bu yenilik getirebilir.",
            "Reddet, doðayý koru.",
            "Technology",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Ünlü bir sanatçý, þehir meydanýnda ücretsiz bir konser vermek istiyor.",
            "Kabul et, halk mutlu olsun.",
            "Reddet, gürültü kirliliði yaratmasýn.",
            "People",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup çevreci, endüstriyel atýklarýn azaltýlmasý için kampanya baþlatmak istiyor.",
            "Destekle, doðayý koruyalým.",
            "Görmezden gel, ekonomiyi etkilemesin.",
            "Nature",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Yabancý bir yatýrýmcý, þehirde büyük bir alýþveriþ merkezi açmak istiyor.",
            "Ýzin ver, ekonomi canlansýn.",
            "Reddet, küçük iþletmeler zarar görmesin.",
            "Money",
            "People",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir bilim insaný, yenilenebilir enerji kaynaklarý üzerine bir proje için hükümet desteði istiyor.",
            "Destekle, geleceðe yatýrým yap.",
            "Reddet, bütçeyi koru.",
            "Technology",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Þehrin en eski parkýnýn yerine yeni bir stadyum yapýlmasý teklif ediliyor.",
            "Kabul et, spor turizmi artar.",
            "Reddet, yeþil alanlar korunsun.",
            "People",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup öðrenci, okullarda teknoloji kullanýmýný artýrmak için baðýþ kampanyasý baþlatmak istiyor.",
            "Destekle, eðitimi geliþtir.",
            "Reddet, geleneksel yöntemler yeterli.",
            "People",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Þehrinizdeki eski bir fabrika alanýný dönüþtürmek için bir teklif var. Bir yandan tarihi korumak, diðer yandan modern bir yaþam alaný yaratmak arasýnda bir seçim yapmanýz gerekiyor.",
            "Tarihi koruyarak turist çekelim.",
            "Modern bir yaþam alaný yaratalým ve þehri yenileyelim.",
            "Nature",
            "People",
            "+",
            "-"
        },
        new List<string>()
        {
            "Þehirdeki ana yollarýn bakýmý için büyük bir bütçe ayrýlmasý gerekiyor. Bu, trafik akýþýný iyileþtirecek ancak þehir bütçesini sýkýntýya sokacak.",
            "Bakým için bütçeyi onayla.",
            "Bütçeyi baþka projelere ayýr.",
            "People",
            "Money",
            "-",
            "+"
        },
        new List<string>()
        {
            "Bir grup yatýrýmcý, þehrinize yüksek hýzlý internet altyapýsý kurmak istiyor.",
            "Projeyi destekle, teknolojiyi ilerlet.",
            "Reddet, maliyeti çok yüksek.",
            "Technology",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Þehrinizdeki bir fabrika, atýklarýný azaltmak için yeni bir filtreleme sistemi kurmayý teklif ediyor.",
            "Yatýrýmý destekle, çevreyi koru.",
            "Reddet, fabrikanýn maliyetlerini düþük tut.",
            "Nature",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup giriþimci, þehirde organik tarýmý teþvik etmek için bir pazar yeri açmak istiyor.",
            "Organik pazarý destekle, saðlýklý yaþamý teþvik et.",
            "Reddet, geleneksel pazarlara zarar verebilir.",
            "Nature",
            "People",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir teknoloji firmasý, þehirdeki trafik sorununu çözmek için akýllý trafik ýþýklarý sistemini kurmayý teklif ediyor.",
            "Projeyi destekle, trafik akýþýný iyileþtir.",
            "Reddet, maliyeti yüksek.",
            "Technology",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup çiftçi, tarým arazilerinin geniþletilmesi için ormanlýk alanýn bir kýsmýnýn kesilmesini istiyor.",
            "Ýzin ver, gýda üretimini artýr.",
            "Reddet, ormanlarý koru.",
            "People",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Þehrinizdeki bir hastane, yeni bir araþtýrma laboratuvarý açmak için baðýþ topluyor.",
            "Baðýþ yap, saðlýk hizmetlerini geliþtir.",
            "Reddet, bütçeyi baþka yerde kullan.",
            "Technology",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir moda tasarýmcýsý, þehirde uluslararasý bir moda haftasý düzenlemek istiyor.",
            "Etkinliði destekle, turizmi canlandýr.",
            "Reddet, þehrin geleneksel dokusunu bozar.",
            "People",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir enerji þirketi, yenilenebilir enerji için þehirde rüzgar türbinleri kurmayý planlýyor.",
            "Projeyi destekle, temiz enerji kullan.",
            "Reddet, manzarayý bozar.",
            "Nature",
            "People",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir eðitim kurumu, yetiþkinler için ücretsiz eðitim programlarý sunmayý teklif ediyor.",
            "Programý destekle, eðitim seviyesini yükselt.",
            "Reddet, bütçeyi sýkýntýya sokar.",
            "People",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir otomobil üreticisi, þehirdeki fabrikasýný geniþletmek istiyor.",
            "Geniþlemeyi destekle, iþ imkanlarý yarat.",
            "Reddet, çevre kirliliði artar.",
            "Money",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup sanatçý, þehrin duvarlarýný boyayarak sanat eserleri yaratmak istiyor.",
            "Sanat projesini destekle, þehri renklendir.",
            "Reddet, düzensiz görünür.",
            "People",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir çevre örgütü, þehirdeki plastik kullanýmýný azaltmak için yasaklar getirmek istiyor.",
            "Yasaðý destekle, çevreyi koru.",
            "Reddet, ticareti olumsuz etkiler.",
            "Nature",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir yabancý dil okulu, þehirdeki tüm okullarda ikinci dil olarak yeni bir dil programý baþlatmak istiyor.",
            "Programý destekle, çok dilliliði teþvik et.",
            "Reddet, mevcut diller yeterli.",
            "People",
            "Technology",
            "+",
            "-"
        },
        new List<string>()
        {
            "Þehirdeki üniversite, yeni bir bilim merkezi inþa etmek istiyor, ancak bu, bazý tarihi binalarýn yýkýlmasýný gerektirecek.",
            "Ýnþaata izin ver, bilimi destekle.",
            "Reddet, tarihi koru.",
            "Technology",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir giriþimci, þehirdeki boþ arazilerde organik sebze ve meyve bahçeleri kurmayý teklif ediyor.",
            "Projeyi destekle, saðlýklý gýda üret.",
            "Reddet, arazi baþka projeler için kullanýlsýn.",
            "Nature",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir film stüdyosu, þehrinizde büyük bir film çekmek istiyor, ancak bu, uzun süreli trafik aksamalarýna neden olacak.",
            "Çekime izin ver, þehri tanýt.",
            "Reddet, günlük yaþamý etkilemesin.",
            "Money",
            "People",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir hayvan haklarý örgütü, þehirdeki hayvanat bahçesinin kapatýlmasýný ve hayvanlarýn doðal habitatlarýna geri gönderilmesini istiyor.",
            "Kapatmayý destekle, hayvan haklarýný koru.",
            "Reddet, turistik cazibe merkezidir.",
            "Nature",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir teknoloji start-up'ý, þehirdeki herkese ücretsiz Wi-Fi hizmeti sunmayý teklif ediyor, ancak bu, belediyenin bütçesinden önemli bir yatýrým gerektiriyor.",
            "Ücretsiz Wi-Fi'yi destekle, eriþimi artýr.",
            "Reddet, maliyeti çok fazla.",
            "Technology",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup mimar, þehrin eski binalarýný modern sanat eserlerine dönüþtürmek istiyor.",
            "Dönüþümü destekle, þehri yenile.",
            "Reddet, tarihi dokuyu koru.",
            "Technology",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir spor federasyonu, gençler için þehir genelinde spor tesisleri kurmayý öneriyor.",
            "Tesisleri destekle, gençleri teþvik et.",
            "Reddet, bütçeyi baþka yerde kullan.",
            "People",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir yatýrým þirketi, þehirdeki eski bir fabrikayý teknoloji kampüsüne dönüþtürmek istiyor.",
            "Dönüþümü destekle, inovasyonu teþvik et.",
            "Reddet, tarihi dokuyu koru.",
            "Technology",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup vatandaþ, þehir merkezindeki trafiði azaltmak için bisiklet yollarý yapýlmasýný istiyor.",
            "Bisiklet yollarýný yap, saðlýklý yaþamý destekle.",
            "Reddet, maliyeti yüksek.",
            "Nature",
            "Money",
            "+",
            "-"
        }
    };


}
