using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButtonScriptV2 : MonoBehaviour
{
    public bool ResetIsPressed = false;
    private Color ColorWhite = Color.white;
    private Color ColorRed = Color.red;
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
        if (collision.transform.gameObject.tag == "Cursor")
        {
            ResetIsPressed = true;
            SR.material.color = Color.green;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.gameObject.tag == "Cursor")
        {
            ResetIsPressed = false;
            SR.material.color = ColorWhite;
           
        }
    }
}
