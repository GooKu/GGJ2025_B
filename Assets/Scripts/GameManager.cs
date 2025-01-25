using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject badEndUI;

    public void GoodEnd()
    {
        commonEndHandle();
        Debug.Log("GoodEnd");
        //TODO
    }

    public void BadEnd()
    {
        commonEndHandle();
        Debug.Log("BadEnd");
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
