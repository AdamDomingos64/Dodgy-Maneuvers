using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Flak_Controller : MonoBehaviour
{
    public float speedM = 1.0f;

    private Vector3 target;

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

   

    void ChangeSprite(Sprite newSprite)
    {
        spriteRenderer.sprite = newSprite;
    }

    private void Awake()
    {
        target = new Vector3(0.0f, 1.0f, 0.0f);
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

        if (transform.position.y > 0.2f)
        {
            ChangeSprite(newSprite);
            target = new Vector3(-0.5f, 0.0f, 0.0f);
        }
      
        if (Time.time >= 3.5)
        {
            Destroy(gameObject);
        }
    }
}
