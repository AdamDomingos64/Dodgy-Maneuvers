using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_Controller : MonoBehaviour
{
    public Animator Animator;
    public float Rspeed = 0.1f;
    public float Lspeed = -0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * Rspeed , 0);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Animator.SetBool("right", true);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Animator.SetBool("right", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * Lspeed, 0);
            
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Animator.SetBool("left", true);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Animator.SetBool("left", false);
        }
    }
}
