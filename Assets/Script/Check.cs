using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check : MonoBehaviour
{
    public int score = 0;
    
    [SerializeField] Text textScore;
    PlayerColtroller player;

    


    void Start()
    {
        player = FindObjectOfType<PlayerColtroller>();
    }


    void Update()
    {
        textScore.text = "" + score;
    }

    public void ButtomUp()
    {
        ShowMath.checkButtom = 0;
    }

    public void UpScore()
    {
        if (ShowMath.checkButtom == 1)
        {
            score += 10;
        }
        
        
    }
   
    private  void OnTriggerEnter2D(Collider2D other)
    {
        //-------------ชนเหรียญเพิ่มคะแนน-----------
        if (other.gameObject.tag == "Coin")
        {
            score += 1;
           // score += 1;
        }

        if (other.gameObject.tag == "CoinBig")
        {
            score += 5;
            //score += 5;
        }
    }
}
