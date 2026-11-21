using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int Coins = 0;

    public void AddCoins(int amount)
    {
        Coins += amount;
        Debug.Log("NPCs saved: " + Coins);
    }
}
