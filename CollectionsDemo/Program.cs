using System;
using System.Collections;
using System.Data.SqlTypes;//NonGeneric

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object obj;
            //int i = 100;
            //obj = i;//Boxing-----putting value type into reference type
            //                    //only value types can be boxed

            //int j = (int)obj; //Unboxing


            //string s = "hello";
            //obj = s;

            //WorkingWithStack();

            //WorkingWithQueue();

            Stack s1=new Stack();   
            s1.Push(1);
            s1.Push(2);
            s1.Push("dfsfs");
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3.34f);
            list.Add("dsfs");
            list.Add('A');
            foreach (object i in list) {
                Console.WriteLine(i);
            
            }
            Console.WriteLine("--------------------");
            list.AddRange(s1);
            Console.WriteLine("After adddrange");
            Console.WriteLine("-------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove(1);//value
            Console.WriteLine("After removing 1");
            Console.WriteLine("-------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(0);//index
            Console.WriteLine("After remove at");
            Console.WriteLine("-------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            list.RemoveRange(0, 2);//from  0 the index remove 2 elements
            Console.WriteLine("After removerange");
            Console.WriteLine("-------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Insert(4, 40);//on 4th index insert 40
            Console.WriteLine("After inserting 40 at 4th index");
            Console.WriteLine("-------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.InsertRange(0, s1);//add a range of elements from the specified index
            Console.WriteLine("After insert range");
            Console.WriteLine("-------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Stack s2=new Stack();
            s2.Push(100);
            s2.Push(200);
            s2.Push(300);

            list.SetRange(0, s2);
            Console.WriteLine("After set range");
            Console.WriteLine("-------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }












            Console.ReadLine();

































        }

        private static void WorkingWithQueue()
        {
            Queue q = new Queue();//FIFO
            q.Enqueue(1);//add
            q.Enqueue(2.33f);
            q.Enqueue("Hello");
            object o = q.Dequeue();//remove
            object o1 = q.Peek();//top most element
            foreach (var item in q)
            {
                Console.WriteLine();
            }
        }

        private static void WorkingWithStack()
        {
            Stack s = new Stack();//System.Collections//NonGeneric Stack//LIFO
            s.Push(1);
            s.Push(2.33f);
            s.Push(new DateTime(2002, 12, 10));
            s.Push(78.8888d);
            s.Push("Hello");
            s.Push('A');


            object o = s.Pop();//
            Console.WriteLine(o);



            o = s.Peek();
            Console.WriteLine("Peek =" + o);
            Console.WriteLine("Print stack");
            //s.Clear();
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            //  object[] objarr=s.ToArray();
            Array a1 = Array.CreateInstance(typeof(object), s.Count);
            s.CopyTo(a1, 0);

            bool ans = s.Contains("Welcome");
            Console.WriteLine("Exists= " + ans);
        }
    }
}





