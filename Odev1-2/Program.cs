
double toplam = 0;
double deger;
Console.WriteLine("Kaç ürün almak istiyorsun");
var girilenUrun = Console.ReadLine();

while (string.IsNullOrEmpty(girilenUrun) || double.TryParse(girilenUrun, out deger) == false)
{
	Console.WriteLine("Lütfen geçerli bir  sayı giriniz");
	girilenUrun = Console.ReadLine();
}

int urunAdedi = Convert.ToInt32(girilenUrun);
for (int i = 0; i < urunAdedi; i++)
{
	Console.WriteLine((i + 1) + " nolu ürünün fiyatını giriniz");
	var fiyat = Console.ReadLine();

	while (string.IsNullOrEmpty(fiyat) || double.TryParse(fiyat, out deger) == false)
	{
		Console.WriteLine("Lütfen geçerli bir fiyat giriniz");
		fiyat = Console.ReadLine();
	}

	if (double.TryParse(fiyat, out deger))//Girilen deger sayı ise
	{
		toplam += deger;
	}
}
Console.WriteLine("Toplam alışveriş tutarı :" + toplam);






