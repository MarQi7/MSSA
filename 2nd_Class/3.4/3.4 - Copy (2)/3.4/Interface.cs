using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    internal interface Interface //make a template to import to a class (avoids forgetting or re-creating needed methods.)
    {
        void method();
        int methodMath();
        

    }
    interface GenericMath<T>
    {
        T Multiply(T x, T y);
        T Add(T x, T y);
        T Subtract(T x, T y, params T[] z);   
        T Exponent(T x, T y);
        // I can create method template that take whatever paramaters I want, including delegate methods
        // 
        
    }
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
    interface ICRUD<T>//  where T : class -where can add specification
    {
        // Create Refresh? Update Delete
        void Create(T obj);
        IList<T> GetAll(); // returns collection class variables w/IList (it is the return type)
        void Update(T obj);
        void Delete(T obj); 

    }

    class DataOperations : ICRUD<Person> // creates template of the ICRUD methods replacing <T> with <Person> 
    {
        static List<Person> list = new List<Person>();
        public DataOperations() { }
        public void Create(Person obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person obj)
        {
            throw new NotImplementedException();
        }

        public IList<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Person obj)
        {
            throw new NotImplementedException();
        }
    }

    class B : Interface //the derived class must impliment methods that have no body, multiple interfaces are allowed.
    {
        public void method()
        {
            throw new NotImplementedException();
        }

        public int methodMath()
        {
            throw new NotImplementedException();
        }

        //  GenericMath maths = new Math();
    }
}
