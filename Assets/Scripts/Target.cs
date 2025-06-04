using System.Runtime.CompilerServices;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 10;
    private float maxSpeed = 12;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpwanPos = -6;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up * Random.Range(minSpeed,maxSpeed), ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-maxTorque,maxTorque),Random.Range(-maxTorque,maxTorque),Random.Range(-maxTorque, maxTorque),ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-xRange,xRange),ySpwanPos,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
