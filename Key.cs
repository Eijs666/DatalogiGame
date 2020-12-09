using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameManager GM;

    public float rotateSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, transform.up, rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        GM.hasKey = true;
        Destroy(gameObject);
    }
}
