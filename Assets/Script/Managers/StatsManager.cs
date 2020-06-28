using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsManager : Manager<StatsManager> {
    

    private int _currentPizza = 2;
    private int _currentHostage = 2;
    private int _currentChicken = 2;
    private int _currentTime = 2;

    private int _pizza;
    private int _hostage;
    private int _chicken;
    private int _time;

    public bool _isPizzaReady = false;
    public bool _isHostageReady = false;
    public bool _isChickenReady = false;
    public bool _isTimeReady = false;

    private GameObject _stats;

    public void Start() {
        _pizza = Random.Range(100000, 999999);
        _hostage = Random.Range(100000, 999999);
        _chicken = Random.Range(100000, 999999);
        _time = Random.Range(100000, 999999);

        _stats = UiManager.Instance.statsCanvas.transform.GetChild(1).gameObject;

        _stats.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Pizzas Delivered: " + _pizza;
        _stats.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "Hostages Rescued: " + _hostage;
        _stats.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = "Fried Chicken Found: " + _chicken;
        _stats.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = "Time Save Bonus: " + _time;

    }


    public void FixedUpdate() {
        if (_isPizzaReady) {
            UpdatePizza();
        }

        if (_isHostageReady) {
            UpdateHostage();
        }

        if (_isChickenReady) {
            UpdateChicken();
        }

        if (_isTimeReady) {
            UpdateTime();
        }
    }

    public void UpdatePizza() {
        if (_currentPizza <= _pizza) {
            _stats.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Pizzas Delivered: " + _currentPizza;
            _currentPizza+= (9472);
        } else {
            _currentPizza = _pizza;
            _isPizzaReady = false;
        }
    }

    public void UpdateHostage() {
        if (_currentHostage <= _hostage) {
            _stats.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "Hostages Rescued: " + _currentHostage;
            _currentHostage+= (9472);
        } else {
            _currentHostage = _hostage;
            _isHostageReady = false;
        }
    }

    public void UpdateChicken() {
        if (_currentChicken <= _chicken) {
            _stats.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = "Fried Chicken Found: " + _currentChicken;
            _currentChicken+= (9472);
        } else {
            _currentChicken = _chicken;
            _isChickenReady = false;
        }
    }

    public void UpdateTime() {
        if (_currentTime <= _time) {
            _stats.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = "Time Save Bonus: " + _currentTime;
            _currentTime += (9472);
        } else {
            _currentTime = _time;
            _isTimeReady = false;
        }
    }


}

