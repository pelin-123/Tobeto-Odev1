Console.WriteLine("Öğrenci sayısını giriniz");
var sayi = Console.ReadLine();
double deger;
while (string.IsNullOrEmpty(sayi) || double.TryParse(sayi, out deger) == false)
{
	Console.WriteLine("Lütfen geçerli bir  sayı giriniz");
	sayi = Console.ReadLine();
}
int ogrenciSayisi = Convert.ToInt32(sayi);
double ortalama;
double not1, not2, not3;

for (int i = 1; i <= ogrenciSayisi; i++)
{
	Console.WriteLine(i+ " nolu Öğrencinin adını giriniz");
	var ogrenciAdi = Console.ReadLine();

	Console.WriteLine(" nolu Öğrencinin soyadını giriniz");
	var ogrenciSoyadi=Console.ReadLine();

	Console.WriteLine("1. sınav notunu giriniz");
	var girilenNot1 = Console.ReadLine();
	while (string.IsNullOrEmpty(girilenNot1) || double.TryParse(girilenNot1, out deger) == false)
	{
		Console.WriteLine("Lütfen geçerli bir  sayı giriniz");
		girilenNot1 = Console.ReadLine();
	}

	not1 = double.Parse(girilenNot1);

	Console.WriteLine("2. sınav notunu giriniz");
	var girilenNot2 = Console.ReadLine();
	while (string.IsNullOrEmpty(girilenNot2) || double.TryParse(girilenNot2, out deger) == false)
	{
		Console.WriteLine("Lütfen geçerli bir  sayı giriniz");
		girilenNot2 = Console.ReadLine();
	}

	 not2 = double.Parse(girilenNot2);

	Console.WriteLine("3. sınav notunu giriniz");
	var girilenNot3 = Console.ReadLine();
	while (string.IsNullOrEmpty(girilenNot3) || double.TryParse(girilenNot3, out deger) == false)
	{
		Console.WriteLine("Lütfen geçerli bir  sayı giriniz");
		girilenNot3 = Console.ReadLine();
	}

	 not3 = double.Parse(girilenNot3);

	ortalama = (not1 + not2 + not3) / 3;

	Console.WriteLine(i + "nolu öğrencinin not ortalaması:" + ortalama);


}