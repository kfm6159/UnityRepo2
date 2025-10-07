using UnityEngine;

public class ItemRotation : MonoBehaviour
{

    public int RotationSpeed = 100;
    private Transform itemTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        itemTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        itemTransform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
    }
}
