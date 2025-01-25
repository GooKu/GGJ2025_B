using UnityEngine;

public class GameManager : MonoBehaviour
{
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
        //TODO
    }

    private void commonEndHandle()
    {
        GameObject.FindAnyObjectByType<MoveUp>().enabled = false;
        GameObject.FindAnyObjectByType<Clicker>().enabled = false;
        GameObject.FindGameObjectWithTag(Tag.Player).GetComponent<Rigidbody2D>().simulated = false;
    }
}
