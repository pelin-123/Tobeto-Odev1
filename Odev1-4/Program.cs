int tahmin = 0, tutulan, sayac = 0;
Random rasgele = new Random();
string girilenDeger;
int deger;
tutulan = rasgele.Next(1, 10);
while (tahmin != tutulan)
{
	sayac++;
	Console.WriteLine("1ile10 arasında bir sayı giriniz");

	girilenDeger= Console.ReadLine();

	while (string.IsNullOrEmpty(girilenDeger) || int.TryParse(girilenDeger, out deger) == false)
	{
		Console.WriteLine("Lütfen geçerli bir  sayı giriniz");
		girilenDeger = Console.ReadLine();
	}

	tahmin = Convert.ToInt32(girilenDeger);

	if (tahmin > tutulan)
	{
		Console.WriteLine("Sayıyı küçült");
	}
	else if (tahmin < tutulan)
	{
		Console.WriteLine("Sayıyı büyüt");
	}
}
Console.WriteLine("Tebrikler.");
Console.WriteLine("{0}.hakkınızda bildiniz", sayac);
Console.ReadKey();

