using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCard : MonoBehaviour
{
    public Dealer Dealer;

    private List<Card> playerDeck = new List<Card>();

    public Card playerCard;

    public Image PlayerCardImage;

    public CardImageHelper cardImageHelper;

    public void SetPlayerDeck()
    {
        playerDeck = Dealer.GetPlayerDeck();
    }

    public void SetPlayerCard()
    {
        playerCard=Deck.GetCard(playerDeck);
        PlayerCardImage.sprite = cardImageHelper.GetCardSprite(playerCard);
    }
}
