using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class StartMenu : MonoBehaviour
{
    [SerializeField] private GameObject startShowObjects;
    [SerializeField] private AudioClip bgm;

    private void Awake()
    {
        GameObject.FindAnyObjectByType<MoveUp>().enabled = false;
        GameObject.FindAnyObjectByType<Clicker>().enabled = false;
        GameObject.FindGameObjectWithTag(Tag.Player).GetComponent<Rigidbody2D>().simulated = false;
        startShowObjects.SetActive(true);
        var audio = GetComponent<AudioSource>();
        audio.clip = bgm;
        audio.Play();
    }

    public void StartShowEnd()
    {
        startShowObjects.SetActive(false);
    }
}
