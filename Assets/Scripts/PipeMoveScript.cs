using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public static float speed = 5f;   // **Statik yaptık, böylece tüm borular aynı hızdan etkilenir**
    public float acceleration = 0.1f; // Hızın zamanla artması için

    public float deadZone = -45f;

    private void Update()
    {
        // Boruları sola hareket ettir
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Zamanla hızını artır (Statik olduğu için tüm borular etkilenir)
        speed += acceleration * Time.deltaTime;

        Debug.Log("Güncellenmiş Hız: " + speed); // Konsolda kontrol et

        // Belirli bir noktaya ulaşınca yok et
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
