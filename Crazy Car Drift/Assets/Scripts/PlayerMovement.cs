using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 5000f;
    public float sidewayForce = 80f;

    public bool LeftDirection  = false; // Its for mobile button inputs 
    public bool RightDirection = false; // Its for mobile button inputs
    public GameObject GameOverUI;

    public bool LeftWall =  false;
    public bool RightWall = false;

    //public GameObject Player;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (rb.position.x < -33f || rb.position.x> -8f)
        {
            Time.timeScale = 0;
            GameOverUI.SetActive(true);

        }

        if(rb.position.x < -32.150f)
        {
            LeftWall = true; // player hits the wall and needs to stop move left. If LeftWall is true dont dont move left.
        }
        else if (rb.position.x > -9.5f)
        {
            RightWall = true; // Same logic applies for RightWall
        }
        else
        {
            LeftWall = false;
            RightWall = false;
        }
    }

    public void AllowMovement()
    {

    }

    public void GoLeftButton()
    {
        LeftDirection = true;
        //Debug.Log("Left!!!");
        //rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void ReverseLeftButton() // This is important, when user put up his finger from the button it stops the force applied on the player
    {
        LeftDirection = false;
        //rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }


    public void GoRightButton()
    {
        RightDirection = true;
    }

    public void ReverseRightButton()
    {
        RightDirection = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //***************** For the keyboard***********

        //rb.AddForce(0,0, forwardForce * Time.deltaTime);
        rb.velocity = new Vector3(0, 0, forwardForce);


        if (Input.GetKey("d") && RightWall== false)
        {
            //rb.AddForce(sidewayForce * Time.deltaTime ,0 ,0 , ForceMode.VelocityChange);
            rb.velocity = new Vector3(sidewayForce, 0, forwardForce);


        }

        if (Input.GetKey("a") && LeftWall == false)
        {
            //rb.AddForce( - sidewayForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
            rb.velocity = new Vector3(-sidewayForce, 0, forwardForce);

        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        //***************** For the virtual buttons***********

        if(LeftDirection == true && LeftWall == false)
        {
            rb.velocity = new Vector3(-sidewayForce, 0, forwardForce);
            //rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (RightDirection == true && RightWall == false)
        {
            rb.velocity = new Vector3(sidewayForce, 0, forwardForce);
            //rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
    }
}
