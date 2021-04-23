using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [Header("Buttons")]
    public Button burgerButton;
    public Button pizzaButton;
    public Button soupButton;

    [Header("Text")]
    public Text burgerTimer;
    public Text pizzaTimer;
    public Text soupTimer;

    GameManager game;

    // Start is called before the first frame update
    private void Start()
    {
        game = GameObject.FindObjectOfType<GameManager>();
        burgerButton.onClick.AddListener(() => AddBurger());
        pizzaButton.onClick.AddListener(() => AddPizza());
        soupButton.onClick.AddListener(() => AddSoup());
        
    }

    // Update is called once per frame
    void Update()
    {
        if (burgerTimer)
        {
            burgerTimer.text = game.burgerCountdown.ToString();
        }
        if (pizzaTimer)
        {
            pizzaTimer.text = game.ToString();
        }
        if (soupTimer)
        {
            soupTimer.text = game.ToString();
        }
    }

    void AddBurger()
    {
        //Debug.Log("Creating Burger");
        game.queue.Enqueue(game.burgerPrefab);
        game.AddBurger();
    }

    void AddPizza()
    {
        //Debug.Log("Creating Pizza");
        game.queue.Enqueue(game.pizzaPrefab);
        game.AddPizza();
    }

    void AddSoup()
    {
        //Debug.Log("Creating Soup");
        game.queue.Enqueue(game.soupPrefab);
        game.AddSoup();
    }

    public IEnumerator MyFunction()
    {
        Debug.Log("MyFunction - Item Selected");

        yield return new WaitForSeconds(3);

        Debug.Log("MyFunction - Item Created");
    }
}
