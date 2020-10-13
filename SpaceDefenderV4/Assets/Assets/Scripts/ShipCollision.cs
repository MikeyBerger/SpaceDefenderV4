using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipCollision : MonoBehaviour
{
    private Animator Anim;
    public float HitTime;
    public float Health = 100;
    public float Damage;
    public float MinDamage;
    public float MaxDamage;
    public string GameOverScene;

    IEnumerator NotHit()
    {
        yield return new WaitForSeconds(HitTime);
        Anim.SetBool("WasHit", false);
    }

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Damage = Random.Range(MinDamage, MaxDamage);

        if (Health <= 0)
        {
            SceneManager.LoadScene(GameOverScene);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Anim.SetBool("WasHit", true);
            StartCoroutine(NotHit());
            Health -= Damage;
        }
    }
}
