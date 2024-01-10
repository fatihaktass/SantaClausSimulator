using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator anim;
    PlayerController playerController;

    void Start()
    {
        anim = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Horizontal", playerController.HorizontalMovement);
        anim.SetFloat("Vertical", playerController.VerticalMovement);

        if (Input.GetKeyDown(KeyCode.W)) { anim.SetFloat("LastVertical", 1); anim.SetFloat("LastHorizontal", 0); }
        if (Input.GetKeyDown(KeyCode.S)) { anim.SetFloat("LastVertical", -1); anim.SetFloat("LastHorizontal", 0); }
        if (Input.GetKeyDown(KeyCode.D)) { anim.SetFloat("LastHorizontal", 1); anim.SetFloat("LastVertical", 0); }
        if (Input.GetKeyDown(KeyCode.A)) { anim.SetFloat("LastHorizontal", -1); anim.SetFloat("LastVertical", 0); }
       
    }
}
