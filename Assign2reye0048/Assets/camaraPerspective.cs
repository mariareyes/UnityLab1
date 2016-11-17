using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Camera))]
public class camaraPerspective : MonoBehaviour {
    public Camera cam;
    public bool isChanged=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        cam = GetComponent<Camera>();
        if (true == Input.GetKeyDown(KeyCode.Space))
        {
            isChanged= isChanged ? false : true;

            if (isChanged)
            {
                

                cam.orthographic = false;

            }
            else if (!isChanged) {

                cam.orthographic = true;
            }
        }
    }
}
