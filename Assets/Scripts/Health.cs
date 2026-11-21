using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int health = 3;
    public string damageTag = "Enemy"; 
    public UnityEvent onDeath;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!string.IsNullOrEmpty(damageTag) && collision.gameObject.CompareTag(damageTag))
        {
            TakeDamage(1);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!string.IsNullOrEmpty(damageTag) && other.CompareTag(damageTag))
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            health = 0;
            onDeath.Invoke();
        }
    }
}
/*
Enemy takes damage
1.Select your Enemy in the Hierarchy window.
2. Add the same Health script to the Enemy (Add Component -> Health).
3. Set Damage Tag to whatever tag your player's weapon, bullet, or attack hitbox uses (for example, PlayerAttack or Bullet).
4. In the On Death () box, click the + button.
5. Drag your Enemy object from the Hierarchy into the empty None (Object) slot.
6. Click No Function, hover over GameObject, and select SetActive (bool).
7. Make sure the small checkbox next to it stays unchecked (unchecked means false, which turns the enemy off when it dies).
*/

/*
Player takes damage
1. Click on your Player in the Hierarchy window.
2. Scroll down to the Health (Script) component in the Inspector.
3. Find the On Death () box and click the + button in the bottom-right corner of that box.
4. Drag your Player object from the Hierarchy into the empty object slot (the box that currently says None (Object)).
5. Click the dropdown next to it that says No Function.
6. Hover over PlayerDeath and click Die ()
*/

/*
For the hit to register cleanly in Unity:
• Tag the Hitbox: Set the attack hitbox's tag (at the top of its Inspector) to match the enemy's damageTag (e.g., "PlayerAttack"). Tip: Use a separate tag like "PlayerAttack" rather than "Player" so simply walking into an enemy doesn't damage them.
• Check Is Trigger: On the hitbox's Collider2D (BoxCollider2D, CircleCollider2D, etc.), make sure Is Trigger is checked.
• Keep it Disabled by Default: Uncheck the hitbox GameObject (or its Collider) until the exact frames of the attack animation when it should deal damage.
• Ensure a Rigidbody2D Exists: At least one of the two colliding objects (usually the Player or Enemy) must have a Rigidbody2D component attached, or Unity won't detect the trigger.
*/