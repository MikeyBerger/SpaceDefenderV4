using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPsScript : MonoBehaviour
{
    private Animator Anim;
    public bool ChangeScene;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Parallax")
        {
            Anim.SetBool("Grounded", true);
            ChangeScene = true;
        }
    }
}
