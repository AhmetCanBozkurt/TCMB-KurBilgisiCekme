# TCMB Kur Bilgisi Çekme DLL

Bu proje, Türkiye Cumhuriyet Merkez Bankası'nın (TCMB) API üzerinden döviz kuru bilgilerini çekmenizi sağlayan bir sınıf içerir. `GetKur` sınıfı, XML formatında yayımlanan günlük döviz kuru verilerini alır ve dolar ile euro'nun alış ve satış fiyatlarını döndürür.

## Özellikler

- TCMB'nin günlük döviz kuru verilerini XML formatında çeker.
- Dolar ve Euro'nun alış ve satış fiyatlarını döndürür.
- Kur bilgileri bir `decimal` dizisi içinde döndürülür.

## Kullanım

1. **GetKur** sınıfını projenize dahil edin.
2. `GetKur` sınıfının **GetKurList** metodunu çağırarak TCMB'den döviz kuru bilgilerini alın.
3. Döviz kuru bilgileri, alış ve satış fiyatları olarak sırasıyla bir dizi içinde döndürülür.

### Örnek Kullanım

```csharp
using TCMBKurBilgisCekme;

class Program
{
    static void Main()
    {
        GetKur getKur = new GetKur();
        decimal[] kurListesi = getKur.GetKurList();

        // Dolar alış ve satış fiyatları
        decimal dolarAlis = kurListesi[0];
        decimal dolarSatis = kurListesi[1];

        // Euro alış ve satış fiyatları
        decimal euroAlis = kurListesi[2];
        decimal euroSatis = kurListesi[3];

        // Fiyatları ekrana yazdır
        Console.WriteLine($"Dolar Alış: {dolarAlis} TL");
        Console.WriteLine($"Dolar Satış: {dolarSatis} TL");
        Console.WriteLine($"Euro Alış: {euroAlis} TL");
        Console.WriteLine($"Euro Satış: {euroSatis} TL");
    }
}
