using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO.Compression;

namespace CommentRemover
{
    /// <summary>
    /// Tools to remove comments from a filve input C\C++\C# file
    /// </summary>
    public class CommentRemover
    {
        public static string inputFilePath;

        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Mainm(string[] args)
        {

            if (args.Count() == 0)
            {
                //throw new ArgumentException("No Input arguments have been specified.");
                PrintHelp();
            }
            else if (args.Count() == 1)
            {
                //throw new ArgumentException("Not all the input arguments have been specified.");
                PrintHelp();
            }
            else if (args.Count() == 2)
            {
                if (File.Exists(args[0]) && IsValidFile(args[0]))
                {
                    inputFilePath = args[0];
                    var list = new List<string>();
                    var blockComments = @"/\*(.*?)\*/";
                    var lineComments = @"//(.*?)(\r?\n|$)";
                    var strings = @"""((\\[^\n]|[^""\n])*)""";
                    var verbatimStrings = @"@(""[^""]*"")+";

                    string finalOutPut = Regex.Replace(File.ReadAllText(inputFilePath),
                        blockComments + "|" + lineComments + "|" + strings + "|" + verbatimStrings,
                        line =>
                        {
                            if (line.Value.StartsWith("/*") || line.Value.StartsWith("//"))
                            {
                                list.Add(line.Groups[1].Value + line.Groups[2].Value);
                                return line.Value.StartsWith("//") ? line.Groups[3].Value : "";
                            }
                            return line.Value;
                        },
                        RegexOptions.Singleline);

                    if (File.Exists(args[1]))
                    {
                        using (FileStream fileStream = File.Open(args[1], FileMode.Create))
                        {
                            fileStream.Write(new UTF8Encoding(true).GetBytes(finalOutPut), 0, finalOutPut.Length);
                            fileStream.Close();
                        }
                    }
                    else
                    {
                        using (FileStream fileStream = File.Create(args[1]))
                        {
                            fileStream.Write(new UTF8Encoding(true).GetBytes(finalOutPut), 0, finalOutPut.Length);
                            fileStream.Close();
                        }
                    }
                }
                else
                {
                    //throw new FileNotFoundException(string.Format("File does not exists at the given path : {0}", args[0]));
                    PrintHelp();
                }
            }
        }

        /// <summary>
        /// Checks if the input fils is a Valid file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool IsValidFile(string filePath)
        {
            if ((Path.GetExtension(filePath).Equals(".cs") ||
                    Path.GetExtension(filePath).Equals(".cpp") ||
                    Path.GetExtension(filePath).Equals(".c") ||
                    Path.GetExtension(filePath).Equals(".h")))
            {
                return true;
            }
            else
                throw new ArgumentException("Invalid file extension.");
        }

        /// <summary>
        /// Print the Help page
        /// </summary>
        public static void PrintHelp()
        {
            Console.WriteLine("\t ******Comment Remover****** \t");
            Console.WriteLine("Example : \n\t CommentRemover <InputFile{.cs, .cpp, .c, .h files}> <OutputFile>.");
        }

        //Test Cases that I have validated
        /*
         1. Argument validation with no arguments, One Argument and two arguments. If something goes wrong in the arguments a help is print on the console.
         2. File input with comments //
         3. File input with comments /* 
         4. File input with combination of the 1 with in 2
         5. File input with combination of the 2 with in 1
         6. File being remove after it is read from the disk
         7. Empty file
         8. Input file as C sharp file with .cs extension
         9. Input file as C file with .c extension
         10. Input file as C++ file with .cpp extension
         11. Input file as C++ header file with .h extension
         12. Output file as .cs
         13. Output file as .cpp
         14. output file as .c
         15. output file as .h
         16. output file as .txt
         17. File Only with Comments
         18. file with only comments but with combination of 1 and 2
         */
    
        /// <summary>
        /// Tools to remove comments from a filve input C\C++\C# file
        /// </summary>
        public class CommentRemover2
        {
            public static string inputFilePath;

            /// <summary>
            /// Main Method
            /// </summary>
            /// <param name="args"></param>
            static void MainS(string[] args)
            {
                if (args.Count() == 0)
                {
                    PrintHelp();
                }
                else if (args.Count() == 1)
                {
                    PrintHelp();
                }
                else if (args.Count() == 2)
                {
                    if (File.Exists(args[0]) && IsValidFile(args[0]))
                    {
                        inputFilePath = args[0];
                        var lines = File.ReadAllLines(inputFilePath);

                        var fileMode = new FileMode();
                        var isMultiCommentLine = false;

                        //Set the file mode to Open if already exists if not create it
                        if (File.Exists(args[1]))
                            fileMode = FileMode.Open;
                        else
                            fileMode = FileMode.Create;

                        using (FileStream fstream = File.Open(args[1], fileMode))
                        {
                            foreach (var line in lines)
                            {
                                var trimmedLine = line.Trim();
                                if (trimmedLine.StartsWith(@"//")) //Ignore complete line if it starts with //
                                    continue;

                                if (line.Contains(@"//"))
                                {
                                    //check if there is anything before the comment and copy that content to the file 
                                    var outLine = line.Substring(0, line.IndexOf(@"//") - 1) + Environment.NewLine;
                                    fstream.Write(new UTF8Encoding(true).GetBytes(outLine), 0, outLine.Length);
                                }
                                else
                                {
                                    //Check if the multi comment line starts with /* and ends with */
                                    if (trimmedLine.StartsWith(@"/*") && trimmedLine.EndsWith(@"*/"))
                                    {
                                        continue;
                                    }
                                    else if (line.Contains("/*") && line.Contains(@"*/"))
                                    {
                                        //Check with multi comment is specified as a single line comment
                                        var output1 = line.Substring(0, line.IndexOf(@"/*")) + line.Substring(line.IndexOf(@"*/") + 2) + Environment.NewLine;
                                        fstream.Write(new UTF8Encoding(true).GetBytes(output1), 0, output1.Length);
                                    }
                                    else if (trimmedLine.StartsWith(@"/*") || (line.Contains("/*") && !line.Contains("*/")))
                                    {
                                        //Check if its a multi line comment
                                        isMultiCommentLine = true;
                                        continue;
                                    }
                                    else if (line.Contains("*/") && isMultiCommentLine)
                                    {
                                        isMultiCommentLine = false;//Ignore if its the closing multi line comment
                                        continue;
                                    }
                                    else
                                    {
                                        var outLine3 = line.Substring(0, line.Length) + Environment.NewLine;
                                        fstream.Write(new UTF8Encoding(true).GetBytes(outLine3), 0, outLine3.Length);
                                    }
                                }
                            }
                            fstream.Close();
                        }
                    }
                    else
                    {
                        PrintHelp();
                    }
                }
            }

            /// <summary>
            /// Checks if the input fils is a Valid file
            /// </summary>
            /// <param name="filePath"></param>
            /// <returns></returns>
            public static bool IsValidFile(string filePath)
            {
                if ((Path.GetExtension(filePath).Equals(".cs") ||
                        Path.GetExtension(filePath).Equals(".cpp") ||
                        Path.GetExtension(filePath).Equals(".c") ||
                        Path.GetExtension(filePath).Equals(".h")))
                {
                    return true;
                }
                else
                    throw new ArgumentException("Invalid file extension.");
            }

            /// <summary>
            /// Print the Help page
            /// </summary>
            public static void PrintHelp()
            {
                Console.WriteLine("\t ******Comment Remover****** \t");
                Console.WriteLine("Example : \n\t CommentRemover <InputFile{.cs, .cpp, .c, .h files}> <OutputFile>.");
            }

            
            //Test Cases that I have validated
            /*
             1. Argument validation with no arguments, One Argument and two arguments. If something goes wrong in the arguments a help is print on the console.
             2. File input with comments //
             3. File input with comments /* 
             4. File input with combination of the 1 with in 2
             5. File input with combination of the 2 with in 1
             6. File being remove after it is read from the disk
             7. Empty file
             8. Input file as C sharp file with .cs extension
             9. Input file as C file with .c extension
             10. Input file as C++ file with .cpp extension
             11. Input file as C++ header file with .h extension
             12. Output file as .cs
             13. Output file as .cpp
             14. output file as .c
             15. output file as .h
             16. output file as .txt
             17. File Only with Comments
             18. file with only comments but with combination of 1 and 2
             */
        }
    }
}


