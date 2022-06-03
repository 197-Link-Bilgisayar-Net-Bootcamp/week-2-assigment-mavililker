using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.LSP
{
    internal class LSP
    {

        public interface ITakePhoto
        {
            void TakePhoto();
        }
        public abstract class Phone
        {
            public void Call()
            {
                Console.WriteLine("Has been called.");
            }

        
        }

        public class Iphone : Phone, ITakePhoto
        {
             public void TakePhoto()
            {
                Console.WriteLine("Photo");
            }
        }

        public class Nokia : Phone
        {
          
        }

    }
}
