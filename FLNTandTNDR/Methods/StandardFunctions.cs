using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FLNTandTNDR.Methods
{
    public class StandardFunctions
    {
        public string ReadFile(string path)
        {
            string fileContent = string.Empty;
            bool fileExists = File.Exists(path);
            switch (fileExists)
            {
                case true:
                    {
                        try
                        {
                            using (StreamReader sr = new StreamReader(path))
                            {
                                fileContent = sr.ReadToEnd();
                            }
                        }
                        catch (Exception e)
                        {
                            fileContent = "ERROR : " + e.Message;
                        }
                        break;
                    }
                case false:
                    {
                        fileContent = "Specified File Does Not Exist, please validate your file path.";
                        break;
                    }
            }
            return fileContent;
        }
    }
}