using UnityEngine;

public class FireFruitProjectile : MonoBehaviour
{
    public Rigidbody2D medievalProjectile;
    public float medievalSpeed = 4.0f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody2D projectile = Instantiate(medievalProjectile, transform.position, transform.rotation);
            projectile.linearVelocity = new Vector2(Random.Range(-3f, 3f), Random.Range(-1f, 3f));
        }
    }
}