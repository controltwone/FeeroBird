using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2f;  // Başlangıç spawn süresi
    public float spawnAcceleration = 0.02f; // Spawn süresinin azalması için hız artışı
    private float timer = 0f;
    public float heightOffset = 10f;

    private void Start()
    {
        spawnPipe();
    }

    private void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;

            // Zamanla spawn süresini azalt (ancak 0.5'ten küçük olmamalı)
            spawnRate = Mathf.Max(0.5f, spawnRate - spawnAcceleration);
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
