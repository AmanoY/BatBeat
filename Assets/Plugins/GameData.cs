public static class GameData{

    private static int score;
    private static int Maxcombo;
    private static int perfectcombo;
    private static int goodcombo;
    private static int misscombo;

    public static int GetScore()
    {
        return score;
    }

    public static void SetScore(int param)
    {
        score += param;
    }
    public static void SetCombo(int param)
    {
        Maxcombo += param;
    }
    public static void Setperfectcombo(int param)
    {
        perfectcombo += param;
    }
    public static void Setgoodcombo(int param)
    {
        goodcombo = +param;
    }
    public static void Setmisscombo(int param)
    {
        misscombo = +param;
    }
}
