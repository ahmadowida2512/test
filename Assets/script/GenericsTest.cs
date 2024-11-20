using UnityEngine;

public class GenericsTest : MonoBehaviour
{ 
    void Start(){
     GameContainer<string> stringContainer = new GameContainer<string>();
        stringContainer.SetItem("Healing Potion");

        
        string item = stringContainer.GetItem();
        Debug.Log(item);

        string description = GameUtils.DescribeItem(item);
        Debug.Log(description);
}

}
