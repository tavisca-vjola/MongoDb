   using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Database.FileOperation
{
    public class FileOperation
    {
        public List<string> ReadAllRegions(string path)
        {
            var unParsedString = new List<string>();
            try
            {
                using (var streamReader = new StreamReader(path))
                {
                    string location;
                    while ((location = streamReader.ReadLine()) != null)
                    {
                        unParsedString.Add(location);
                    }


                }
                
            }
            


            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return unParsedString;

        }

    }

}
