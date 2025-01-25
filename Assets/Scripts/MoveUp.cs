using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float spped = 1;

    void Update()
    {
        var pos = transform.position;
        pos.y += spped * Time.deltaTime;
        transform.position = pos;
    }
}
