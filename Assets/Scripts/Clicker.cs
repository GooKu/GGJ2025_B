using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    [SerializeField] private int movePower = 1;
    [SerializeField] private GameObject clickEffectSample;
    [SerializeField] RectTransform canvasRectTransform;
    private GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag(Tag.Player);
    }

    void Update()
    {
        // 檢測滑鼠左鍵點擊
        if (Input.GetMouseButtonDown(0))
        {
            // 取得滑鼠在世界中的位置
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // 確保 Z 軸為角色的 Z 軸（2D 遊戲通常使用相同的 Z 軸）
            mouseWorldPosition.z = player.transform.position.z;

            // 判斷滑鼠點擊是在角色的左邊還是右邊
            if (mouseWorldPosition.x < player.transform.position.x)
            {
                // 滑鼠點擊在角色的左邊
                OnClick(true);
            }
            else
            {
                // 滑鼠點擊在角色的右邊
                OnClick(false);
            }
        }
    }

    public void OnClick(bool isLeft)
    {
        if (!enabled) { return; }

        var power = isLeft ? movePower : -movePower;
        player.GetComponent<Rigidbody2D>().AddForceX(power, ForceMode2D.Impulse);

        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRectTransform, Input.mousePosition, Camera.main, out var localPoint);
        GameObject effectObject = Instantiate(clickEffectSample, canvasRectTransform);
        effectObject.GetComponent<RectTransform>().anchoredPosition = localPoint;
    }
}
