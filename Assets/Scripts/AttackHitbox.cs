using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHitbox : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Find the Health script on the enemy and deal damage
            Health enemyHealth = other.GetComponent<Health>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }
        }
    }
}
/*
1.In the Hierarchy, right-click your Player and select Create Empty. Rename it AttackHitbox.
2.Move AttackHitbox slightly in front of your Player (for example, X = 1 if your player faces right). Because it is a child of the Player, it will automatically flip with your player when they turn around.
3. With AttackHitbox selected, click Add Component and add a BoxCollider2D (or CircleCollider2D).
4. Check the Is Trigger box on that collider, and resize the green collider box to match your attack range.
5. Drag your AttackHitbox.cs script onto this object.
6. Uncheck the active checkbox at the very top-left of the Inspector (next to the name AttackHitbox) so it starts turned off.
*/
