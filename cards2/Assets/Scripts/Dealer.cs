using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Dealer : MonoBehaviour
{
    private List<Card> GameDeck = new List<Card>();

    private void Awake()
    {
        GameStart();
    }

    public List<Card> GetPlayerDeck()
    {
        var playerDeck = GameDeck.Where((c, i) => i % 2 != 0).ToList();
        return playerDeck;
    }

    public List<Card> GetCPUDeck()
    {
        var cpuDeck = GameDeck.Where((c, i) => i % 2 == 0).ToList();
        return cpuDeck;
    }

    public void GameStart()
    {
        GameDeck = Deck.GetDeck();
        GameDeck = Deck.ShuffleDeck(GameDeck);
    }
}