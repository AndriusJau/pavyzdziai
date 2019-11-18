package egzaminas;

import java.text.DecimalFormat;

public class Skritulys {
	
	private double skritulioPlotas;
	
	public void skaiciuokPlota(double spindulioIlgis) {
		double plotas = Math.PI * (Math.pow(spindulioIlgis, 2));
		DecimalFormat suapvalinimas = new DecimalFormat("#.##");
		plotas = Double.valueOf(suapvalinimas.format(plotas));
		this.skritulioPlotas = plotas;
	}
	
	public String toString() {
		return "Jusu skritulio plotas yra " + this.skritulioPlotas + " kv.cm";
	}
}
