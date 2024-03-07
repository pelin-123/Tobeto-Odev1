Console.WriteLine("Bir sayı giriniz");

string girilenDeger = Console.ReadLine();
int deger;
while (string.IsNullOrEmpty(girilenDeger) || int.TryParse(girilenDeger, out deger) == false)
{
	Console.WriteLine("Lütfen geçerli bir  sayı giriniz");
	girilenDeger = Console.ReadLine();
}

int sayi = Convert.ToInt32(girilenDeger);
int toplam = 0;
for (int i = 1; i < sayi; i++)
{
	if (sayi % i == 0)
	{
		toplam += i;
	}
}
if (toplam == sayi)
	Console.WriteLine(sayi + " Sayısı mükemmel sayıdır");
else
	Console.WriteLine(sayi + " Sayısı mükemmel sayı değildir");


