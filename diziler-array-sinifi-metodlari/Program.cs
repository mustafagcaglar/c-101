﻿//sort
int[] sayiDizisi ={23,12,4,86,72,3,11,17};

Console.WriteLine("***** Sırasız Dizi *****");
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi); 

Console.WriteLine("***** Sıralı Dizi *****");
Array.Sort(sayiDizisi);

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//clear
Console.WriteLine("***** Array Clear *****");
//sayı dizisi elemanlarını kullanarak 2. indexten itibaren 2 elemanı sıfırlar
Array.Clear(sayiDizisi,2,2);
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//Reverse
Console.WriteLine("***** Array Reverse *****");
Array.Reverse(sayiDizisi);

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//indexof
Console.WriteLine("***** Array Indexof *****");

Console.WriteLine(Array.IndexOf(sayiDizisi,23));

//Resize
Console.WriteLine("***** Array Resize *****");
Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8] = 99;

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);




