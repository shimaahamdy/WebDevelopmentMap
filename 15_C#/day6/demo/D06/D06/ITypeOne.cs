using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06
{
    interface IType1
    {
        void MyFun();
    }

    class Type1 : IType1
    {
        void IType1.MyFun()
        {
            Console.WriteLine("Explicit Implementation");
        }
    }


    interface IType2
    {
        void MyFun();
    }

    //class Type12 : IType1, IType2
    //{
    //    public void MyFun() //Cater for Both Interfaces
    //    {
    //        Console.WriteLine("Both Versions");
    //    }
    //}

    class Type12 : IType1, IType2
    {
        public void MyFun() //Cater for IType1
        {
            Console.WriteLine("IType1 Versions");
        }

        void IType2.MyFun()
        {
            Console.WriteLine("IType2 Version");
        }
    }

    interface IRedo
    {
        void Redo();
    }

    interface IRedoUndo : IRedo
    {
        void UnDo();
    }

    abstract class TextBoxBase : IRedoUndo
    {
        public virtual void Redo()
        {
            Console.WriteLine("Redo");
        }

        public abstract void UnDo();
    }


}
