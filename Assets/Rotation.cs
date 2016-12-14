using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    // Use this for initialization
    //public float rotationSpeed;

    private float earthRotationSpeed = 0.2f;
    private float speed = 2;
    public Camera camera;
    private float spinSpeed = 100;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        GameObject obj = GameObject.Find("Main Camera");

        if (Input.GetKey(KeyCode.R))
        {
            earthRotationSpeed += 1;
            spinSpeed += 1;
        }
        if (Input.GetKey(KeyCode.T))
        {
            earthRotationSpeed -= 1;
            spinSpeed -= 1;
            if (earthRotationSpeed < 0)
            {
                earthRotationSpeed = 0;
                spinSpeed = 0;
            }
                
        }
        if (Input.GetKey(KeyCode.W))
        {
            obj.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            obj.transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            obj.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            obj.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            camera.fieldOfView += 2;
        }
        if (Input.GetKey(KeyCode.E))
        {
            camera.fieldOfView -= 2;
        }

        obj = GameObject.Find("Mercury");
        obj.transform.RotateAround(transform.parent.position, Vector3.up, earthRotationSpeed / 0.240846f * Time.deltaTime);
        obj.transform.Rotate(new Vector3(10, 20, 5), 6.14f * Time.deltaTime);

        obj = GameObject.Find("Venus");
        obj.transform.RotateAround(transform.parent.position, Vector3.up, earthRotationSpeed * Time.deltaTime / 0.615f);
        obj.transform.Rotate(new Vector3(10, 20, 5), -(1.48f) * Time.deltaTime / spinSpeed);

        obj = GameObject.Find("Earth");
        obj.transform.RotateAround(transform.parent.position, Vector3.up, earthRotationSpeed * Time.deltaTime / 1f);
        obj.transform.Rotate(new Vector3(10, 20, 5), 360.99f * Time.deltaTime / spinSpeed);

        obj = GameObject.Find("Mars");
        obj.transform.RotateAround(transform.parent.position, Vector3.up, earthRotationSpeed * Time.deltaTime / 1.881f);
        obj.transform.Rotate(new Vector3(10, 20, 5), 350.89f * Time.deltaTime / spinSpeed);

        obj = GameObject.Find("Jupeter");
        obj.transform.RotateAround(transform.parent.position, Vector3.up, earthRotationSpeed * Time.deltaTime / 11.86f);
        obj.transform.Rotate(new Vector3(10, 20, 5), 870.54f * Time.deltaTime / spinSpeed);

        obj = GameObject.Find("Saturn");
        obj.transform.RotateAround(transform.parent.position, Vector3.up, earthRotationSpeed * Time.deltaTime / 29.46f);
        obj.transform.Rotate(new Vector3(10, 20, 5), 810.79f * Time.deltaTime / spinSpeed);

        obj = GameObject.Find("Uranus");
        obj.transform.RotateAround(transform.parent.position, Vector3.up, earthRotationSpeed * Time.deltaTime / 84.01f);
        obj.transform.Rotate(new Vector3(10, 20, 5), -(501.16f) * Time.deltaTime / spinSpeed);

        obj = GameObject.Find("Neptune");
        obj.transform.RotateAround(transform.parent.position, Vector3.up, earthRotationSpeed * Time.deltaTime / 164.8f);
        obj.transform.Rotate(new Vector3(10, 20, 5), 536.31f * Time.deltaTime / spinSpeed);

        obj = GameObject.Find("Pluto");
        obj.transform.RotateAround(transform.parent.position, Vector3.up, earthRotationSpeed * Time.deltaTime / 248.1f);
        obj.transform.Rotate(new Vector3(10, 20, 5), -(56.36f) * Time.deltaTime / spinSpeed);

        
    }
}
