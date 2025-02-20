using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flak_Controller : MonoBehaviour
{
    public float speedM = 1.0f;

    private Vector3 target;


    private void Awake()
    {
        target = new Vector3(0.0f, 0.0f, 0.0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var speed = speedM * Time.deltaTime;
        Vector3 dir = target - transform.position;
        dir.Normalize();
        transform.position += speed * dir;

    }
}
