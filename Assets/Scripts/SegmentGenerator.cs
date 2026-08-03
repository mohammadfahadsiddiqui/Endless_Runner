using System.Collections;
using UnityEngine;

public class Segment : MonoBehaviour
{
    public GameObject[] segment;

    [SerializeField] int zPos = 0;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       StartCoroutine(SegmentGen()); 
    }

    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, segmen);
        yield return new WaitForSeconds(10);
        segmentMap02.SetActive(true);

        yield return new WaitForSeconds(10);
        segmentMap03.SetActive(true);
    }

}
