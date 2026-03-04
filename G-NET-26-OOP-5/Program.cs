namespace G_NET_26_OOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions 
            #region Q1
            //Q1 : What is an interface in C#? Why do we use interfaces instead of depending on concrete classes directly? Mention at least three benefits of using interfaces.
            //A1 : An interface defines a contract that a class must follow. It specifies what a class can do, not how it does it.(Interface = Promise, not implementation) .
            //   - we use interfaces instead of depending on concrete classes directly to : Enable polymorphism without inheritance, Remove tight coupling between classes, Enable multiple inheritance(behavior) .
            #endregion

            #region Q2
            //Q2 : Look at the following code and answer the questions below:
            //    interface IEnglishSpeaker
            //{
            //    void Greet();
            //}

            //interface IArabicSpeaker
            //{
            //    void Greet();
            //}

            //class Translator : IEnglishSpeaker, IArabicSpeaker
            //{
            //    public void Greet()
            //    {
            //        Console.WriteLine("Hello / Ahlan");
            //    }
            //}
            // a) What is the problem with this design? Both interfaces have a method called Greet() — how does the class handle it currently?
            // a)=> Both IEnglishSpeaker.Greet() and IArabicSpeaker.Greet() resolve to the same method body. we cannot give them separate behaviors, the two contracts have been merged into one, which defeats the purpose of having two distinct interfaces.
            // b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" and IArabicSpeaker.Greet() says "Ahlan"? What is this technique called?
            // b)=> The technique is called Explicit Interface Implementation. we prefix the method name with the interface name (InterfaceName.MethodName), giving each interface its own separate implementation .
            // c) After applying your fix, can you call Greet() directly on a Translator object (e.g. translator.Greet())? Why or why not? How do you call each version?
            // c)=> No, we cannot. Explicit interface implementations are hidden from the class's public interface. They are only accessible through an interface reference. To call each version correctly we must cast the object to the desired interface type first .
            #endregion

            #region Q3
            //Q3 : Explain the difference between a shallow copy and a deep copy. When would you use each one? What is the risk of using a shallow copy when the object has reference-type fields?
            //A3 : - A shallow copy copies the object but copies references for reference-type fields. Risky . Fast performance . Lower memory usage .
            //     - A deep copy copies the object and all nested objects, creating fully independent duplicates. Safe . Slower performance . Higher memory usage .
            //     - Use Shallow → object is immutable, no nested reference state, performance is critical .
            //     - Use Deep → objects must be isolated, modifications should not affect original .
            //     - the risk of using a shallow copy when the object has reference-type fields :Two objects, same inner references , Changing inner object affects both copies .
            #endregion

            #region Q4
            //Q4 : Look at the following code and determine the output. Explain why.

            //class Department { public string Name; }
            //        class Employee
            //        {
            //            public string Title;
            //            public Department Dept;
            //            public Employee ShallowCopy() => (Employee)this.MemberwiseClone();
            //        }

            //        var e1 = new Employee { Title = "Dev", Dept = new Department { Name = "IT" } };
            //        var e2 = e1.ShallowCopy();
            //        e2.Title = "QA";
            //e2.Dept.Name = "Testing";

            //Console.WriteLine($"{e1.Title} - {e1.Dept.Name}");
            //Console.WriteLine($"{e2.Title} - {e2.Dept.Name}");

            // The Output:
            // Dev - Testing
            // Qa - Testing

            #endregion
            #endregion
        }
    }
}
