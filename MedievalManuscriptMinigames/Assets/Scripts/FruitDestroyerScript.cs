using UnityEngine;

public class FruitDestroyerScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
            Destroy(other.gameObject);
        }
    }
}

