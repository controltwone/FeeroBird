using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 15;
    private float timer = 0;
    public float heightOffset = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer += Time.deltaTime;
        }
        else{
            spawnCloud();
            timer = 0;
        }
    }

    void spawnCloud(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        cloud.transform.localScale = new Vector3(Random.Range(0,1.4f),Random.Range(0,2),0);
        


        Instantiate(cloud, new Vector3(30, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
