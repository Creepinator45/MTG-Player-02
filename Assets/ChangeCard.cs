using UnityEngine;

public class ChangeCard : MonoBehaviour
{
    public CreateCard createCard;
    private void Awake()
    {
        Sprite newSprite = createCard.Images[createCard.ImageNum];
    SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
    spriteRenderer.sprite = newSprite;
        if (createCard.ImageNum<createCard.Images.Length-1)
        {
            createCard.ImageNum++;
        }
        else
{
    createCard.ImageNum = 0;
}
    }
}
