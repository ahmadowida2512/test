using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    // Base class
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }
    }

    // Interfaces
    public interface IRunnable
    {
        void Run();
    }

    public interface IJumpable
    {
        void Jump();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    // Kangaroo class implementing Creature, IRunnable, and IJumpable
    public class Kangaroo : Creature, IRunnable, IJumpable
    {
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }

        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }

        public override void Speak()
        {
            Debug.Log("Kangaroo says: Hop!");
        }
    }

    // Duck class implementing Creature, IRunnable, and ISwimmable
    public class Duck : Creature, IRunnable, ISwimmable
    {
        public void Run()
        {
            Debug.Log("Duck runs.");
        }

        public void Swim()
        {
            Debug.Log("Duck swims.");
        }

        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }
    }

    // Manager class to demonstrate polymorphism
   
   
}
