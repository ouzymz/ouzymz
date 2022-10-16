
/*Smith Sayısı nedir? 1 den büyük asal olmayan bir tamsayının rakamlarının toplamı, sayı asal 
 * çarpanlarına ayrılarak yazıldığında bu yazılışta bulunan tüm asal 
 * sayıların rakamlarının toplamına eşit oluyorsa bu tür sayılara Smith sayısı denir.
 */


Console.WriteLine("Lütfen bir sayı giriniz");

int sayi = int.Parse(Console.ReadLine());
int sayiSabit = sayi;
int basamakToplami(int input)
{
    int sum = 0;
    while (input > 0)
    {
        sum += (input % 10);
        input = input / 10;
    }
        return sum;
}

var bolenler = new List<int>();

for (int i = 2; i < Math.Sqrt(sayi); i++)
{

    while (sayi % i == 0)
    {
        sayi /= i;
        bolenler.Add(i);
    }

}

if (sayi != 1)
    bolenler.Add(sayi);

int toplam = 0;

for (int i = 0; i < bolenler.Count; i++)
{
    toplam += basamakToplami(bolenler[i]);
}

if (basamakToplami(sayiSabit) == toplam)
    Console.WriteLine($"Girilen sayi {sayiSabit} Smith sayisidir");
else
    Console.WriteLine($"Girilen sayi {sayiSabit} Smith sayisi degildir");
Console.ReadLine();