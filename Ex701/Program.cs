using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex701
{

    class A
    {
        public void NormalFun() { Console.WriteLine("A NormalFun()"); }
        public virtual void VirtualFun() { Console.WriteLine("A VirtualFun()"); VirtualFun2(); }
        public virtual void VirtualFun2() { Console.WriteLine("A VirtualFun2()"); }
    }

    class B : A
    {
        public void NormalFun() { Console.WriteLine("B NormalFun()"); }
        public virtual void VirtualFun() { Console.WriteLine("B VirtualFun()"); VirtualFun2(); }
        public override void VirtualFun2() { Console.WriteLine("B VirtualFun2()"); }
    }

    class C : B
    {
        public override void VirtualFun() { Console.WriteLine("C VirtualFun()"); }
    }

    class D : C
    {
        public void NormalFun() { Console.WriteLine("D NormalFun()"); }
        public override void VirtualFun() { Console.WriteLine("D VirtualFun()"); }
        public override void VirtualFun2() { Console.WriteLine("D VirtualFun2()"); }
    }

    abstract class E : D
    {
        public virtual void VirtualFun() { Console.WriteLine("E VirtualFun()"); }
        public abstract void VirtualFun2();
    }

    class F : E
    {
        public override void VirtualFun() { Console.WriteLine("F VirtualFun()"); }
        public override void VirtualFun2() { Console.WriteLine("F VirtualFun2()"); }
    }

    abstract class G : F
    {
        public virtual void VirtualFun() { Console.WriteLine("G VirtualFun()"); }
        public abstract void VirtualFun2();
    }

    class H : G
    {
        public void NormalFun() { Console.WriteLine("H NormalFun()"); }
        public override void VirtualFun() { Console.WriteLine("H VirtualFun()"); }
        public override void VirtualFun2() { Console.WriteLine("H VirtualFun2()"); }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tu jest wynik:");

            A o1 = new D();
            o1.VirtualFun();
            o1.NormalFun();

            A o2 = new B();
            o2.VirtualFun();
            o2.NormalFun();

            B o3 = new C();
            o3.NormalFun();
            o3.VirtualFun();

            D o4 = new D();
            o4.VirtualFun();
            o4.VirtualFun2();

            B o5 = new C();
            o5.VirtualFun2();
            o5.VirtualFun();

            F o6 = new F();
            o6.VirtualFun();
            o6.VirtualFun2();

            Console.ReadKey();
 
        }
    }
   
}
