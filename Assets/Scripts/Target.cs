using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private GameManager gameManager;
    private float minSpeed = 10;
    private float maxSpeed = 12;
    private float maxTorque = 2;
    private float xRange = 4;
    private float ySpwanPos = -1;
    public int pointValue;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up * Random.Range(minSpeed, maxSpeed), ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-xRange, xRange), ySpwanPos, 0);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        gameManager.UpdateScore(pointValue);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
