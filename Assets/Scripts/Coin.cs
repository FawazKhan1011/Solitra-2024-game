// Coin.cs
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Animator animator;
    public int value;
    public bool isSpecial = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            string coinTag = gameObject.tag;
            Character character = other.gameObject.GetComponent<Character>();
            if (character != null)
            {
                character.HandleCoinCollision(animator, isSpecial);
            }

            Destroy(gameObject);
            SoundManager.instance.PlayCoinSound();
            CoinCounter.instance.IncreaseCoins(value, isSpecial, coinTag);
        }
    }

}
