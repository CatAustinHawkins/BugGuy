using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class PlayerMovementTutorial : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump;

    [HideInInspector] public float walkSpeed;
    [HideInInspector] public float sprintSpeed;

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Ground Check")]
    public LayerMask whatIsGround;
    public bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    public bool SpeedPowerUp;

    public Animator SpeedAnim;
    public GameObject SpeedUI;
    public Image SpeedUI2;
    public AudioSource PowerUpCollect;
    public AudioSource Step1;
    public AudioSource Step2;

    public int RandomInt;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;  // VSync must be disabled
        Application.targetFrameRate = 120;
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        readyToJump = true;


    }

    private void Update()
    {
        MyInput();
        SpeedControl();

        // handle drag
        if (grounded)
            rb.drag = groundDrag;
        else
            rb.drag = 0;

        if(SpeedPowerUp)
        {
            moveSpeed = 20f;
            jumpForce = 10f;
        }
        else
        {
            moveSpeed = 10f;
            jumpForce = 5f;

        }

/*        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            RandomInt = Random.Range(0, 3);

            if (RandomInt == 1)
            {
                Step1.Play();

            }
            else
            {
                Step2.Play();

            }
        }
*/
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        // when to jump
        if(Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false;

            Jump();

            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    private void MovePlayer()
    {
        // calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        // on ground
        if (grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }
        // in air
        else if (!grounded)
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        // limit velocity if needed
        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    private void Jump()
    {
        // reset y velocity
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
    private void ResetJump()
    {
        readyToJump = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "SpeedPowerUp")
        {
            SpeedPowerUp = true;
            StartCoroutine(PowerUpWait());
            SpeedUI.SetActive(true);
            PowerUpCollect.Play();
        }
    }

    IEnumerator PowerUpWait()
    {
        yield return new WaitForSecondsRealtime(10f);
        SpeedAnim.Play("New Animation");
        yield return new WaitForSecondsRealtime(5f);
        SpeedPowerUp = false;
        SpeedUI.SetActive(false);
        SpeedUI2.color = Color.white;
       
        SpeedAnim.StopPlayback();
    }

    public void OnCollisionStay(Collision collision)
    {
        grounded = true;
    }

    public void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
}