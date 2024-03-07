
Console.WriteLine("Sipariş numarası giriniz");
var siparis = Console.ReadLine();
int deger;
while (string.IsNullOrEmpty(siparis) || int.TryParse(siparis, out deger) == false)
{
	Console.WriteLine("Lütfen geçerli bir  sayı giriniz");
	siparis= Console.ReadLine();
}

int ilkSayi = Convert.ToInt32(siparis.Substring(0, 1));
switch (ilkSayi)
{
	case 1:
		Console.WriteLine("Kalem siparişi girdiniz");
		break;
	case 2:
		Console.WriteLine("Kitap siparişi girdiniz");
		break;
	case 3:
		Console.WriteLine("Defter siparişi girdiniz");
		break;
	default:
		Console.WriteLine("Tanımlı sipariş no bulunamadı");
		break;
}





