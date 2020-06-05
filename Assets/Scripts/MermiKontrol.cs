using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiKontrol : MonoBehaviour
{
    Rigidbody fizik;
    public static float hiz = 6f;

    // Start is called before the first frame update
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            transform.position += new Vector3(0, 1f, 0f) * Time.deltaTime * hiz;
        
    }

    private void Update()
    {
        Invoke("destroybullet", 5f);
    }

    private void destroybullet()
    {
        Destroy(gameObject);
    }
}
