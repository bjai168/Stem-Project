using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFinish: MonoBehaviour
{
    private Rigidbody2D rb;
    public int thislevel;
    // Start is called before the first frame update
    void Start()
    {
        thislevel = SceneManager.GetActiveScene().buildIndex;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                    SceneManager.LoadScene(thislevel += 1);
                    break;
                }
        }
    }
}
