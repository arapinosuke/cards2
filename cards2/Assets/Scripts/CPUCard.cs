using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPUCard : MonoBehaviour
{
    public Dealer Dealer;

    private List<Card> cpuDeck = new List<Card>();

    public Card cpuCard;

    public Image CPUCardImage;

    public CardImageHelper cardImageHelper;

    public void SetCPUDeck()
    {
        cpuDeck = Dealer.GetCPUDeck();
    }

    public void SetCPUCard()
    {
        cpuCard = Deck.GetCard(cpuDeck);
        CPUCardImage.sprite = cardImageHelper.GetCardSprite();
    }

    public void ShowCPUCard()
    {
        CPUCardImage.sprite = cardImageHelper.GetCardSprite(cpuCard);
    }
}
