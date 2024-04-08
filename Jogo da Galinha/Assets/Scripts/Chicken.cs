using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    SpriteRenderer sp;
    //public bool faceRigth;
    [SerializeField]
    float speed;
    public GameObject egg;
    [SerializeField]
    float eggTime;
    private float timer = 0f;

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (sp.flipX) { transform.position += Vector3.right * Time.deltaTime * speed; } 
        else { transform.position -= Vector3.right * Time.deltaTime * speed; }
        //sp.flipX = faceRigth;
        timer += Time.deltaTime;
        EggShot();
    }

    private void EggShot()
    {
        if (timer >= eggTime)
        {
            timer = 0f;
            Instantiate(egg, transform.position, transform.rotation);
        }
    }
}
