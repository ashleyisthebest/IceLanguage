using System;
using System.Collections.Generic;
using System.Text;
using BrendanGrant.Helpers.FileAssociation;
using System.Diagnostics;

namespace IceFileExtensionCreator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");

            FileAssociationInfo fai = new FileAssociationInfo(".ice");

                fai.Create("IceFile");

                //Specify MIME type (optional)
                fai.ContentType = "code/icefile";

                //Programs automatically displayed in open with list
                fai.OpenWithList = new string[]
               { "notepad.exe", "wordpad.exe", "atom.exe", "Notepad++.exe" };


            ProgramAssociationInfo pai = new ProgramAssociationInfo(fai.ProgID);

                pai.Create
                (
                //Description of program/file type
                "Ice File",

                new ProgramVerb
                     (
                     //Verb name
                     "Open",
                     //Path and arguments to use
                     Environment.GetEnvironmentVariable("windir") + "\\system32\\notepad.exe %1%"
                     )
                   );

            Process regeditProcess = Process.Start("regedit.exe", "/s filetype.reg");
            regeditProcess.WaitForExit();

            //pai.DefaultIcon = new ProgramIcon(@"C:\Program Files\Ice\iceicon.ico");

        }
    }
}
