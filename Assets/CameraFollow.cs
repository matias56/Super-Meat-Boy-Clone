using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, -10f);
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;

    public float coinsGet;
    public Text score;

    public GameObject end;
    public GameObject s;
    public Text result;


    private void Start()
    {
        coinsGet = 0;
        end.SetActive(false);
        s.SetActive(false);
    }

    private void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        score.text = "Coins = " + coinsGet;
        result.text = coinsGet + "/5";
    }
}
