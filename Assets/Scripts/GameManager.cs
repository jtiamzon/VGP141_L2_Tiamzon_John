using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public Queue<GameObject> queue = new Queue<GameObject>();

    
    // don't know if this is needed yet
    static GameManager _instance = null;
    public static GameManager instance
    {
        get { return _instance;  }
        set { _instance = value; }
    }
    

    [Header("GameObjects")]
    public GameObject burgerPrefab;
    public GameObject pizzaPrefab;
    public GameObject soupPrefab;

    [Header("Transforms")]
    public Transform burgerSpawn;
    public Transform pizzaSpawn;
    public Transform soupSpawn;

    [Header("Variables")]
    public int _burgerCountdown = 0;
    public int _pizzaCountdown = 0;
    public int _soupCountdown = 0;

    public void AddBurger()
    {
        Debug.Log("Burger was added");
        //Vector2 mouse = Input.mousePosition;
        
        StartCoroutine(creatingBurger());
    }

    public void AddPizza()
    {
        Debug.Log("Pizza was added");
        //Vector2 mouse = Input.mousePosition;
        // Instantiate(queue.Dequeue(), pizzaSpawn.position, pizzaSpawn.rotation);

        StartCoroutine(creatingPizza());
    }

    public void AddSoup()
    {
        Debug.Log("Soup was added");
        //Vector2 mouse = Input.mousePosition;
        // Instantiate(queue.Dequeue(), soupSpawn.position, soupSpawn.rotation);

        StartCoroutine(creatingSoup());
    }

    public int burgerCountdownStart = 3;
    public int burgerCountdown
    {
        get { return _burgerCountdown; }
        set
        {
            _burgerCountdown = value;

            Debug.Log("Countdown timer is: " + _burgerCountdown);

            if (_burgerCountdown <= 0 )
            {
                _burgerCountdown = burgerCountdownStart;
            }
        }
    }

    public int pizzaCountdownStart = 3;
    public int pizzaCountdown
    {
        get { return _pizzaCountdown; }
        set
        {
            _burgerCountdown = value;

            Debug.Log("Countdown timer is: " + _pizzaCountdown);

            if (_pizzaCountdown <= 0)
            {
                _pizzaCountdown = pizzaCountdownStart;
            }
        }
    }
    public int soupCountdownStart = 3;
    public int soupCountdown
    {
        get { return _soupCountdown; }
        set
        {
            _soupCountdown = value;

            Debug.Log("Countdown timer is: " + _soupCountdown);

            if (_soupCountdown <= 0)
            {
                _soupCountdown = soupCountdownStart;
            }
        }
    }
    private IEnumerator creatingBurger()
    {
        Debug.Log("Burger is being created (3sec)");

        yield return new WaitForSeconds(3);

        Debug.Log("Time: " +new WaitForSeconds(3));
        
        Debug.Log("Burger is now created");

        Instantiate(queue.Dequeue(), burgerSpawn.position, burgerSpawn.rotation);
    }

    private IEnumerator creatingPizza()
    {
        Debug.Log("Pizza is being created (5sec)");
        
        yield return new WaitForSeconds(5);

        Debug.Log("Time: " + Time.time);

        Debug.Log("Pizza is now created");

        Instantiate(queue.Dequeue(), pizzaSpawn.position, pizzaSpawn.rotation);
    }

    private IEnumerator creatingSoup()
    {
        Debug.Log("Soup is being created (8sec)");

        Debug.Log("Time: " + Time.time);

        yield return new WaitForSeconds(8);

        Debug.Log("Soup is now created");

        Instantiate(queue.Dequeue(), soupSpawn.position, soupSpawn.rotation);
    }
}
