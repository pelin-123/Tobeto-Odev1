//while döngüsünde parantez içerisindeki koşul sağlandığı sürece kod bloğu çalışır. 
//Ama Do-while döngüsünde durum false olsa bile döngü en az bir kere çalışır


//Ekrana 10 kere istediğimiz string i yazdıran do while ve while döngüsü örnekleri:

//Do while örneği:

int i = 0;
do
{
	i++;
	Console.WriteLine("Merhaba nasılsın ");
}
while (i < 10);

//---------------------------------------------------------- 

//Aynı örneği while ile yaparsak: 

int a = 0;
while (a < 10)
{
	a++;
	Console.WriteLine("İyiyim sen nasılsın ");
}
Console.ReadKey();