using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    bool jumpFlag = false;
    bool jump = false;

    public Text scoreText;

    void Start() {
      scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

      if (jumpFlag)
      {
        jumpFlag = false;
        animator.SetBool("IsJumping", true);
      }

      if (Input.GetButton("Jump"))
      {
        jump = true;
        animator.SetBool("IsJumping", true);
      }
    }

    public void OnLanding()
    {
      animator.SetBool("IsJumping", false);
      jump = false;
      scoreText.GetComponent<ScoreController>().score += 1;
      scoreText.GetComponent<ScoreController>().UpdateScore();
    }

    void FixedUpdate()
    {
      controller.Move(((float)0.35), false, jump);

      if (jump)
      {
        jumpFlag = true;
      }
    }
}
