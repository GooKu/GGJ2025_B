using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject badEndUI;
    [SerializeField] private GameObject goodEndUI;

    public void GoodEnd()
    {
        Debug.Log("GoodEnd");
        commonEndHandle();
        goodEndUI.SetActive(true);
    }

    public void BadEnd()
    {
        Debug.Log("BadEnd");
        commonEndHandle();
        StartCoroutine(badEndShow());
    }

    private IEnumerator badEndShow()
    {
        yield return new WaitForSeconds(.1f);//show time
        badEndUI.SetActive(true);
    }

    private void commonEndHandle()
    {
        GameObject.FindAnyObjectByType<MoveUp>().enabled = false;
        GameObject.FindAnyObjectByType<Clicker>().enabled = false;
        GameObject.FindGameObjectWithTag(Tag.Player).GetComponent<Rigidbody2D>().simulated = false;
    }
}
