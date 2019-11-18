package egzaminas;

public class PlotuSkaiciuoklis {

	public static void main(String[] args) {
		
		Ivestis manager = new Ivestis();
		
		manager.suzinokFigura();
		
		if(manager.getFigura() == 1) {
			manager.suzinokKrastines();
			Staciakampis staciakampis = new Staciakampis();
			staciakampis.skaiciuokPlota(manager.getKrastineA(), manager.getKrastineB());
			manager.spausdinkPlota(staciakampis.toString());
		}
		
		else if(manager.getFigura() == 2) {
			manager.suzinokKrastines();
			Trikampis trikampis = new Trikampis();
			trikampis.skaiciuokPlota(manager.getKrastineA(), manager.getKrastineB());
			manager.spausdinkPlota(trikampis.toString());
		}
		
		else if(manager.getFigura() == 3) {
			manager.suzinokSpinduli();
			Skritulys skritulys = new Skritulys();
			skritulys.skaiciuokPlota(manager.getSpindulys());
			manager.spausdinkPlota(skritulys.toString());			
		}
		
		else {
			System.out.println("Tokios figuros ploto skaiciuoti nemoku");
		}		
	}
}
