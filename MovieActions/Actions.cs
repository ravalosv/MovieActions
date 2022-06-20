using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace MoveFiles
{
    public class Actions
    {
        // Mueve archivos de una carpeta hacia las subcarpetas con su primer letra
        public void MoverDeACarpeta(string origen, string destino)
        {
            List<string> files = new List<string>();
            try
            {
                files = Directory.GetFiles(origen).ToList();
            } catch(Exception e)
            {
                
            }

            // remove duplicated files
            files.RemoveAll(p => p.Contains("(1)"));
            
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string firstLetter = fileName.Substring(0, 1);

                //string dirDest = "";


                if (char.IsDigit(char.Parse(firstLetter)))
                {
                    firstLetter = "#";
                } else if (char.IsLetter(char.Parse(firstLetter)))
                {
                    ; // No hacer nada
                } else
                {
                    firstLetter = "";
                }

                if (firstLetter != "")
                {
                    string dirDest = Path.Combine(destino, firstLetter);

                    if (dirDest != origen)
                    {
                        // verificar si existe el directorio
                        if (!Directory.Exists(dirDest))
                        {
                            Console.WriteLine("Creando directorio: " + dirDest);
                            Directory.CreateDirectory(dirDest);
                        }

                        string fileDest = Path.Combine(dirDest, fileName);

                        try
                        {
                            Console.WriteLine("Moviendo: " + fileName);
                            File.Move(file, fileDest);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("ERROR: " + fileName);
                        }
                    }

                }

            }

        }



        // Mueve los archivos de subfolder hacia la carpeta root
        public void MoverARaiz(string root)
        {
            MoverARaizAux(root, root);
        }



        public void RenameFilesToUnderscore(string currentFolder)
        {

            //string newName = Path.Combine(currentFolder, "_"); // currentFolder + @"\_";
            var files = Directory.GetFiles(currentFolder).Where(p => !p.Contains("_") && !p.EndsWith(".jpg")).ToList();
            foreach (string fullFileName in files)
            {
                string fileName = "_" + Path.GetFileName(fullFileName);


                string dest = Path.Combine(currentFolder, fileName);
                
                // fullFileName.Replace(currentFolder, newName);

                Console.WriteLine("Renombrando " + fullFileName);

                try
                {
                    File.Move(fullFileName, dest);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
            }
        }

        private void MoverARaizAux(string root, string currentFolder)
        {
            var folders = Directory.GetDirectories(currentFolder);

            foreach (string folder in folders)
            {
                MoverARaizAux(root, folder);
            }

            if (root == currentFolder) return;

            var files = Directory.GetFiles(currentFolder);

            foreach (string file in files)
            {
                //string x = "_" + Path.GetFileName(file);
                string x = Path.GetFileName(file);

                string dest = Path.Combine(root, x);

                //string dest = file.Replace(currentFolder, root);

                Console.WriteLine("Moviendo " + file);
                try
                {
                    File.Move(file, dest);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
            }


        }

        public void deleteEmptyDirectories(string startLocation)
        {
            //string del = Path.Combine(startLocation, "*.jpg");
            //string strCmdText;
            //strCmdText = "/C del /b '" + del + "'";
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            

            foreach (var directory in Directory.GetDirectories(startLocation))
            {
                deleteEmptyDirectories(directory);
                if (Directory.GetFiles(directory).Length == 0 &&
                    Directory.GetDirectories(directory).Length == 0)
                {
                    Console.WriteLine($"Borrando directorio: {directory}");
                    Directory.Delete(directory, false);
                }
            }
        }
    }
}
