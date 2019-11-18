package egzaminas;

import java.util.Scanner;

public class Ivestis {

	private int figura;
	private double krastineA;
	private double krastineB;
	private double spindulys;
	
	public void suzinokFigura() {		
		System.out.println("Kurios figuros plota noretumete skaiciuoti?");
		System.out.println("Iveskite 1 staciakampio plotui skaiciuoti;");
		System.out.println("Iveskite 2 trikampio plotui skaiciuoti;");
		System.out.println("Iveskite 3 skritulio plotui skaiciuoti;");
		Scanner myScanner = new Scanner(System.in);
		this.figura = myScanner.nextInt();		
	}
	
	public void suzinokKrastines() {		
		System.out.println("Iveskite krastine/statini A: ");
		Scanner myScannerA = new Scanner(System.in);
		this.krastineA = myScannerA.nextDouble();
		System.out.println("Iveskite krastine/statini B: ");
		Scanner myScannerB = new Scanner(System.in);
		this.krastineB = myScannerB.nextDouble();
	}
	
	public void suzinokSpinduli() {		
		System.out.println("Iveskite spindulio ilgi: ");
		Scanner myScanner = new Scanner(System.in);
		this.spindulys = myScanner.nextDouble();		
	}
	
	public void spausdinkPlota(String plotas) { 
		System.out.println(plotas);
		System.out.println("----------------------------------------");
	}

	public int getFigura() {
		return figura;
	}

	public double getKrastineA() {
		return krastineA;
	}

	public double getKrastineB() {
		return krastineB;
	}

	public double getSpindulys() {
		return spindulys;
	}
}
