using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi452KOntrol : MonoBehaviour
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
        if (gamePlayKontrol.derece45)
        {
            transform.position += new Vector3(-1, 0.5f, 0f) * Time.deltaTime * hiz;

        }
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
