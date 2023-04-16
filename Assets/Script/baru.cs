using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baru : MonoBehaviour
{
    public Animator playerAnim;
    public Transform playerTrans;

    public float MoveSpeed = 3f;
    public float smoothRotationTime = 0.25f;
    public bool enableMobileInputs = false;

    float currentVelocity;
    float currentSpeed;
    float speedVelocity;

    Transform cameraTransform;
    public FixedJoystick joystick;
        
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        

        Vector2 input = Vector2.zero;
        if (enableMobileInputs)
        {
            input = new Vector2(joystick.input.x, joystick.input.y);
        }
        else
        {
            input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }

        Vector2 inputDir = input.normalized;
        if (inputDir != Vector2.zero)
        {
            float rotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg;
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, rotation, ref currentVelocity, smoothRotationTime);
        }
        float tragetSpeed = MoveSpeed * inputDir.magnitude;
        currentSpeed = Mathf.SmoothDamp(currentSpeed, tragetSpeed, ref speedVelocity, 0.1f);

        if (inputDir.magnitude > 0)
        {
            playerAnim.SetTrigger("walk");
        }
        else
        {
            playerAnim.SetTrigger("idle");
        }

        transform.Translate(transform.forward * currentSpeed * Time.deltaTime, Space.World);

     }
}
