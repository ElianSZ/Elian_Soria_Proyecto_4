using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    private float timeDestroy = 2f;

    // Start is called before the first frame update
    void Start()
    {
        // Destruye el objeto cada 2 segundos
        Destroy(gameObject, timeDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
