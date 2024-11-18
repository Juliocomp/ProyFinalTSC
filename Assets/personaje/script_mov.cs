using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Animator playerAnim;
	public Rigidbody playerRigid;
	public float w_speed, wb_speed, olw_speed, rn_speed, ro_speed;
	public bool walking;
	public Transform playerTrans;

	
	void FixedUpdate(){
		if(Input.GetKey(KeyCode.W)){
			playerRigid.velocity = transform.forward * w_speed * Time.deltaTime;
		}

		if(Input.GetKeyUp(KeyCode.W)){
			playerRigid.velocity = Vector3.zero;
		}
		if(Input.GetKey(KeyCode.S)){
			playerRigid.velocity = -transform.forward * wb_speed * Time.deltaTime;
		}
		if(Input.GetKeyUp(KeyCode.S)){
			playerRigid.velocity = Vector3.zero;
		}
	}
	void Update(){
		if(Input.GetKeyDown(KeyCode.W)){
			playerAnim.SetTrigger("walking");
			playerAnim.ResetTrigger("idle");
			playerAnim.ResetTrigger("backwalk");

			walking = true;
			//steps1.SetActive(true);
		}
		if(Input.GetKeyUp(KeyCode.W)){
			playerAnim.ResetTrigger("walking");
			playerAnim.SetTrigger("idle");
			playerAnim.ResetTrigger("backwalk");
			walking = false;
			//steps1.SetActive(false);
		}
        
		if(Input.GetKeyDown(KeyCode.S)){
			playerAnim.SetTrigger("backwalk");
			playerAnim.ResetTrigger("idle");
			playerAnim.ResetTrigger("walking");
			//steps1.SetActive(true);
		}
		if(Input.GetKeyUp(KeyCode.S)){
			playerAnim.ResetTrigger("backwalk");
			playerAnim.ResetTrigger("walking");
			playerAnim.SetTrigger("idle");
			//steps1.SetActive(false);
		}
        
		if(Input.GetKey(KeyCode.A)){
			playerTrans.Rotate(0, -ro_speed * Time.deltaTime, 0);
		}
		if(Input.GetKey(KeyCode.D)){
			playerTrans.Rotate(0, ro_speed * Time.deltaTime, 0);
		}
        /*
		if(walking == true){				
			if(Input.GetKeyDown(KeyCode.LeftShift)){
				//steps1.SetActive(false);
				//steps2.SetActive(true);
				w_speed = w_speed + rn_speed;
				playerAnim.SetTrigger("run");
				playerAnim.ResetTrigger("walk");
			}
			if(Input.GetKeyUp(KeyCode.LeftShift)){
				//steps1.SetActive(true);
				//steps2.SetActive(false);
				w_speed = olw_speed;
				playerAnim.ResetTrigger("run");
				playerAnim.SetTrigger("walk");
			}
            
		}
        */
	}
	 
}
