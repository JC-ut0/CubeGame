using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwordForce = 2000f;
    public float sidewayForce = 500f;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("playerMovement is instantiated");
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
       rb.AddForce(0, 0, forwordForce * Time.deltaTime);

        if(Input.touchCount > 0)
        {
            Touch touch =  Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
                rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                Debug.Log("Left click");
            }
            else if (touch.position.x > Screen.width / 2)
            {
                rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                Debug.Log("Right click");
            }
            
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
            Debug.Log("falling under ground");
        }
    }
}