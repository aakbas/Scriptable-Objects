using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Text nameText;
    public Text descriptionText;

    public Text manaText;
    public Text atackText;
    public Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text=card.name;
        descriptionText.text=card.description;
        manaText.text=card.manaCost.ToString();
        atackText.text=card.attack.ToString();
        healthText.text=card.health.ToString();

    }

    







}
