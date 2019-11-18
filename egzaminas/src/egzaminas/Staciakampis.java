package egzaminas;

public class Staciakampis {

	private double staciakampioPlotas;
	
	public void skaiciuokPlota(double A, double B) {
		double plotas = A * B;
		this.staciakampioPlotas = plotas;
	}
	
	public String toString() {
		return "Jusu staciakampio plotas yra " + this.staciakampioPlotas + " kv.cm";
	}
}

