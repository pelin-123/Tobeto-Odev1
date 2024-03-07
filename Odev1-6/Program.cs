string msg = "Hello There. My name is Pelin Koyun.";

Console.WriteLine("Mesaj=>> " + msg);
Console.WriteLine("Length : Mesajın uzunluğunu verir=>> " + msg.Length);   //stringin uzunluğunu verir

Console.WriteLine("ToLower : Bütün karakterler küçük harfe çevrilir=>> " + msg.ToLower()) ; //bütün karakterler küçük harfe çevirir

Console.WriteLine("ToUpper : Bütün karakterler büyük harfe çevrilir=>> " + msg.ToUpper()); //bütün karakterler büyük harfe çevrilir

Console.WriteLine("Trim: değişkenin sağında ve solunda bulunan boşluk karakterlerini siler=>> " + msg.Trim()); // değişkenin sağında ve solunda bulunan boşluk karakterlerini siler.

Console.WriteLine("StartsWith :  verdiğimiz değişken 'Hello' ile başlıyorsa 'true'' bilgisini verir.=>> "+ msg.StartsWith("Hello"));//  verdiğimiz değişken "Hello" ile başlıyorsa "true" bilgisini verir.

Console.WriteLine("EndsWith: msg değişkeni 'hello' ile bitmediği için 'false' bilgisini verir.=>>" +msg.EndsWith("Hello")); //  msg değişkeni "hello" ile bitmediği için "false" bilgisini verir.
Console.WriteLine("Contains : Atadığımız değişkende 'there'  ifadesi yer alıyorsa 'true' bilgisini verir=>>" + msg.Contains("there")); // atadığımız değişkende "there" ifadesi yer alıyorsa "true" bilgisini verir

Console.WriteLine("IndexOf:  'name' ifadesinin baştan başlayarak kaçıncı index numarasında yer aldığını gösterir.=>> " + msg.IndexOf("name"));//  "name" ifadesinin baştan başlayarak kaçıncı index numarasında yer aldığını gösterir.
Console.WriteLine("Substring:beşinci indexten itibaren olan bilgiyi getirir. =>> " + msg.Substring(5)); // beşinci indexten itibaren olan bilgiyi getirir.
Console.WriteLine("Replace: boşluk karakterlerini '- ' ile değiştirmek için kullanılır =>> " + msg.Replace(" ", " -"));  // boşluk karakterlerini " - " ile değiştirmek için kullanılır
Console.WriteLine("Insert: 2. indexten sonrasına asd ekledik=>> " +msg.Insert(2, "asd")); // istediğimiz indexten sonrasına istediğimiz kelimeyi ekletebiliriz
Console.WriteLine("Remove: 4. indexten itibaren siler. =>> " + msg.Remove(4)); // 4.indexten itibaren siler.