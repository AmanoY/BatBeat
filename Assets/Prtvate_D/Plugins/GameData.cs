public static class GameData{

    public static int score;
    public static int Maxcombo;
    public static int perfectcombo;
    public static int goodcombo;
    public static int misscombo;
    public static int MusicSelectCount;
    public static int DifficultyChange;

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
        Maxcombo = param;
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
    public static void Reset()
    {
        score = 0;
        Maxcombo = 0;
        perfectcombo = 0;
        goodcombo = 0;
        misscombo = 0;
    }
}
