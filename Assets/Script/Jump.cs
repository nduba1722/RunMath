using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

	private bool isGround = false;
	private int jump = 2;
	
	public void OnPointerUp()
	{
		if (jump > 0) {
			PlayerColtroller.DoJump(500f);
		}

		jump--;
		
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag=="Ground")
        {
			isGround = true;
			jump = 2;
        }
    }

	public void OnPointerDownSlide()
	{
		
		{
			PlayerColtroller.DoSlide();
		}

	}
	public void OnPointerUpSlideExit()
	{

		{
			PlayerColtroller.DoSlideExit();
		}



	}



}
