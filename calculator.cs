class Calculator
{
    static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		console.writeline("Hasil penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
		console.writeline("Hasil Pengurangan: {0} - {1} ={2}", a, b, Pengurangan(a, b));
		
		console.writeline("\nTekan sembarang key untuk keluar");
		console.readkey();
	
	}
	
	static int penambahan(inta, int b)
	{
		return a + b;
	}
	
	static int pengurangan(int a, int b)
	{
		return a - b;
	}
	
}