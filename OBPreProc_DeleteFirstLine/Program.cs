using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace OBPreProc_DeleteFirstLine
{
    class Program
    {
        static int Main(string[] args)
        {
            /* Arguments
             * 0:   Path to Input File
             * 1:   Path to Output File
            */

            try
            {
                //log.Info($"Entering With Input File: {args[0]} and Output File: {args[1]}");
                if(!File.Exists(args[0]))
                {
                    return (int) ExitCode.InputFileNotFound;
                }

                var lines = File.ReadAllLines(args[0]);
                File.WriteAllLines(args[1], lines.Skip(1).ToArray());

                //log.Info($"Successfully Removed First line of Input File with remaining sent to Output File.  Returning Success");
                return (int) ExitCode.Success;
            }
            catch(Exception ex)
            {
                //log.Error(ex.Message);
                //log.Error("Returning Failure Code");
                return (int) ExitCode.Failure;
            }
            

        }

        enum ExitCode : int
        {
            Success = 0,
            InputFileNotFound = 1,
            Failure = 10
        }

        //static log4net.ILog log =
            //log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
