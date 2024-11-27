using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<string> items;
    public  Inventory(){
      items =   new List<string>();
    }
    public void AddItem(string item){
        items.Add(item);
            Debug.Log($"Item '{item}' added successfully.");
    }
    public void ShowItems(Inventory UP){
        
           Debug.Log("Inventory items:");
            foreach (string item in UP.items)
            {
               Debug.Log($"{item}");
            }
            
       
    }

       public static Inventory operator +(Inventory sayah, Inventory yaser)
        {
            Inventory BInventory = new Inventory();
              foreach (string item in sayah.items)
            {
      BInventory.AddItem(item);
             
            }
       
           foreach (string item in yaser.items)
            {
      BInventory.AddItem(item);
              
            }
        return BInventory;
        }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
