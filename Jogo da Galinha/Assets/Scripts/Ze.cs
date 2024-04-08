using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ze : MonoBehaviour
{
    Touch touch;
    [SerializeField]
    float speed;
    bool faceRight = true;
    private SpriteRenderer sp;
    public TextMeshProUGUI score;
    private int scorPoint = 0;

    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            Vector3 pos = Camera.main.ScreenToWorldPoint(touch.position);
            if (pos.x > 0)
            {
                transform.position += Vector3.right * Time.deltaTime * speed;
                faceRight = true;
            }
            else
            {
                transform.position -= Vector3.right * Time.deltaTime * speed;
                faceRight = false;
            }

            sp.flipX = faceRight;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Egg")
        {
            scorPoint++;
            score.text = "Score: " + scorPoint.ToString();
            Destroy(collision.gameObject);
        }
    }
}
