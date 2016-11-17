using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
    public float angle = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        angle += 40.0f * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0.0f, angle, 0.0f);
        
    }
}
