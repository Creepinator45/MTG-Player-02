using UnityEngine;
public class CreateCard : MonoBehaviour
{
    public GameObject cardPrefab;
    public Sprite[] Images;
    public int ImageNum;
    void Update()
    {
        if (Input.GetKey("c"))
        {
            Instantiate(cardPrefab, new Vector2(0, 0), Quaternion.identity);
        }
    }
}
