using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            GenMeth();
            Console.ReadKey();
        }
        public static void GenMeth()
        {

            AbstractHandler[] handlers = new AbstractHandler[3];
            Console.WriteLine($"Number of formats allowed = {handlers.Length}");

            for (int i = 0; i < handlers.Length; i++)
            {
                Console.WriteLine("Choose the document format: (XML, TXT, DOC)");
                string choise = Console.ReadLine();
                Console.Write("\n");
                if (choise == "XML")
                {
                    new XMLHandler(choise).AllMethods();
                }
                else if (choise == "TXT")
                {
                    new TXTHandler(choise).AllMethods();
                }
                else if (choise == "DOC")
                {
                    new DOCHandler(choise).AllMethods();
                }
                else
                {
                    Console.WriteLine("Somethimg wemt wrong. Choose another format..");
                    break;
                }
            }

            Console.WriteLine("Closing....");

        }
    }
    abstract class AbstractHandler
    {
        public string FormatName { get; set; }
        public AbstractHandler(string name)
        {
            this.FormatName = name;
        }
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    class Realization : AbstractHandler
    {

        public Realization(string name)
            : base(name)
        { }

        public override void Create()
        {
            Console.WriteLine($"Creating {FormatName} document");
        }

        public override void Open()
        {
            Console.WriteLine($"Opening {FormatName} document");
        }
        public override void Change()
        {
            Console.WriteLine($"Opening {FormatName} document");
        }
        public override void Save()
        {
            Console.WriteLine($"Saving {FormatName} document");
        }

        public virtual void AllMethods()
        {
            Create();
            Open();
            Change();
            Save();
        }
    }
    class XMLHandler : Realization
    {

        public XMLHandler(string name)
            : base(name)
        { }

        public override void AllMethods()
        {
            base.AllMethods();
        }
    }
    class TXTHandler : Realization
    {
        public TXTHandler(string name)
            : base(name)
        { }
        public override void AllMethods()
        {
            base.AllMethods();
        }

    }
    class DOCHandler : Realization
    {
        public DOCHandler(string name)
            : base(name)
        { }
        public override void AllMethods()
        {
            base.AllMethods();
        }
    }
}
