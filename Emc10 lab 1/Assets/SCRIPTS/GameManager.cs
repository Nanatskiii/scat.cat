public class GameManager
{
    public enum EnumGameState
    {
        CountDown,
        Playing,
        GameOver
    }
    public EnumGameState GameState { get; set; }

}
