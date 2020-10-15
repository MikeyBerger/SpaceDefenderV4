using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonV5 : MonoBehaviour
{
    public bool PlayIsPressed;
    private SpriteRenderer SR;

    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cursor")
        {
            SR.material.color = Color.green;
            PlayIsPressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cursor")
        {
            SR.material.color = Color.white;
            PlayIsPressed = false;
        }
    }
}
