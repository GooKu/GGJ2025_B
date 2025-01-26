using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(AudioSource))]
public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject badEndUI;
    [SerializeField] private GameObject goodEndUI;
    [SerializeField] private PlayableDirector stagePlayer;
    [Header("Sound")]
    [SerializeField] private AudioClip gamingBGM;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //call by button
    public void PlayStartShow()
    {
        stagePlayer.Play();
    }
    //call by event
    public void StartGame()
    {
        GameObject.FindAnyObjectByType<MoveUp>().enabled = true;
        GameObject.FindAnyObjectByType<Clicker>().enabled = true;
        GameObject.FindGameObjectWithTag(Tag.Player).GetComponent<Rigidbody2D>().simulated = true;
        audioSource.clip = gamingBGM;
        audioSource.Play();
    }

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
