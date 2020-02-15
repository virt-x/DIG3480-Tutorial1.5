using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetInteger("State", 1);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetInteger("State", 0);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetInteger("State", 2);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            animator.SetInteger("State", 0);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
