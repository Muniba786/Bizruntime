/*using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp24
{
    class ErrorEventArgEx
    {
        public void eea()
        {
            
            Exception myException = new Exception("This is an exception test");

            
            ErrorEventArgs myErrorEventArgs = new ErrorEventArgs(myException);

           
            Exception myReturnedException = myErrorEventArgs.GetException();
            MessageBox.Show("The returned exception is: " + myReturnedException.Message);
        }
    }
}
*/