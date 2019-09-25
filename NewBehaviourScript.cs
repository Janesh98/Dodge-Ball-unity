using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 1000f;
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
    }
}
