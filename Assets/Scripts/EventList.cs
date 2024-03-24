using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventList : MonoBehaviour
{
    public List<List<string>> events = new List<List<string>>()
    {
        new List<string>()
        {
            "Yeni vergiler koymak ak�ll�ca olur. Buradan gelecek para ile acil durum fonu olu�turabiliriz.",
            "Evet olu�tur.",
            "Hay�r, gerek yok",
            "Money",
            "People",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir teknoloji �irketi, �ehirdeki park alanlar�ndan birinde yeni bir ara�t�rma merkezi kurmak istiyor.",
            "�zin ver, bu yenilik getirebilir.",
            "Reddet, do�ay� koru.",
            "Technology",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "�nl� bir sanat��, �ehir meydan�nda �cretsiz bir konser vermek istiyor.",
            "Kabul et, halk mutlu olsun.",
            "Reddet, g�r�lt� kirlili�i yaratmas�n.",
            "People",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup �evreci, end�striyel at�klar�n azalt�lmas� i�in kampanya ba�latmak istiyor.",
            "Destekle, do�ay� koruyal�m.",
            "G�rmezden gel, ekonomiyi etkilemesin.",
            "Nature",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Yabanc� bir yat�r�mc�, �ehirde b�y�k bir al��veri� merkezi a�mak istiyor.",
            "�zin ver, ekonomi canlans�n.",
            "Reddet, k���k i�letmeler zarar g�rmesin.",
            "Money",
            "People",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir bilim insan�, yenilenebilir enerji kaynaklar� �zerine bir proje i�in h�k�met deste�i istiyor.",
            "Destekle, gelece�e yat�r�m yap.",
            "Reddet, b�t�eyi koru.",
            "Technology",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "�ehrin en eski park�n�n yerine yeni bir stadyum yap�lmas� teklif ediliyor.",
            "Kabul et, spor turizmi artar.",
            "Reddet, ye�il alanlar korunsun.",
            "People",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup ��renci, okullarda teknoloji kullan�m�n� art�rmak i�in ba��� kampanyas� ba�latmak istiyor.",
            "Destekle, e�itimi geli�tir.",
            "Reddet, geleneksel y�ntemler yeterli.",
            "People",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "�ehrinizdeki eski bir fabrika alan�n� d�n��t�rmek i�in bir teklif var. Bir yandan tarihi korumak, di�er yandan modern bir ya�am alan� yaratmak aras�nda bir se�im yapman�z gerekiyor.",
            "Tarihi koruyarak turist �ekelim.",
            "Modern bir ya�am alan� yaratal�m ve �ehri yenileyelim.",
            "Nature",
            "People",
            "+",
            "-"
        },
        new List<string>()
        {
            "�ehirdeki ana yollar�n bak�m� i�in b�y�k bir b�t�e ayr�lmas� gerekiyor. Bu, trafik ak���n� iyile�tirecek ancak �ehir b�t�esini s�k�nt�ya sokacak.",
            "Bak�m i�in b�t�eyi onayla.",
            "B�t�eyi ba�ka projelere ay�r.",
            "People",
            "Money",
            "-",
            "+"
        },
        new List<string>()
        {
            "Bir grup yat�r�mc�, �ehrinize y�ksek h�zl� internet altyap�s� kurmak istiyor.",
            "Projeyi destekle, teknolojiyi ilerlet.",
            "Reddet, maliyeti �ok y�ksek.",
            "Technology",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "�ehrinizdeki bir fabrika, at�klar�n� azaltmak i�in yeni bir filtreleme sistemi kurmay� teklif ediyor.",
            "Yat�r�m� destekle, �evreyi koru.",
            "Reddet, fabrikan�n maliyetlerini d���k tut.",
            "Nature",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup giri�imci, �ehirde organik tar�m� te�vik etmek i�in bir pazar yeri a�mak istiyor.",
            "Organik pazar� destekle, sa�l�kl� ya�am� te�vik et.",
            "Reddet, geleneksel pazarlara zarar verebilir.",
            "Nature",
            "People",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir teknoloji firmas�, �ehirdeki trafik sorununu ��zmek i�in ak�ll� trafik ���klar� sistemini kurmay� teklif ediyor.",
            "Projeyi destekle, trafik ak���n� iyile�tir.",
            "Reddet, maliyeti y�ksek.",
            "Technology",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup �ift�i, tar�m arazilerinin geni�letilmesi i�in ormanl�k alan�n bir k�sm�n�n kesilmesini istiyor.",
            "�zin ver, g�da �retimini art�r.",
            "Reddet, ormanlar� koru.",
            "People",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "�ehrinizdeki bir hastane, yeni bir ara�t�rma laboratuvar� a�mak i�in ba��� topluyor.",
            "Ba��� yap, sa�l�k hizmetlerini geli�tir.",
            "Reddet, b�t�eyi ba�ka yerde kullan.",
            "Technology",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir moda tasar�mc�s�, �ehirde uluslararas� bir moda haftas� d�zenlemek istiyor.",
            "Etkinli�i destekle, turizmi canland�r.",
            "Reddet, �ehrin geleneksel dokusunu bozar.",
            "People",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir enerji �irketi, yenilenebilir enerji i�in �ehirde r�zgar t�rbinleri kurmay� planl�yor.",
            "Projeyi destekle, temiz enerji kullan.",
            "Reddet, manzaray� bozar.",
            "Nature",
            "People",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir e�itim kurumu, yeti�kinler i�in �cretsiz e�itim programlar� sunmay� teklif ediyor.",
            "Program� destekle, e�itim seviyesini y�kselt.",
            "Reddet, b�t�eyi s�k�nt�ya sokar.",
            "People",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir otomobil �reticisi, �ehirdeki fabrikas�n� geni�letmek istiyor.",
            "Geni�lemeyi destekle, i� imkanlar� yarat.",
            "Reddet, �evre kirlili�i artar.",
            "Money",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup sanat��, �ehrin duvarlar�n� boyayarak sanat eserleri yaratmak istiyor.",
            "Sanat projesini destekle, �ehri renklendir.",
            "Reddet, d�zensiz g�r�n�r.",
            "People",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir �evre �rg�t�, �ehirdeki plastik kullan�m�n� azaltmak i�in yasaklar getirmek istiyor.",
            "Yasa�� destekle, �evreyi koru.",
            "Reddet, ticareti olumsuz etkiler.",
            "Nature",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir yabanc� dil okulu, �ehirdeki t�m okullarda ikinci dil olarak yeni bir dil program� ba�latmak istiyor.",
            "Program� destekle, �ok dillili�i te�vik et.",
            "Reddet, mevcut diller yeterli.",
            "People",
            "Technology",
            "+",
            "-"
        },
        new List<string>()
        {
            "�ehirdeki �niversite, yeni bir bilim merkezi in�a etmek istiyor, ancak bu, baz� tarihi binalar�n y�k�lmas�n� gerektirecek.",
            "�n�aata izin ver, bilimi destekle.",
            "Reddet, tarihi koru.",
            "Technology",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir giri�imci, �ehirdeki bo� arazilerde organik sebze ve meyve bah�eleri kurmay� teklif ediyor.",
            "Projeyi destekle, sa�l�kl� g�da �ret.",
            "Reddet, arazi ba�ka projeler i�in kullan�ls�n.",
            "Nature",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir film st�dyosu, �ehrinizde b�y�k bir film �ekmek istiyor, ancak bu, uzun s�reli trafik aksamalar�na neden olacak.",
            "�ekime izin ver, �ehri tan�t.",
            "Reddet, g�nl�k ya�am� etkilemesin.",
            "Money",
            "People",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir hayvan haklar� �rg�t�, �ehirdeki hayvanat bah�esinin kapat�lmas�n� ve hayvanlar�n do�al habitatlar�na geri g�nderilmesini istiyor.",
            "Kapatmay� destekle, hayvan haklar�n� koru.",
            "Reddet, turistik cazibe merkezidir.",
            "Nature",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir teknoloji start-up'�, �ehirdeki herkese �cretsiz Wi-Fi hizmeti sunmay� teklif ediyor, ancak bu, belediyenin b�t�esinden �nemli bir yat�r�m gerektiriyor.",
            "�cretsiz Wi-Fi'yi destekle, eri�imi art�r.",
            "Reddet, maliyeti �ok fazla.",
            "Technology",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup mimar, �ehrin eski binalar�n� modern sanat eserlerine d�n��t�rmek istiyor.",
            "D�n���m� destekle, �ehri yenile.",
            "Reddet, tarihi dokuyu koru.",
            "Technology",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir spor federasyonu, gen�ler i�in �ehir genelinde spor tesisleri kurmay� �neriyor.",
            "Tesisleri destekle, gen�leri te�vik et.",
            "Reddet, b�t�eyi ba�ka yerde kullan.",
            "People",
            "Money",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir yat�r�m �irketi, �ehirdeki eski bir fabrikay� teknoloji kamp�s�ne d�n��t�rmek istiyor.",
            "D�n���m� destekle, inovasyonu te�vik et.",
            "Reddet, tarihi dokuyu koru.",
            "Technology",
            "Nature",
            "+",
            "-"
        },
        new List<string>()
        {
            "Bir grup vatanda�, �ehir merkezindeki trafi�i azaltmak i�in bisiklet yollar� yap�lmas�n� istiyor.",
            "Bisiklet yollar�n� yap, sa�l�kl� ya�am� destekle.",
            "Reddet, maliyeti y�ksek.",
            "Nature",
            "Money",
            "+",
            "-"
        }
    };


}
