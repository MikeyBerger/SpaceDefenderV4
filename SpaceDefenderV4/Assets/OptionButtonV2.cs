using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButtonV2 : MonoBehaviour
{
    public bool OptionIsPressed;
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
            OptionIsPressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cursor")
        {
            SR.material.color = Color.white;
            OptionIsPressed = false;
        }
    }
}
