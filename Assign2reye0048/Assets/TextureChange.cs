using UnityEngine;
using System.Collections;

public class TextureChange : MonoBehaviour
{
    public Material materialToChangeTo;
    public Material[] textures;
    public int currentTexture;
    //public void Changematerial() {
    //    if () {
    //    }

    //    if (materialToChangeTo != null)
    //    {
    //        MeshRenderer renderer = GetComponent<MeshRenderer>();

    //        // Set the renderer to use the material we want to use.
    //        renderer.material = materialToChangeTo;
    //    }
    //}
    void Start()
    {

    }
   
    // Update is called once per frame
    void Update()
    {

        if (true == Input.GetKeyDown(KeyCode.Alpha1))
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            renderer.material = textures[0];
        }
        else if (true == Input.GetKeyDown(KeyCode.Alpha2))
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            renderer.material = textures[1];
        }
        else if (true == Input.GetKeyDown(KeyCode.Alpha3))
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            renderer.material = textures[2];
        }
        else if (true == Input.GetKeyDown(KeyCode.Alpha4))
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            renderer.material = textures[3];

        }
        else if (true == Input.GetKeyDown(KeyCode.Alpha5))
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            renderer.material = textures[4];

        }
        else if (true == Input.GetKeyDown(KeyCode.Alpha6))
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            renderer.material = textures[5];

        }

    }
}