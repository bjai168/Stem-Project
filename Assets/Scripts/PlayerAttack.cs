using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackHitbox;     // Drag your Hitbox child object here
    public float attackDuration = 0.2f;
    public float attackCooldown = 0.5f;

    private bool canAttack = true;

    void Start()
    {
        if (attackHitbox != null)
            attackHitbox.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canAttack)
        {
            StartCoroutine(PerformAttack());
        }
    }

    IEnumerator PerformAttack()
    {
        canAttack = false;
        attackHitbox.SetActive(true);

        yield return new WaitForSeconds(attackDuration);

        attackHitbox.SetActive(false);

        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }
}
