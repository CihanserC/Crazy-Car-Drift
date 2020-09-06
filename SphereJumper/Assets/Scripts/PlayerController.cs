using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody rb;

    public LayerMask groundLayers;
    public float jumpForce = 7;
    public SphereCollider col;

    public AudioSource JumpSound;

    public GameManager GameManager;

    public ColorPicker cp;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
        //cp.LoadChanges();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        Vector3 movement = new Vector3(horizontal, 0, vertical);
        
        // Jump
        if(IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
           
        }

        rb.AddForce(movement * speed);

        if (rb.position.y < -2f)
        {
            GameManager.CheckFall();

        }



    }

    private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x , 
            col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers );

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            JumpSound.Play();
            
        }
    }



}
