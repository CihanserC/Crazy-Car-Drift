using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 5000f;

    public float sidewayForce = 80f;

    public bool LeftDirection  = false;
    public bool RightDirection = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GoLeftButton()
    {
        LeftDirection = true;
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
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (RightDirection == true)
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
    }
}
