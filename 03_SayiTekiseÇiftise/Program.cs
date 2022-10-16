// SORU: sayı girilsin 2 ye bölünüyorsa bölünsün yoksa 3 ile çarpılıp 1 eklensin. sayı degeri 1 olunca dursun kaç adımda 1 olduğu ve max aldıgı deger yazılsın

Console.Write("Bir tam sayı giriniz");

int sayi1 = Convert.ToInt32(Console.ReadLine()),i= 1,y=1, maxDeger,sayi;
sayi = sayi1;
maxDeger = sayi;


while (true)
{

    if (sayi % 2 == 1)
    { 
        sayi = sayi * 3 + 1;
    
    }
    if (maxDeger < sayi)
    {
        maxDeger = sayi;
    }
    if (sayi % 2 == 0)
    {
        sayi = sayi / 2;
         }

    i++;

    if (sayi == 1)
        break;
    

} 


Console.WriteLine("Girdiğiniz {0} sayısı belirtilen işlemlerle {1} adımda 1 değerine ulaşmıştır. {2} sayınızın işlemler arasında aldığı maksimum değerdir.", sayi1, i, maxDeger);
Console.Read();
