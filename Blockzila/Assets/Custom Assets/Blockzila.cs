    using UnityEngine;
using System.Collections;

public class Blockzila : MonoBehaviour {


    public float speed = 1;
    public float turnSpeed = 1;

    CharacterController characterController;

    public Animator animatorCam;
    public Animator animatorModel;

    // Use this for initialization
    void Start ()
    {
        characterController = GetComponent<CharacterController>();

         
    }
	
	// Update is called once per frame
	void Update ()
    {
        Movement();
    }

    void Movement()
    {

        Vector3 move = transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical");
        characterController.Move(move);

        Vector3 turn = Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;

        characterController.transform.Rotate(turn);


        animatorModel.SetFloat("Speed", characterController.velocity.magnitude);

    }



}
