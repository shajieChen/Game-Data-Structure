using UnityEngine; 
using UnityEngine.Events ; 
using System.Collections ; 
using System.Collections.Generic ;

public class EventManager : MonoBehaviour
{
    private Dictionary<string, UnityEvent> _EventDictionary;

    private static EventManager _EventManager; 
    //找到这个eventSystem 
    private static EventManager _Instance
    {
        get
        {
            if (_EventManager == null)
            {
                _EventManager = FindObjectOfType(typeof(EventManager)) as EventManager;
                if (!_EventManager)
                    Debug.LogError("Error: There needs to be one active EventManager");
                else
                { 
                    _EventManager.Init();
                }
            }
            return _EventManager; 
        }
    }
    void Init()
    {
        if(_EventDictionary == null)
        {
            _EventDictionary = new Dictionary<string, UnityEvent>();
        }
    }

    //start Listening 
    public static void startListening(string eventName, UnityAction Listener)
    {
        //创建新的unityEvent
        UnityEvent thisEvent = null; 
        //查找dic上面是否包含这个event , tryGetValue 和Contains Key 原理差不多， 但是效率上面tryGetValue 胜一筹
        if(_Instance._EventDictionary.TryGetValue(eventName , out thisEvent))
        {
            thisEvent.AddListener(Listener); 
        }
        else
        {
            thisEvent = new UnityEvent();
            thisEvent.AddListener(Listener);
            _Instance._EventDictionary.Add(eventName, thisEvent); 
        }
    }
    //Stop Listening 
    public static void stopListening(string eventName , UnityAction Listener)
    {
        if (_EventManager == null)
            throw new System.Exception("Error: Can't find the _EventManager");
        UnityEvent thisEvent = null; 
        if(_Instance._EventDictionary.TryGetValue(eventName , out thisEvent))
        {
            thisEvent.RemoveListener(Listener); 
        } 
    }
    //trigger event 
    public static void TriggerEvent(string eventName)
    {
        UnityEvent thisEvent = null; 
        if(_Instance._EventDictionary.TryGetValue(eventName , out thisEvent))
        {
            thisEvent.Invoke(); 
        }
    } 

}
