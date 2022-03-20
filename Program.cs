using System;
namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";

            //Length=kaç harf var
            Console.WriteLine(degisken.Length);

            //ToUpper ToLower=tüm karakterler büyük/küçük harf
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat= string ekleme
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            //Compare CompareTo= karşılaştırma
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            //Contains =içeriyor mu
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf=kaçıncı index
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("cansel"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert=belli indexten başlayıp string ekleme
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));

            //PadLeft PadRight=sağ veya solu belirli sayıya tamamla
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            //Remove=sil
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3)); //5.indexten itibaren 3 karakter siliyor
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split=boşluklara göre parçala ve diziye ata
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
            









        }
    }
}
