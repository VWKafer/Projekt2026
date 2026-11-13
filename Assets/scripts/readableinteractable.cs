using UnityEngine;



/*
 checklist 
 add  file importing foe the text using the file name



*/





public class readableinteractable : MonoBehaviour,IInteractable
{
    [SerializeField] private string Storedtext;
    [SerializeField] private bool IsReingRead = false;
    [SerializeField] private bool wasRead = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Storedtext ==null){
            Storedtext = "This is a default text";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact(){
        if (IsReingRead == false){
            IsReingRead = true;
            Debug.Log("Reading");
        }else{
            IsReingRead = false;}
    }
    

    public string GetText()
    {
    
        return Storedtext;
    }
}

