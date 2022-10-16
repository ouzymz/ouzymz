

Console.WriteLine("Lütfen sayıyı giriniz");

int sayi = Convert.ToInt32(Console.ReadLine());
int basamak = 1, sayiIslem = sayi;

while (sayiIslem > 1)
{
    basamak += 1;
    sayiIslem /= 10;
}

int[] basamaklar = new int[basamak];
int[] fakToplam = new int[basamak];

for (int i = 0; i < basamak; i++)
{
    basamaklar[i] = sayi % 10;
    sayi = sayi / 10;
    fakToplam[i] = 1;

    for (int y = 1; y <= basamaklar[i]; y++)
    {
        fakToplam[i] *= y;
    }

}

int total = fakToplam.Sum();

Console.WriteLine(total);
Console.ReadLine();

*/