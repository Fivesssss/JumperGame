using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private Sprite fullHeart;
    [SerializeField] private Sprite halfHeart;
    [SerializeField] private Sprite emptyHeart;
    [SerializeField] private Image[] heartUis; //0 is the right most heart heartUis.length - 1 is the leftmost

    private int currentHeartIndex = 0;
    private const float healthPerHeart = 0.5f; //each full heart is worth 1 health point in code

    //for cases when hearts gained are more than the empty hearts, or when the player respawns or spawns
    public void setHeartsFull() 
    {
        for (int i = 0; i < heartUis.Length; i++)
        {
            heartUis[i].sprite = fullHeart;
        }
        currentHeartIndex = 0; //reset the heart index to the start
    }

    //used for cases when the damage done is more than the hearts avalible 
    public void setHeartsEmpty() 
    {
        for (int i = 0; i < heartUis.Length; i++)
        {
            heartUis[i].sprite = emptyHeart;
        }
    }

    public void removeHearts(float amount) 
    {
        //amount is the damage amount and hearts needed to be removed
        while (amount > 0 && currentHeartIndex < heartUis.Length) 
        {
            Image heart = heartUis[currentHeartIndex];

            //this will change the heart sprite depending on if its full or half to one less
            if (heart.sprite == fullHeart)
            {
                heart.sprite = halfHeart;
            }
            else if (heart.sprite == halfHeart) 
            {
                heart.sprite = emptyHeart;
            }

            //once the current heart is empty move onto the next heart
            if (heart.sprite == emptyHeart) 
            {
                currentHeartIndex += 1;
            }

            amount -= healthPerHeart;
        }
    }

    public void addHearts(float amount) 
    {

    }
}
