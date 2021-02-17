using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    private Image HealthBar;
    public float curHealth;
    private float maxHp = 100f;
    PlayerColtroller player;

    private void Start()
    {
        HealthBar = GetComponent<Image>();
        player = FindObjectOfType<PlayerColtroller>();
    }


    private void Update()
    {
        curHealth = player.HealthS;
        HealthBar.fillAmount = curHealth / maxHp;
    }


    
}
