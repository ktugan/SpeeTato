using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour
{

    public float speed = 6.0F;
    public float jumpSpeed = 10.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    public int maxJumps = 2;

    private int currentJump = 0;
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            currentJump = 0;
        }

        if (currentJump < maxJumps && Input.GetButtonUp("Jump"))
        {
            currentJump++;
            moveDirection.y = jumpSpeed * (1f / currentJump);
        }


        moveDirection.y -= gravity * Time.deltaTime;
        moveDirection.z = 0;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
