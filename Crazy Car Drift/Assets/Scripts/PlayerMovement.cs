using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 5000f;
    public float sidewayForce = 80f;

    public bool LeftDirection  = false;
    public bool RightDirection = false;
    public GameObject GameOverUI;
    //public GameObject Player;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (rb.position.x < -33 || rb.position.x> -8)
        {
            Time.timeScale = 0;
            GameOverUI.SetActive(true);

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


        if (Input.GetKey("d"))
        {
            //rb.AddForce(sidewayForce * Time.deltaTime ,0 ,0 , ForceMode.VelocityChange);
            rb.velocity = new Vector3(sidewayForce, 0, forwardForce);


        }

        if (Input.GetKey("a"))
        {
            //rb.AddForce( - sidewayForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
            rb.velocity = new Vector3(-sidewayForce, 0, forwardForce);

        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        //***************** For the virtual buttons***********

        if(LeftDirection == true)
        {
            rb.velocity = new Vector3(-sidewayForce, 0, forwardForce);
            //rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (RightDirection == true)
        {
            rb.velocity = new Vector3(sidewayForce, 0, forwardForce);
            //rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
    }
}
