using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float speed = 5;
    public float deadZone = -45;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < deadZone){
            Destroy(gameObject);
        }
        
    }
}
