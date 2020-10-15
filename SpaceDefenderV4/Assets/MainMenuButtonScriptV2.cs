using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtonScriptV2 : MonoBehaviour
{
    public bool MenuIsPressed;
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

            MenuIsPressed = true;
            SR.material.color = Color.green;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.gameObject.tag == "Cursor")
        {

            MenuIsPressed = false;
            SR.material.color = Color.white;


        }
    }

}
