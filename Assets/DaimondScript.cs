using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaimondScript : MonoBehaviour
{
    [Range(-720, 720)]
    public float RotationSpeed;
    public SpriteRenderer Rend;
    public Transform other;
    public Color NewColor;

    // Use this for initialization
    void Start()
    {
        Rend.color = NewColor;
        Rend.color = new Color(0.2f, 1f, 0.7f);
        //other.position = new Vector3(3, 4, other.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(5f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-3f * Time.deltaTime, 0, 0);
        }
    }   
}
