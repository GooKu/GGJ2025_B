using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    [SerializeField] private int movePower = 1;
    private GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag(Tag.Player);
    }

    public void OnClick(bool isLeft)
    {
        if (!enabled) { return; }

        var power = isLeft ? movePower : -movePower;
        player.GetComponent<Rigidbody2D>().AddForceX(power, ForceMode2D.Impulse);
    }
}
