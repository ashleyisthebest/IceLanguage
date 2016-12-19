using System;
using System.Collections.Generic;
using System.Text;
using BrendanGrant.Helpers.FileAssociation;

namespace IceFileExtensionCreator
{
    class Program
    {
        static void Main(string[] args)
        {

            FileAssociationInfo fai = new FileAssociationInfo(".ice");
            if (!fai.Exists)
            {
                fai.Create("IceFile");

                //Specify MIME type (optional)
                fai.ContentType = "code/icefile";

                //Programs automatically displayed in open with list
                fai.OpenWithList = new string[]
               { "notepad.exe", "wordpad.exe", "atom.exe", "Notepad++.exe" };
            }

            ProgramAssociationInfo pai = new ProgramAssociationInfo(fai.ProgID);
            if (!pai.Exists)
            {
                pai.Create
                (
                //Description of program/file type
                "Ice File",

                new ProgramVerb
                     (
                     //Verb name
                     "Open",
                     //Path and arguments to use
                     @"C:\Users\Ashley\AppData\Local\atom\app-1.12.5\atom.exe %1"
                     )
                   );

                pai.DefaultIcon = new ProgramIcon(@"C:\Program Files\Ice\iceicon.ico");
            }
        }
    }
}
