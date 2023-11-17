namespace _21_Game_Console;

public class Game
{
    private int DecksInGame;
    private int numberOfPlayers = 2;

    private int SetNumbersOfDeckInGame(int _numberOfPlayers) //in future can be created online game, but for now this is only OW
    {
        _numberOfPlayers = numberOfPlayers;
        DecksInGame = numberOfPlayers;
        return DecksInGame;
    }
}