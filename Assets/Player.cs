using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float xmove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xmove = Input.GetAxis("Horizontal") * speed;
        transform.position += new Vector3(xmove, 0, 0);
    }
}
