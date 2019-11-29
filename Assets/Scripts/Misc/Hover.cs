using UnityEngine;

public class Hover : MonoBehaviour
{
    [SerializeField] float hoverSpeed = .2f, height = .5f;
    Vector3 tempPos = new Vector3();
    Vector3 posOffset = new Vector3();

    private void Start()
    {
        posOffset = transform.position;
    }

    private void Update()
    {
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * hoverSpeed) * height;

        transform.position = tempPos;
    }
}
