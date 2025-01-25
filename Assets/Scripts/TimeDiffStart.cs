using System.Collections;
using UnityEngine;

public class TimeDiffStart : MonoBehaviour
{
    [SerializeField] private Behaviour behaviour;
    [SerializeField] private float offsetMin = 0;
    [SerializeField] private float offsetMax = 1;

    private IEnumerator Start()
    {
        behaviour.enabled = false;
        var lagTime = Random.Range(offsetMin, offsetMax);
        yield return new WaitForSeconds(lagTime);
        behaviour.enabled = true;
    }
}
