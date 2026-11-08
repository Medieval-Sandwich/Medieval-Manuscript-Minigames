using UnityEngine;
using DG.Tweening;

public class FruitCatcherMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.DOMoveX(1.5f, moveSpeed)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }
    
}

