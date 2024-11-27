using UnityEngine;

public class GameUtils 
{
    
    public static string DescribeItem<T>(T something)
    {
        return $"This item is {something}.";
    }
}
