using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy_Move : MonoBehaviour
{
    [SerializeField]
    float jumpForce;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpForce);
        }
        if(Mathf.Abs(transform.position.y) > 5)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
