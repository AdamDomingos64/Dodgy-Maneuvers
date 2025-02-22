using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Flak_Controller : MonoBehaviour
{
    public float speedM = 1.0f;

    private Vector3 target;

    public SpriteRenderer sR;
    public Sprite newSprite;

    public float decaySpeed = 1.0f;

    public Color spriteColor;
    

    public bool exploaded = false;

    private void Awake()
    {
        target = new Vector3(0.0f, 1.0f, 0.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteColor = sR.color;      
    }

    // Update is called once per frame
    void Update()
    {
        var speed = speedM * Time.deltaTime;
        Vector3 dir = target - transform.position;
        dir.Normalize();
        transform.position += speed * dir;

        if (transform.position.y > 0.2f)
        {
            ChangeSprite(newSprite);
            target = new Vector3(-0.5f, 0.0f, 0.0f);
            exploaded = true;
        }

        sR.color = spriteColor;

        if (exploaded == true)
        {
            spriteColor.a -= decaySpeed * Time.deltaTime;

            if (spriteColor.a <= 0.0f)
            {
                Destroy(gameObject);
            }
        }
    }

    void ChangeSprite(Sprite newSprite)
    {
        sR.sprite = newSprite;
     
       
    }
}
