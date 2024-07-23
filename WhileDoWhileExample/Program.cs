// See https://aka.ms/new-console-template for more information

//While dongusu ile kullanicidan alinan girdi sayisina gore Ben bir Patikal'liyim ciktisinin alinmasi.
Console.WriteLine("While dongusu icin lutfen bir limit degeri giriniz: "); // kullanicidan limit girdisi alinmais
int userInputLimit = Convert.ToInt32(Console.ReadLine());


int counter = 0; // sayac tanimlanamsi
while (counter < userInputLimit) // kullanicidan alinan limit kadar cikti yazdirilmasi
{
    Console.WriteLine("Ben bir Patika'liyim.");
    counter++;
}
if (userInputLimit <= 0)
    Console.WriteLine("0 veya (-) limit girmenize ragmen while dongusu calismadi");
Console.WriteLine("----------------------------------------------------------------");
// do-while dongusu ile kullanicidan alinan girdi sayisina gore Ben bir Patikal'liyim ciktisinin alinmasi.
int counter2 = 0; // degiskenlerin tanimlanmasi
int userInputLimit2;
Console.WriteLine("do while dongusu icin lutfen bir limit degeri giriniz: ");// kullanicidan limit  alinmasi
userInputLimit2 = Convert.ToInt32(Console.ReadLine());

do                 // kullanicidan alinan limit kadar cikti alinmais
{
    counter2++;
    Console.WriteLine("Ben bir Patika'liyim.");

} while (counter2 < userInputLimit2);
if (userInputLimit2 <= 0)
    Console.WriteLine("0 veya (-) limit girmenize ragmen do while dongusu bir kez calisti");

// while dongusu kullanicidin girdigi limit kadar donguye girerek yazmakta. 0 ve (-) deger girildiginde sayac 0 dan baslandiginda donguye hic girmemektedir.do while dongusunde ise sart daha sonra kontrol edildiginden 0 veya (-) deger girilmesine ragmen donguye bir kere girilip ekrana cikti yazdirmaktadir.


