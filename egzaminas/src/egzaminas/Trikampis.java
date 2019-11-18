package egzaminas;

public class Trikampis {
	
	private double trikampioPlotas;

	public void skaiciuokPlota(double A, double B) {
		double plotas = (A * B)/2;
		this.trikampioPlotas = plotas;
	}
	
	public String toString() {
		return "Jusu trikampio plotas yra " + this.trikampioPlotas + " kv.cm";
	}
}
