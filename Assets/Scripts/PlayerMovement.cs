using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public float playerSpeed = 6;
    //public float horizontalSpeed = 3;
    //public float rightLimit = 5.5f;
    //public float leftLimit = -5.5f;
    //static public bool canMove = false;
    //public bool isJumping=false;
    //public bool comingDown = false;
    //public GameObject playerObject;
    //public float jumpSpeed = 3;


    //void Update()
    //{
    //    transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);
    //    if (canMove == true)
    //    {
    //        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
    //        {
    //            if (this.gameObject.transform.position.x > leftLimit)
    //            {
    //                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
    //            }
    //        }


    //        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
    //        {

    //            if (this.gameObject.transform.position.x < rightLimit)
    //            {
    //                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
    //            }
    //        }

    //        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
    //        {

    //            if (isJumping == false)
    //            {
    //                isJumping = true;
    //                playerObject.GetComponent<Animator>().Play("Jump");
    //                StartCoroutine(JumpSequence());
    //            }
    //        }


    //        if (isJumping == true)
    //        {
    //            if (comingDown == false)
    //            {
    //                transform.Translate(Vector3.up * Time.deltaTime * jumpSpeed, Space.World);
    //            }
    //            else
    //            {
    //                transform.Translate(Vector3.up * Time.deltaTime * -jumpSpeed, Space.World);
    //            }
    //        }
    //    }
    //    IEnumerator JumpSequence()
    //    { 
    //    yield return new WaitForSeconds(0.45f);
    //        comingDown = true;
    //     yield return new WaitForSeconds(0.45f);
    //        isJumping = false;
    //        comingDown = false;
    //        playerObject.GetComponent<Animator>().Play("Running");
    //    }
    //}
    public float playerSpeed = 6f;
    public float horizontalSpeed = 3f;
    public float rightLimit = 5.5f;
    public float leftLimit = -5.5f;
    public static bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;
    public float jumpSpeed = 3f;

    void Start()
    {
        canMove = true; // Enable movement initially
    }

    void Update()
    {
        if (!canMove) return;

        // Move forward
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        // Horizontal movement
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed, Space.World);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed, Space.World);
            }
        }

        // Jump
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)) && !isJumping)
        {
            isJumping = true;
            playerObject.GetComponent<Animator>().Play("Jump");
            StartCoroutine(JumpSequence());
        }

        // Apply jump logic
        if (isJumping)
        {
            if (!comingDown)
            {
                transform.Translate(Vector3.up * Time.deltaTime * jumpSpeed, Space.World);
            }
            else
            {
                transform.Translate(Vector3.down * Time.deltaTime * jumpSpeed, Space.World);
            }
        }
    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        comingDown = false;
        playerObject.GetComponent<Animator>().Play("Running");
    }
}
