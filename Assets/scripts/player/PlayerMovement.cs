using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;

    public float forwardForce = 500f;
    public float sidewaysForce = 800f;
    public int upForce = 12;

    // Start is called before the first frame update
    void Start()
    {
        // Input.GetKey(KeyCode.Space).
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
        {
            // rigidBody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
            rigidBody.AddForce(0, upForce,0);
        }
    }
}