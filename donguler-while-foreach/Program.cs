﻿//While
//1 den başlayarak konsoldan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program
Console.WriteLine("Lütfen bir sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;
while (sayac <= sayi)
{
    toplam += sayac;
    sayac ++;
}

Console.WriteLine(toplam/sayi);

// 'a' dan 'z' ye kadar tüm harfleri console a yazdır.
char character = 'a';
while (character < 'z')
{
    Console.Write(character);
    character ++;
}

Console.Write("***** Foreach ******");
string[] arabalar = {"bmw", "ford", "toyota", "nissan"};
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}