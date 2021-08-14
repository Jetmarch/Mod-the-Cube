using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 scaleVector = new Vector3(0.001f, 0.001f, 0.001f);
    public float cubeRotationSpeed = 15.0f;

    void Start()
    {
        Color cubeColor = Random.ColorHSV();

        transform.position = new Vector3(4, 4, 2);
        transform.localScale = Vector3.one * 0.1f;
        
        Material material = Renderer.material;

        material.color = cubeColor;
    }
    
    void Update()
    {
        transform.Rotate(0.0f, cubeRotationSpeed * Time.deltaTime, 0.0f);

        if (transform.localScale.magnitude < (Vector3.one.magnitude * 3))
        {
            transform.localScale += scaleVector * Time.deltaTime;
        }
    }
}
