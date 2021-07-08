using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card",menuName ="Card")] // *menuName="Cards/Minions"*----Sub menu
public class Card : ScriptableObject
{
   
 public new string name;
 public string description; 

 public int manaCost;
 public int attack;
 public int health;

}
