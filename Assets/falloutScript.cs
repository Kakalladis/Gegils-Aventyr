using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class falloutScript : MonoBehaviour
{
    [SerializeField] Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        playerTransform.position = new Vector3(-2.16f, 8.55f, 0.3f);
    }
}
