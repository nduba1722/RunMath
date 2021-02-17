using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMath : MonoBehaviour
{
    
    [SerializeField] GameObject math;

    //เชื่อมText
    [SerializeField] Text textMath1;
    [SerializeField] Text textMath2;

    //รับค่า RanDom
    public int math1;
    public int math2;

    public int MathF;

    private void Start()
    {
        player = FindObjectOfType<PlayerColtroller>();
    }

    void Update()
    {

        

        //------------สุ่มใหม่เมื่อคำตอบซ้ำกัน---------------
        if (RanMath1 == MathF|| RanMath2 == MathF )
        {
            RanMath1 = Random.Range(1, 21);
            RanMath2 = Random.Range(1, 21);
        }
        mathShow();

        //---------รวมผลสุ่ม-----------
        MathF = math1 + math2;
    }

    void mathShow()
    {

        

        if (mathBool == false & mathPosition == 1)
        {
            math.SetActive(true);

            //---------------โจทย์------------
            textMath1.text = "" + math1;
            textMath2.text = "" + math2;
            //---------------คำตอบ-----------
            Mtext1.text = "" + MathF;
            Mtext2.text = "" + RanMath2;
        }

        else if (mathBool == false & mathPosition == 2)
        {
            math.SetActive(true);

            //---------------โจทย์------------
            textMath1.text = "" + math1;
            textMath2.text = "" + math2;
            //---------------คำตอบ-----------
            Mtext1.text = "" + RanMath1;
            Mtext2.text = "" + MathF;
        }
        else if(mathBool == true) 
        {
            coin = 1;
            math.SetActive(false);
            Mtext1.text = "." ;
            Mtext2.text = "." ;
        }
    }

    //--------------เช็คการชน---------------
    public bool mathBool;
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag =="Player")
        {
            mathBool = false;
            RanDomText();
            randomMath();
        }
       

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        IsMath = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            mathBool = true;
            mathPosition = 0;
        }
                
    }

    //---------------สุ่มโจทย์------------
    public void RanDomText()
    {
        math1 = Random.Range(1,11);
        math2 = Random.Range(1,11);
    }

    //-------------สุ่มคำตอบ---------------
    [SerializeField] Text Mtext1;
    [SerializeField] Text Mtext2;
    public int RanMath1;
    public int RanMath2;
    int mathPosition;
    public bool IsMath;

    void randomMath()
    {
       RanMath1 = Random.Range(9, 22);
       RanMath2 = Random.Range(9, 22);
       mathPosition = Random.Range(1, 3);
        Debug.Log("ตำแหน่งคำตอบ" + mathPosition);
       IsMath = true;
    }



    

    //-------------ปุ่มคำตอบ-------------

    
    PlayerColtroller player;

    public static int checkButtom = 1;

    int coin = 1;
    public void OnPointerDown1()
    {
        if (mathPosition == 1 & IsMath == true & coin == 1 & player.HealthS < 100f )
        {
            checkButtom = 1;

            player.HealthS += 30;
            coin -= 1;
        }    

        IsMath = false;
    }
    public void OnPointerDown2()
    {       
        if (mathPosition == 2 & IsMath == true & coin == 1 & player.HealthS < 100f)
        {
            checkButtom = 1;

            player.HealthS += 30;
            coin -= 1;
        }

        IsMath = false;
    }
}
