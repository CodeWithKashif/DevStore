using System;

namespace TemplatePatternDemo
{
    /// <summary>
    /// The AbstractClass participant which contains the template method.
    /// </summary>
    abstract class Bread
    {
        public abstract void MixIngredients();

        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine("Slicing the " + GetType().Name + " bread!");
        }

        /// <summary>
        /// This is the Template Method
        /// Template Method pattern defines in what order certain steps should occur,
        /// but can optionally leave the specific details of those steps to be implemented by other classes.
        ///
        /// So here making steps/ordering is defined that first it will --
        /// Mixing Ingredients -> then Baking will happen -> then Slicing of bread
        /// </summary>
        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }
    }
}