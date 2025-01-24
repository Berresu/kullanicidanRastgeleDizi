using System;
class HelloWorld {
	static void Main() {
	    Console.Write("Dizi Uzunluğu Giriniz: ");
	    int n=Convert.ToInt32(Console.ReadLine());
	    
		Random rastgele=new Random();
		int[] dizi=new int[n];
		
		for(int i=0; i<n; i++){
		    dizi[i]=rastgele.Next(101);
		}
		
		Console.WriteLine("Dizi: ");
		foreach(int sayi in dizi){
		    Console.WriteLine(sayi);
		}
		
		Array.Sort(dizi);
		Array.Reverse(dizi);
		Console.WriteLine("Sıralandıktan Sonra: ");
		foreach(int sayi in dizi){
		    Console.WriteLine(sayi);
		}
	}
}
