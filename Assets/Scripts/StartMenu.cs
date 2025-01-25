using UnityEngine;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private GameObject startShowObjects;

    private void Awake()
    {
        GameObject.FindAnyObjectByType<MoveUp>().enabled = false;
        GameObject.FindAnyObjectByType<Clicker>().enabled = false;
        GameObject.FindGameObjectWithTag(Tag.Player).GetComponent<Rigidbody2D>().simulated = false;
        startShowObjects.SetActive(true);
    }

    public void StartShowEnd()
    {
        startShowObjects.SetActive(false);
    }
}
