using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator_player;
    private Transform cachedTrans;

	// Use this for initialization
	void Start ()
    {
        cachedTrans = this.transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        KeyInput();
        PlayerMove();

        //transform.Rotate(Vector3.up * Time.deltaTime);

    }


    private void PlayerMove()
    {
       // cachedTrans.Translate(Vector3.forward * 5f);
    }


    private void KeyInput()
    {
        animator_player.SetBool("Run", false);
        animator_player.SetBool("Run_Right", false);
        animator_player.SetBool("Run_Left", false);
        animator_player.SetBool("Combo_2", false);

        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(Vector3.up * 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(Vector3.up * 180);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -90);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 90);
        }


        if (Input.GetKey(KeyCode.W))
        {
            cachedTrans.Translate(Vector3.forward * 5f * Time.deltaTime * 1);
            animator_player.SetBool("Run", true);
        }

        if(Input.GetKey(KeyCode.S))
        {
            cachedTrans.Translate(Vector3.forward * 5f * Time.deltaTime * -1);
            animator_player.SetBool("Run", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            cachedTrans.Translate(Vector3.right * 5f * Time.deltaTime * -1);
            // animator_player.SetBool("Run_Left", true);
            animator_player.SetBool("Run", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            cachedTrans.Translate(Vector3.right * 5f * Time.deltaTime * 1);
            //animator_player.SetBool("Run_Right", true);
            animator_player.SetBool("Run", true);
        }

        if(Input.GetMouseButtonDown(0))
        {
            animator_player.SetBool("Combo_2", true);
        }
    }

}
