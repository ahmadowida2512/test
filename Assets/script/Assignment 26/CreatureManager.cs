using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {

        void Start()
        {
            List<Creature> creatures = new List<Creature>();

            // Creating instances of Kangaroo and Duck
            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();

            // Adding instances to the creatures list
            creatures.Add(kangaroo);
            creatures.Add(duck);

            // Separate lists for each interface
            List<IRunnable> runnableCreatures = new List<IRunnable>();
            List<IJumpable> jumpableCreatures = new List<IJumpable>();
            List<ISwimmable> swimmableCreatures = new List<ISwimmable>();

            // Adding instances to respective interface lists
            runnableCreatures.Add(kangaroo);
            runnableCreatures.Add(duck);

            jumpableCreatures.Add(kangaroo);

            swimmableCreatures.Add(duck);

            // Calling Speak() for each creature
            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }

            // Calling Run() for each runnable creature
            foreach (IRunnable runnable in runnableCreatures)
            {
                runnable.Run();
            }

            // Calling Jump() for each jumpable creature
            foreach (IJumpable jumpable in jumpableCreatures)
            {
                jumpable.Jump();
            }

            // Calling Swim() for each swimmable creature
            foreach (ISwimmable swimmable in swimmableCreatures)
            {
                swimmable.Swim();
            }

        }



    }
}