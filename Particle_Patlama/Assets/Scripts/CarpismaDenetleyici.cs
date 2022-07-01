using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpismaDenetleyici : MonoBehaviour
{
    public GameObject patlama;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision obj)
    {
        Debug.Log("OnCollisionEnter Carpisma Gerceklesti");
        Destroy(obj.gameObject);
        Destroy(this.gameObject);
        Instantiate(patlama, this.gameObject.transform.position, this.gameObject.transform.rotation);
    }
}
