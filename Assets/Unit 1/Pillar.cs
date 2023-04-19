using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    [SerializeField]
    float speed;

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.fixedDeltaTime;
        if(gameObject.transform.position.magnitude > 15)
        {
            Destroy(gameObject);
        }
    }
}
