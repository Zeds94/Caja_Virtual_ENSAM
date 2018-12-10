[System.Serializable]
public class Game {

    public static Game current;
    public SacDeFrappe sac;
    

    public Game()
    {

        sac = new SacDeFrappe();
       

    }

}
