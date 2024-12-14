using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {

        void Start()
        {
            List<Creature> creatures = new List<Creature>();

        
            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();

            
            creatures.Add(kangaroo);
            creatures.Add(duck);

            
            List<IRunnable> runnableCreatures = new List<IRunnable>();
            List<IJumpable> jumpableCreatures = new List<IJumpable>();
            List<ISwimmable> swimmableCreatures = new List<ISwimmable>();

            runnableCreatures.Add(kangaroo);
            runnableCreatures.Add(duck);

            jumpableCreatures.Add(kangaroo);

            swimmableCreatures.Add(duck);

          
            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }

            foreach (IRunnable runnable in runnableCreatures)
            {
                runnable.Run();
            }

            
            foreach (IJumpable jumpable in jumpableCreatures)
            {
                jumpable.Jump();
            }

            foreach (ISwimmable swimmable in swimmableCreatures)
            {
                swimmable.Swim();
            }

        }



    }
}