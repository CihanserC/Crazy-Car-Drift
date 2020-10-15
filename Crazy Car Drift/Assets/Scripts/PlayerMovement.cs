using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardforce = 5000f;

    public float sidewayforce = 80f;

    public bool LeftDir  = false;
    public bool RightDir = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GoLeftButton()
    {
        LeftDir = true;
        //rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void ReverseLeftButton() // This is important, when user put up his finger from the button it stops the force applied on the player
    {
        LeftDir = false;
        //rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }


    public void GoRightButton()
    {
        RightDir = true;
    }

    public void ReverseRightButton()
    {
        RightDir = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //***************** For the keyboard***********

        rb.AddForce(0,0, forwardforce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayforce * Time.deltaTime ,0 ,0 , ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce( - sidewayforce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        //***************** For the virtual buttons***********

        if(LeftDir == true)
        {
            rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (RightDir == true)
        {
            rb.AddForce(sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
    }
}
