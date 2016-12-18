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
                fai.Create("ice");

                //Specify MIME type (optional)
                fai.ContentType = "ice/ice";

                //Programs automatically displayed in open with list
                fai.OpenWithList = new string[]
               { "notepad.exe", "wordpad.exe", "notepad++.exe" };
            }

            ProgramAssociationInfo pai = new ProgramAssociationInfo(fai.ProgID);
            if (!pai.Exists)
            {
                pai.Create
                (
                //Description of program/file type
                "An ice language file",

                new ProgramVerb
                     (
                     //Verb name
                     "Open",
                     //Path and arguments to use
                     @"C:\ProgramFiles\Ice\icecompiler.exe %1"
                     )
                   );

                //optional
                pai.DefaultIcon = new ProgramIcon(@"C:\ProgramFiles\Ice\iceicon.ico");
            }
        }
    }
}
