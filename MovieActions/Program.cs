using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Actions a = new Actions();

            //var startLocation = @"M:\My Media\Infantiles";
            //a.MoverARaiz(startLocation);
            //a.deleteEmptyDirectories(startLocation);
            //a.RenameFilesToUnderscore(startLocation);

            //startLocation = @"Z:\My Media\00. POR ORDENAR\Raspando\F";
            //a.MoverARaiz(startLocation);
            //a.deleteEmptyDirectories(startLocation);
            //a.RenameFilesToUnderscore(startLocation);

            //startLocation = @"Z:\My Media\00. POR ORDENAR\Raspando\G";
            //a.MoverARaiz(startLocation);
            //a.deleteEmptyDirectories(startLocation);
            //a.RenameFilesToUnderscore(startLocation);



            //a.MoverASuLetraCorrespondiente(@"M:\My Media 2\Plex\KARAOKES", @"M:\My Media 2\Plex\KARAOKES_T");
            //a.MoverASuLetraCorrespondiente(@"Z:\My Media\Peliculas 2\F", @"Z:\My Media\Peliculas 2");
            //a.MoverASuLetraCorrespondiente(@"Z:\My Media\Peliculas 2\G", @"Z:\My Media\Peliculas 2");

            a.MoverDeACarpeta(@"M:\My Media\Peliculas\!Accion-Aventura\Acción", @"M:\My Media\Peliculas\!Accion-Aventura\Acción");
            a.MoverDeACarpeta(@"M:\My Media\Peliculas\!Accion-Aventura\Accion", @"M:\My Media\Peliculas\!Accion-Aventura\Acción");
            a.MoverDeACarpeta(@"M:\My Media\Peliculas\!Accion-Aventura\Action", @"M:\My Media\Peliculas\!Accion-Aventura\Acción");
            a.MoverDeACarpeta(@"M:\My Media\Peliculas\!Accion-Aventura\Adventure", @"M:\My Media\Peliculas\!Accion-Aventura\Aventura");
            a.MoverDeACarpeta(@"M:\My Media\Peliculas\!Accion-Aventura\Aventura", @"M:\My Media\Peliculas\!Accion-Aventura\Aventura");
            a.MoverDeACarpeta(@"M:\My Media\Peliculas\!Accion-Aventuras\Animación", @"M:\My Media\Peliculas\!Accion-Aventura\Animación");
            a.MoverDeACarpeta(@"M:\My Media\Peliculas\!Accion-Aventura\Ciencia Ficcion", @"M:\My Media\Peliculas\!Accion-Aventura\Ciencia Ficcion");
            a.MoverDeACarpeta(@"M:\My Media\Peliculas\!Accion-Aventura\Ciencia ficción", @"M:\My Media\Peliculas\!Accion-Aventura\Ciencia Ficcion");
            a.MoverDeACarpeta(@"M:\My Media\Peliculas\!Accion-Aventura\Fantasía", @"M:\My Media\Peliculas\!Accion-Aventura\Fantasía");
            a.MoverDeACarpeta(@"M:\My Media\Peliculas\!Accion-Aventura\Thriller", @"M:\My Media\Peliculas\!Accion-Aventura\Thriller");






            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Acción", @"M:\My Media\Peliculas\!Accion-Aventura\Acción");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Accion", @"M:\My Media\Peliculas\!Accion-Aventura\Acción");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Action", @"M:\My Media\Peliculas\!Accion-Aventura\Acción");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Adventure", @"M:\My Media\Peliculas\!Accion-Aventura\Aventura");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Aventura", @"M:\My Media\Peliculas\!Accion-Aventura\Aventura");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Animación", @"M:\My Media\Peliculas\!Accion-Aventura\Animación");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Ciencia Ficcion", @"M:\My Media\Peliculas\!Accion-Aventura\Ciencia Ficcion");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Ciencia ficción", @"M:\My Media\Peliculas\!Accion-Aventura\Ciencia Ficcion");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Fantasía", @"M:\My Media\Peliculas\!Accion-Aventura\Fantasía");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Thriller", @"M:\My Media\Peliculas\!Accion-Aventura\Thriller");

            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Animación", @"M:\My Media\Peliculas\!Animacion-Infantiles\Animación");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Animación 1", @"M:\My Media\Peliculas\!Animacion-Infantiles\Animación");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Animation", @"M:\My Media\Peliculas\!Animacion-Infantiles\Animación");

            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Comedia", @"M:\My Media\Peliculas\!Comedia-Comedy\Comedia");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Comedy", @"M:\My Media\Peliculas\!Comedia-Comedy\Comedia");

            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Documental", @"M:\My Media\Peliculas\!Documental-Programa TV-Musical\Documental");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Música", @"M:\My Media\Peliculas\!Documental-Programa TV-Musical\Música");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Película de TV", @"M:\My Media\Peliculas\!Documental-Programa TV-Musical\Película de TV");

            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Drama", @"M:\My Media\Peliculas\!Drama-Romance-Familia\Drama");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Familia", @"M:\My Media\Peliculas\!Drama-Romance-Familia\Familia");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Romance", @"M:\My Media\Peliculas\!Drama-Romance-Familia\Romance");

            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Historia", @"M:\My Media\Peliculas\!Otros Generos\Historia");

            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Horror", @"M:\My Media\Peliculas\!Terror-Suspenso\Horror");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Misterio", @"M:\My Media\Peliculas\!Terror-Suspenso\Misterio");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Suspense", @"M:\My Media\Peliculas\!Terror-Suspenso\Suspense");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Terror", @"M:\My Media\Peliculas\!Terror-Suspenso\Terror");

            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Bélica", @"M:\My Media\Peliculas\!Western-Crimen-Guerra\Bélica");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Crimen", @"M:\My Media\Peliculas\!Western-Crimen-Guerra\Crimen");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Crimen 2", @"M:\My Media\Peliculas\!Western-Crimen-Guerra\Crimen 2");
            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Western", @"M:\My Media\Peliculas\!Western-Crimen-Guerra\Western");

            a.MoverDeACarpeta(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\Peliculas 4K", @"M:\My Media\Peliculas 4k");


            a.deleteEmptyDirectories(@"M:\My Media\00. POR ORDENAR\FreeCloud\Generos\");
            //a.MoverDeACarpeta(@"M:\My Media\Peliculas 4k", @"M:\My Media\Peliculas 4k");



            Console.WriteLine("Proceso finalizado, presiona una tecla para continuar...");
            Console.ReadLine();







        }

        private static void renameDirectory(string startLocation)
        {
            var exts = new string[] { "*.mp4", "*.mkv", "*.avi" };

            foreach (string ext in exts)
            {
                string[] filePaths = Directory.GetFiles(startLocation, ext,
                                             SearchOption.AllDirectories);

                foreach (string filePath in filePaths)
                {
                    var filename = Path.GetFileName(filePath);

                    filename = filename.Replace(ext.Replace("*.", "."), "");

                    var DirName = Directory.GetParent(filePath).Name;
                    var originalPath = Directory.GetParent(filePath).FullName;
                    var newPath = originalPath.Replace(DirName, filename);

                    if (originalPath != newPath)
                        try
                        {
                            Console.WriteLine($"Renombrando Directorio: {newPath}");
                            Directory.Move(originalPath, newPath);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                }
            }
        }



        private static void moveFilesToRoot(string rootLocation, string moveToLocation)
        {
            foreach (var directory in Directory.GetDirectories(rootLocation))
            {
                moveFilesToRoot(directory, moveToLocation);

                var files = Directory.GetFiles(directory);

                
                if (files.Length > 0 )
                {
                    foreach (var file in files)
                    {
                        var fileName = Path.GetFileName(file);
                        var newFileName = Path.Combine(rootLocation, fileName);

                        Console.WriteLine($"Moviendo file: {file}");

                        File.Move(file, newFileName);
                    }
                }
            }

        }
    }
}
