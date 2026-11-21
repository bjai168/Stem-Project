using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescuedNPC : MonoBehaviour
{
    public int value = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerStats player = other.GetComponent<PlayerStats>();
            if (player != null)
            {
                player.AddCoins(1);
            }
            Destroy(gameObject);
        }
    }
}
