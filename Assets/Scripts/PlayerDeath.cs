using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public int thislevel;
    // Start is called before the first frame update
    void Start()
    {
        thislevel = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    Die();
                    break;
                }
        }
    }
    public void Die()
    {
        SceneManager.LoadScene(thislevel);
    }
}