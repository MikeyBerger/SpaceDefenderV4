using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Slider Slider;
    private ShipCollision SC;

    // Start is called before the first frame update
    void Start()
    {
        SC = GameObject.FindGameObjectWithTag("Ship").GetComponent<ShipCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        Slider.value = SC.Health;
    }

    public void SetMaxHealth(float Health)
    {
        Health = SC.Health;

        Slider.maxValue = Health;
        Slider.value = Health;
    }

    public void SetHealth(float Health)
    {
        Health = SC.Health;

        Slider.value = Health;
    }
}
