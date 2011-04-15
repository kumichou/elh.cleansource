using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ELH.CleanSource
{
    public class FileHandling
    {
        public static void DeleteSubFolders(DirectoryInfo d, Patterns patterns)
        {
            List<FileSystemInfo> listing = new List<FileSystemInfo>();
            listing = GetFileSystemItems(d, patterns);

            // Check Directories first
            List<DirectoryInfo> directories = GetSpecificInfo<DirectoryInfo>(listing).ToList();

            foreach (DirectoryInfo directoryInfo in directories)
            {
                if (directoryInfo.Exists)
                {
                    SetAttributesToNormal(directoryInfo);

                    DirectoryInfo[] d_svn_subs = directoryInfo.GetDirectories("*", SearchOption.AllDirectories);

                    foreach (DirectoryInfo d_svn_sub in d_svn_subs)
                    {
                        SetAttributesToNormal(d_svn_sub);

                        // delete all the files and the folder found
                        DeleteFolder(d_svn_sub);
                    }

                    DeleteFolder(directoryInfo);
                }
            }

            //Check Files Next
            List<FileInfo> files = GetSpecificInfo<FileInfo>(listing).ToList();

            foreach (FileInfo fileInfo in files)
            {
                if (fileInfo.Exists)
                {
                    SetAttributesToNormal(fileInfo);

                    fileInfo.Delete();
                }
            }
        }

        public static List<string> GetMatchList(DirectoryInfo d, Patterns patterns)
        {
            var parentDirectory = d.FullName + "\\";

            List<FileSystemInfo> listing = new List<FileSystemInfo>();
            List<string> mungedFileSystemItems = new List<string>();

            listing = GetFileSystemItems(d, patterns);

            foreach (FileSystemInfo info in listing)
            {
                var shortenedName = info.FullName.Replace(parentDirectory, "");
                mungedFileSystemItems.Add(shortenedName);
            }

            mungedFileSystemItems.Sort();

            return mungedFileSystemItems;
        }

        /// <summary>
        /// Delete a folder, if exists
        /// </summary>
        /// <param name="d"></param>
        public static void DeleteFolder(DirectoryInfo d)
        {
            try
            {
                if (d.Exists)
                {
                    // bye bye SVN folder
                    d.Delete(true);

                    // all ok, warn the user
                    Console.WriteLine(String.Format("{0} - deleted", d.FullName));
                }
            }
            catch (IOException iox)
            {
                // impossible to write on disk
                Console.WriteLine(String.Format("{0} - impossible to delete: access denied!", d.FullName));
            }
            catch (Exception ex)
            {
                // other errors
                Console.WriteLine(String.Format("An error occured during the operation: {0}", ex.Message));
            }
        }

        /// <summary>
        /// Set the file attributes to Normal (not "Read-only")
        /// </summary>
        /// <param name="fileSystemInfo">The folder or file to analize</param>
        public static void SetAttributesToNormal(FileSystemInfo fileSystemInfo)
        {
            if (fileSystemInfo is DirectoryInfo)
            {
                var d = fileSystemInfo as DirectoryInfo;

                if (d.Exists)
                {
                    FileInfo[] files = d.GetFiles("*");

                    foreach (FileInfo f in files)
                    {
                        File.SetAttributes(f.FullName, FileAttributes.Normal);
                    }
                       
                }
            }
            else if (fileSystemInfo is FileSystemInfo)
            {
                var f = fileSystemInfo as FileSystemInfo;

                if (f.Exists)
                {
                    File.SetAttributes(f.FullName, FileAttributes.Normal);
                }
            }
        }

        private static List<FileSystemInfo> GetFileSystemItems(DirectoryInfo d, Patterns patterns)
        {
            List<FileSystemInfo> listing = new List<FileSystemInfo>();
            var fileRegexStrings = patterns.File.Split(',');
            var directoryRegexStrings = patterns.Directory.Split(',');

            foreach (string regex in directoryRegexStrings)
            {
                listing.AddRange(d.GetDirectories(regex, SearchOption.AllDirectories));
            }

            foreach (string regex in fileRegexStrings)
            {
                listing.AddRange(d.GetFiles(regex, SearchOption.AllDirectories));
            }

            return listing;
        }

        private static IEnumerable<T> GetSpecificInfo<T>(IEnumerable<FileSystemInfo> list) where T : FileSystemInfo
        {
            return list.OfType<T>();
        }
    }

    public class Patterns
    {
        public string File;
        public string Directory;
    }
}
