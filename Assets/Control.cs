using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
    public GameObject cube1;
    public GameObject cube2;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal")!=0)
        {
            cube1.transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * 10);
            cube2.transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * 10);
        }
        if (cube1.transform.position.x<=-12)
        {
            cube1.transform.position = new Vector3(cube2.transform.position.x + 21.5f, 0, 0);
        }
        if (cube2.transform.position.x <= -12)
        {
            cube2.transform.position = new Vector3(cube1.transform.position.x + 21.5f, 0, 0);
        }
        if (cube1.transform.position.x >= 12)
        {
            cube1.transform.position = new Vector3(cube2.transform.position.x - 21.5f, 0, 0);
        }
        if (cube2.transform.position.x >= 12)
        {
            cube2.transform.position = new Vector3(cube1.transform.position.x - 21.5f, 0, 0);
        }
    }
}
